using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using WTG.IdentitySecurity;
using WTG.OpenIDConnect.Token;

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
			audTextbox.Text = ConfigurationManager.AppSettings["AccessTokenAudience"];
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

				var privateKeyPem = File.ReadAllText(privateKeyPathTextBox.Text);
				var privateKey = RSAKeyProvider.ImportPrivateKey(privateKeyPem);

				var certificate = new X509Certificate2(certificatePathTextBox.Text);
				result2TextBox.Text = await new OAuthClientTokenGenerator(new DummyHttpClientFactory()).GetClientAccessTokenAsync(endpoint, privateKey, certificate, azpTextbox.Text, audTextbox.Text, CancellationToken.None);

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
			catch (Exception ex)
			{
				result2TextBox.Text = ex.Message + Environment.NewLine + ex.StackTrace;
			}
		}
	}
}
