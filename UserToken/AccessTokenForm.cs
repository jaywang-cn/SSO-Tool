﻿using IdentityModel.Client;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using WTG.IdentitySecurity;
using WTG.OpenIDConnect.Token;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace TokenGenerator
{
	public partial class AccessTokenForm : Form
	{
		public AccessTokenForm()
		{
			InitializeComponent();
			InitAccessTokenControl();
		}
		void InitAccessTokenControl()
		{
			endpointTextBox.Text = ConfigurationManager.AppSettings["AccessTokenEndpoint"];
			azpTextbox.Text = ConfigurationManager.AppSettings["AccessTokenAzp"];
			audTextbox.Text = ConfigurationManager.AppSettings["AccessTokenAud"];

			var exeDir = Path.GetDirectoryName(Application.ExecutablePath) ?? AppDomain.CurrentDomain.BaseDirectory;
			var privateKeyPath = Path.Combine(exeDir, "Credentials", ConfigurationManager.AppSettings["AccessTokenPrivateKey"] ?? "private.key");
			var certPath = Path.Combine(exeDir, "Credentials", ConfigurationManager.AppSettings["AccessTokenCertificate"] ?? "certificate.cer");
			privateKeyPathTextBox.Text = privateKeyPath;
			certificatePathTextBox.Text = certPath;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			var openFile = new OpenFileDialog() { Multiselect = false, RestoreDirectory = true };
			if (openFile.ShowDialog() == DialogResult.OK)
			{
				privateKeyPathTextBox.Text = openFile.FileName;
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			var openFile = new OpenFileDialog() { Multiselect = false, RestoreDirectory = true };
			if (openFile.ShowDialog() == DialogResult.OK)
			{
				certificatePathTextBox.Text = openFile.FileName;
			}
		}

		private async void button2_Click(object sender, EventArgs e)
		{
			try
			{
				var endpoint = endpointTextBox.Text;

				var privateKey = CredentialReader.ReadPrivateKey(privateKeyPathTextBox.Text);
				var certificate = CredentialReader.ReadCertificate(certificatePathTextBox.Text);

				var contextPayload = new JwtPayload();
				if (!string.IsNullOrEmpty(claim1NameText.Text) && !string.IsNullOrEmpty(claim1ValueText.Text))
				{
					contextPayload.Add(claim1NameText.Text, claim1ValueText.Text);
				}
				if (!string.IsNullOrEmpty(claim2NameText.Text) && !string.IsNullOrEmpty(claim2ValueText.Text))
				{
					contextPayload.Add(claim2NameText.Text, claim2ValueText.Text);
				}

				var assertion = GetClientAssertion(privateKey, certificate, endpoint, azpTextbox.Text, contextPayload);

				var httpResponseMessage = await GetTokenResponseAsync(endpoint, azpTextbox.Text, audTextbox.Text, assertion, CancellationToken.None);
				if (httpResponseMessage.IsSuccessStatusCode)
				{
					result2TextBox.Text = await GetAccessTokenAsync(httpResponseMessage);

					try
					{
						var jwtSecurityToken = new JwtSecurityTokenHandler().ReadJwtToken(result2TextBox.Text);
						var payload = JsonSerializer.Serialize(jwtSecurityToken.Payload, new JsonSerializerOptions() { WriteIndented = true });
						textBox1.Text = payload;
					}
					catch (Exception innerEx)
					{
						textBox1.Text = "Error parsing JWT: " + innerEx.Message + Environment.NewLine + innerEx.StackTrace;
					}
				}
				else
				{
					textBox1.Text = await GetErrorMessageAsync(httpResponseMessage);
				}
			}
			catch (Exception ex)
			{
				result2TextBox.Text = ex.Message + Environment.NewLine + ex.StackTrace;
			}
		}

		static string GetClientAssertion(RSA privateKey, X509Certificate2 cert, string url, string clientId, object contextPayload)
		{
			long num = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
			long num2 = num + 3600;
			long num3 = num - 100;
			JwtPayload payload = new JwtPayload
			{
				{ "jti", Guid.NewGuid().ToString() },
				{ "sub", clientId },
				{ "iss", clientId },
				{ "aud", url },
				{ "exp", num2 },
				{ "iat", num },
				{ "nbf", num3 },
				{ "context", contextPayload }
			};
			return JwtSecurity.GenerateSignedJwt(privateKey, cert, payload);
		}

		static string GetClientAssertion(RSA privateKey, X509Certificate2 cert, string url, string clientId, string serializedContextValue)
		{
			long num = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
			long num2 = num + 3600;
			long num3 = num - 100;
			JwtPayload payload = new JwtPayload
			{
				{ "jti", Guid.NewGuid().ToString() },
				{ "sub", clientId },
				{ "iss", clientId },
				{ "aud", url },
				{ "exp", num2 },
				{ "iat", num },
				{ "nbf", num3 },
				{ "context", serializedContextValue }
			};
			return JwtSecurity.GenerateSignedJwt(privateKey, cert, payload);
		}

		async Task<HttpResponseMessage> GetTokenResponseAsync(string url, string azp, string aud, string clientAssertion, CancellationToken cancellationToken)
		{
			using HttpClient httpClient = new DummyHttpClientFactory().CreateClient();
			httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
			var nameValueCollection = new Dictionary<string, string>
			{
				{ "client_id", azp },
				{ "client_assertion_type", "urn:ietf:params:oauth:client-assertion-type:jwt-bearer" },
				{ "client_assertion", clientAssertion },
				{ "grant_type", "client_credentials" },
				{
					"scope",
					aud + "/.default"
				}
			};
			using FormUrlEncodedContent content = new FormUrlEncodedContent(nameValueCollection);
			return await httpClient.PostAsync(url, content, cancellationToken);
		}

		async Task<string> GetErrorMessageAsync(HttpResponseMessage response)
		{
			string text = await response.Content.ReadAsStringAsync();
			if (ContentIsJson(response))
			{
				JObject jObjectOrThrow = GetJObjectOrThrow(text, GetFailedToGetTokenMessage(text));
				if (jObjectOrThrow.TryGetValue("error", out var value) && jObjectOrThrow.TryGetValue("error_description", out var value2))
				{
					return GetFailedToGetTokenMessage($"{value}.\r\n{value2}");
				}
			}

			return GetFailedToGetTokenMessage(text);
		}

		static async Task<string> GetAccessTokenAsync(HttpResponseMessage response)
		{
			string text = await response.Content.ReadAsStringAsync();
			if (ContentIsJson(response) && GetJObjectOrThrow(text, GetFailedToGetTokenMessage(text)).TryGetValue("access_token", out JToken value))
			{
				return value.Value<string>();
			}

			throw new InvalidOperationException(GetFailedToGetTokenMessage(text));
		}

		private static bool ContentIsJson(HttpResponseMessage response)
		{
			return response.Content.Headers.ContentType?.MediaType == "application/json";
		}

		private static JObject GetJObjectOrThrow(string json, string exceptionMessage)
		{
			try
			{
				return JObject.Parse(json);
			}
			catch (JsonReaderException innerException)
			{
				throw new InvalidOperationException(exceptionMessage, innerException);
			}
		}

		private static string GetFailedToGetTokenMessage(string extraDetails)
		{
			return "Failed to get access token. " + extraDetails;
		}
	}
}
