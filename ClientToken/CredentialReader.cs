using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using WTG.IdentitySecurity;

namespace ClientToken;

internal class CredentialReader
{
	public static RSA ReadPrivateKey(string privateKeyPath)
	{
		try
		{
			var privateKeyPem = File.ReadAllText(privateKeyPath);
			var privateKey = RSAKeyProvider.ImportPrivateKey(privateKeyPem);
			return privateKey;
		}
		catch (Exception ex)
		{
			throw new Exception("Error reading private key: " + ex.Message, ex);
		}
	}

	public static X509Certificate2 ReadCertificate(string certificatePath)
	{
		try
		{
			var certificate = new X509Certificate2(certificatePath);
			return certificate;
		}
		catch (Exception ex)
		{
			throw new Exception("Error reading certificate: " + ex.Message, ex);
		}
	}
}
