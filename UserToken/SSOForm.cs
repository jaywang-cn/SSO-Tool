using WTG.OpenIDConnect.Login;
using System.Diagnostics;
using static WTG.OpenIDConnect.Login.OIDCLoginRequestMessage;

namespace TokenGenerator
{
	public partial class SSOForm : Form
	{
		public SSOForm()
		{
			InitializeComponent();

			try
			{
				comboBox2.DataSource = Enum.GetValues(typeof(OIDCServer));

				comboBox1.SelectedItem = "Jaywtgb2c";
				domainHintTextBox.Text = "Azure";
				redirectUrl.Text = "http://127.0.0.1/CargowiseOne/Authorize/";
			}
			catch (Exception ex)
			{
				result1TextBox.Text = ex.Message;
			}
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (button1.Text == "Stop")
				{
					TokenSource.Cancel();
					return;
				}

				TokenSource = new CancellationTokenSource();

				button1.Text = "Stop";
				result1TextBox.Text = string.Empty;
				accessToken.Text = string.Empty;

				var authorityUrl = new Uri(authUrlTextBox.Text);
				var clientId = clientIdTextBox.Text;
				var domainHint = domainHintTextBox.Text;
				var serverType = (OIDCServer)Enum.Parse(typeof(OIDCServer), comboBox2.SelectedValue.ToString());
				var customScopes = string.IsNullOrEmpty(scopesTextBox.Text) ? new string[0] : scopesTextBox.Text.Split(' ');
				var scopes = GetScopes(serverType, clientId);
				var finalScopes = customScopes.Concat(scopes).ToArray();
				var loginRequest = new OIDCLoginRequestMessage(
					authorityUrl,
					clientId,
					"",
					finalScopes,
					LoginPrompt.Login,
					serverType,
					"Success",
					"Oops, something went wrong. Please try again or contact your System Administrator.",
					90,
					domainHint,
					Guid.NewGuid());

				var oidcLogin = new OIDCLogin(redirectUrl.Text, Path.Combine(Application.StartupPath, "refresh_token"), new NullLogger(), new OIDCWebLauncher((url) => Process.Start(new ProcessStartInfo(url) { UseShellExecute = true })));
				var loginResult = await oidcLogin.PerformLoginAsync(loginRequest, TokenSource.Token);

				if (loginResult.Error != OIDCLoginResponseMessage.ErrorType.None)
				{
					result1TextBox.Text = loginResult.ErrorString + loginResult.ErrorDescription;
				}
				else
				{
					result1TextBox.Text = loginResult.IdentityToken;
					accessToken.Text = loginResult.AccessToken;
				}
			}
			catch (Exception ex)
			{
				result1TextBox.Text = ex.Message + Environment.NewLine + ex.StackTrace;
			}
			finally
			{
				button1.Text = "Start";
			}
		}

		string[] GetScopes(OIDCServer serverType, string clientId)
		{
			switch (serverType)
			{
				case OIDCServer.Azure:
					return new string[] { "openid", "offline_access", clientId };
				case OIDCServer.OneLogin:
					return new string[] { "openid", "params", "profile" };
				default:
					return new string[] { "openid", "offline_access" };
			}
		}

		CancellationTokenSource TokenSource = new CancellationTokenSource();

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (comboBox1.Text)
			{
				case "Jaywtgb2c":
					authUrlTextBox.Text = "https://jaywtgb2c.b2clogin.com/jaywtgb2c.onmicrosoft.com/B2C_1A_SIGNUP_SIGNIN/v2.0/";
					clientIdTextBox.Text = "3a3eae3b-2640-4a5c-9e0f-23d2ffaa4f38";
					comboBox2.SelectedItem = OIDCServer.Azure;
					domainHintTextBox.Enabled = true;
					break;
				case "CargoWiseB2CTest01":
					authUrlTextBox.Text = "https://CargoWiseB2CTest01.b2clogin.com/CargoWiseB2CTest01.onmicrosoft.com/B2C_1A_SIGNUP_SIGNIN/v2.0/";
					clientIdTextBox.Text = "37f86719-0c35-40c8-97d0-2029fe80e0ea";
					comboBox2.SelectedItem = OIDCServer.Azure;
					domainHintTextBox.Enabled = true;
					break;
				case "CargoWiseB2C01":
					authUrlTextBox.Text = "https://CargoWiseB2C01.b2clogin.com/CargoWiseB2C01.onmicrosoft.com/B2C_1A_signup_signin/v2.0/";
					clientIdTextBox.Text = "3492b154-a8ce-4ce3-a956-511276cbd9e6";
					comboBox2.SelectedItem = OIDCServer.Azure;
					domainHintTextBox.Enabled = true;
					break;
				case "JayOkta":
					authUrlTextBox.Text = "https://dev-58790183.okta.com/oauth2/default";
					clientIdTextBox.Text = "0oa8yogrr3eezB5QW5d7";
					comboBox2.SelectedItem = OIDCServer.Okta;
					domainHintTextBox.Enabled = false;
					break;
				case "JayOneLogin":
					authUrlTextBox.Text = "https://wtgjay-dev.onelogin.com/oidc/2";
					clientIdTextBox.Text = "13bc1700-3127-013d-3fcd-4a95af5f26fa228287";
					comboBox2.SelectedItem = OIDCServer.OneLogin;
					domainHintTextBox.Enabled = false;
					break;
				default:
					break;
			}
		}
	}
}