namespace ClientToken;

internal class DummyHttpClientFactory : IHttpClientFactory
{
	public DummyHttpClientFactory()
	{ }

	public HttpClient CreateClient(string name)
	{
		return new HttpClient();
	}
}
