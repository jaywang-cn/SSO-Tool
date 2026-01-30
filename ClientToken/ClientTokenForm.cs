using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using WTG.IdentitySecurity;
using WTG.OpenIDConnect.Token;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace ClientToken;

public partial class ClientTokenForm : Form
{
	TextContentCache TextContentCache => textContentCache ??= new TextContentCache();
	TextContentCache textContentCache;
	OAuthClientTokenGenerator tokenGenerator;
	public ClientTokenForm()
	{
		InitializeComponent();
		tokenGenerator = new OAuthClientTokenGenerator(new DummyHttpClientFactory());
	}

	private void button3_Click(object sender, EventArgs e)
	{
		var openFile = new OpenFileDialog() { Multiselect = false, RestoreDirectory = true };
		if (openFile.ShowDialog() == DialogResult.OK)
		{
			TextContentCache.PrivateKeyPath = openFile.FileName;
		}
	}

	private void button4_Click(object sender, EventArgs e)
	{
		var openFile = new OpenFileDialog() { Multiselect = false, RestoreDirectory = true };
		if (openFile.ShowDialog() == DialogResult.OK)
		{
			TextContentCache.CertificatePath = openFile.FileName;
		}
	}

	private async void button2_Click(object sender, EventArgs e)
	{
		try
		{
			result2TextBox.Text = string.Empty;

			var endpoint = endpointTextBox.Text;

			var privateKey = CredentialReader.ReadPrivateKey(privateKeyPathTextBox.Text);
			var certificate = CredentialReader.ReadCertificate(certificatePathTextBox.Text);

			var contextPayload = new JwtPayload();
			bool hasContext = false;
			if (!string.IsNullOrEmpty(claim1NameText.Text) && !string.IsNullOrEmpty(claim1ValueText.Text))
			{
				contextPayload.Add(claim1NameText.Text, claim1ValueText.Text);
				hasContext = true;
			}
			if (!string.IsNullOrEmpty(claim2NameText.Text) && !string.IsNullOrEmpty(claim2ValueText.Text))
			{
				contextPayload.Add(claim2NameText.Text, claim2ValueText.Text);
				hasContext = true;
			}

			var accessToken = await tokenGenerator.GetClientAccessTokenAsync(
				endpoint,
				privateKey,
				certificate,
				azpTextbox.Text,
				null,
				[$"{audTextbox.Text}/.default"],
				hasContext ? contextPayload : null,
				CancellationToken.None);

			result2TextBox.Text = accessToken;

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

	protected override void OnFormClosed(FormClosedEventArgs e)
	{
		base.OnFormClosed(e);
		TextContentCache.Save();
	}
}
