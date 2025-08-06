using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenGenerator
{
	internal class DummyHttpClientFactory : IHttpClientFactory
	{
		public DummyHttpClientFactory()
		{ }

		public HttpClient CreateClient(string name)
		{
			return new HttpClient();
		}
	}
}
