using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace WebAppWithSSO
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddRazorPages();

			builder.Services.AddAuthentication(options =>
			{
				options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
			})
				.AddCookie() // Ensure Cookie authentication is added
				.AddOpenIdConnect(options =>
				{
					options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
					options.Authority = "https://login.microsoftonline.com/1581207c-5f6f-44fd-924b-7d51e005fa3c/v2.0";
					options.ClientId = "22378506-41bd-4c4f-9a6a-43d45a7f05d6";
					options.CallbackPath = "/signin-oidc";
					options.RemoteAuthenticationTimeout = TimeSpan.FromMinutes(5);
					options.ClientSecret = "H.F8Q~FykIi8StVMjRkEdaVX0129f3xanwvCga8B";
					options.Scope.Clear();
					options.Scope.Add("openid");
					options.Scope.Add("offline_access");
					options.Scope.Add("profile");

					options.ResponseType = OpenIdConnectResponseType.Code;

					// Ensure proper token validation settings
					options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
					{
						ValidateIssuer = true,
						ValidIssuer = "https://login.microsoftonline.com/1581207c-5f6f-44fd-924b-7d51e005fa3c/v2.0",
						ValidateAudience = true,
						ValidAudience = "22378506-41bd-4c4f-9a6a-43d45a7f05d6",
						ValidateLifetime = true
					};
				});

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

			app.MapRazorPages();

			app.Run();
		}
	}
}
