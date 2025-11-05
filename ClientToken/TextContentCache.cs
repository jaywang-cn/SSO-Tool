using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ClientToken;

internal class TextContentCache : INotifyPropertyChanged
{
	public TextContentCache()
	{
		try
		{

			if (File.Exists(cacheFileName))
			{
				var lines = File.ReadAllLines(cacheFileName);
				if (lines.Length >= 9)
				{
					AuthorityUrl = lines[0];
					Azp = lines[1];
					Aud = lines[2];
					PrivateKeyPath = lines[3];
					CertificatePath = lines[4];
					Claim1Name = lines[5];
					Claim1Value = lines[6];
					Claim2Name = lines[7];
					Claim2Value = lines[8];
				}
			}
		}
		catch (Exception)
		{
			if (File.Exists(cacheFileName))
			{
				File.Delete(cacheFileName);
			}
		}
	}

	#region Properties

	public string AuthorityUrl
	{
		get => authorityUrl;
		set
		{
			authorityUrl = value;
			NotifyPropertyChanged();
		}
	}
	string authorityUrl;

	public string Azp
	{
		get => azp;
		set
		{
			azp = value;
			NotifyPropertyChanged();
		}
	}
	string azp;

	public string Aud
	{
		get => aud;
		set
		{
			aud = value;
			NotifyPropertyChanged();
		}
	}
	string aud;

	public string PrivateKeyPath
	{
		get => privateKeyPath;
		set
		{
			privateKeyPath = value;
			NotifyPropertyChanged();
		}
	}
	string privateKeyPath;

	public string CertificatePath
	{
		get => certificatePath;
		set
		{
			certificatePath = value;
			NotifyPropertyChanged();
		}
	}
	string certificatePath;

	public string Claim1Name
	{
		get => claim1Name;
		set
		{
			claim1Name = value;
			NotifyPropertyChanged();
		}
	}
	string claim1Name;

	public string Claim1Value
	{
		get => claim1Value;
		set
		{
			claim1Value = value;
			NotifyPropertyChanged();
		}
	}
	string claim1Value;

	public string Claim2Name
	{
		get => claim2Name;
		set
		{
			claim2Name = value;
			NotifyPropertyChanged();
		}
	}
	string claim2Name;

	public string Claim2Value
	{
		get => claim2Value;
		set
		{
			claim2Value = value;
			NotifyPropertyChanged();
		}
	}
	string claim2Value;

	#endregion

	#region INotifyPropertyChanged Members

	public event PropertyChangedEventHandler PropertyChanged;

	void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	#endregion

	public void Save()
	{
		try
		{
			var lines = new List<string>
			{
				AuthorityUrl ?? string.Empty,
				Azp ?? string.Empty,
				Aud ?? string.Empty,
				PrivateKeyPath ?? string.Empty,
				CertificatePath ?? string.Empty,
				Claim1Name ?? string.Empty,
				Claim1Value ?? string.Empty,
				Claim2Name ?? string.Empty,
				Claim2Value ?? string.Empty
			};
			File.WriteAllLines(cacheFileName, lines);
		}
		catch (Exception)
		{
		}
	}

	const string cacheFileName = "TextContentCache.cache";
}
