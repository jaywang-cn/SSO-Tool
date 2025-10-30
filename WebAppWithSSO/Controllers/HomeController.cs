using Microsoft.AspNetCore.Mvc;
using WTG.OpenIDConnect.Token;

namespace WebAppWithSSO.Controllers
{
	[Route("home")]
	public class HomeController : Controller
	{
		public HomeController(ILogger<HomeController> logger)
		{
			this.logger = logger;
		}

		readonly ILogger logger;

		[Route("index")]
		public async Task<IActionResult> Index()
		{
			try
			{
				var openIdConnectConfigurationHelper = new OpenIdConnectConfigurationHelper(logger);
				var oAuthClientTokenValidator = new OAuthClientTokenValidator(openIdConnectConfigurationHelper, logger);

				var validatedResult = await oAuthClientTokenValidator.ValidateAccessTokenAsync(["https://login.microsoftonline.com/63506B14-C36F-42CA-8A27-E5DFF31D56FA/v2.0/"], "F1A2BE87-C8DA-4B3C-92D5-4CEDF5AC95F9", "accesstoken", CancellationToken.None);
				return Ok();
			}
			catch (Exception ex)
			{
				return Ok();
			}
		}
	}
}
