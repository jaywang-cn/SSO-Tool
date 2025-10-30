using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using WTG.OpenIDConnect.Token;

namespace WebAppWithSSO
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddRazorPages();

			builder.Services.AddLogging();

			builder.Services.AddAuthentication(options =>
			{
				options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
			})
				.AddCookie() // Ensure Cookie authentication is added
				.AddOpenIdConnect(options =>
				{
					options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
					options.Authority = "https://login.microsoftonline.com/804a70cf-4a61-4a08-908e-a32b2cff8131/v2.0";
					options.ClientId = "046ff71f-2cfc-4870-98ad-4d1f1c98afe8";
					options.CallbackPath = "/signin-oidc";
					options.UsePkce = true;
					options.RemoteAuthenticationTimeout = TimeSpan.FromMinutes(5);
					options.ClientSecret = "u4J8Q~9.Qewz5mc.Dp341uypCHPj1xze8VCTRb8w";
					options.Scope.Clear();
					options.Scope.Add("openid");
					options.Scope.Add("offline_access");
					options.Scope.Add("profile");

					options.ResponseType = OpenIdConnectResponseType.Code;

					// Ensure proper token validation settings
					options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
					{
						ValidateIssuer = true,
						ValidIssuer = "https://login.microsoftonline.com/804a70cf-4a61-4a08-908e-a32b2cff8131/v2.0",
						ValidateAudience = true,
						ValidAudience = "046ff71f-2cfc-4870-98ad-4d1f1c98afe8",
						ValidateLifetime = true
					};
				});

			builder.Services.AddControllers();

			builder.Services.AddAuthorization();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();

			app.MapControllers();
			app.MapRazorPages();

			app.Run();
		}
	}
}
