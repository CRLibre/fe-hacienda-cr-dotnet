using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRLibre
{
    public static class MyAuthentication
    {
        public const String ApplicationCookie = "ApiAuthenticationType";
    }
    public partial class Startup
	{
        public  void ConfigureAuth(IAppBuilder app)
        {
            // need to add UserManager into owin, because this is used in cookie invalidation
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = MyAuthentication.ApplicationCookie,
                LoginPath = new PathString("/"),
                Provider = new CookieAuthenticationProvider(),
                CookieName = "CrLibre",
                CookieHttpOnly = true,
                ExpireTimeSpan = TimeSpan.FromHours(12), // adjust to your needs
            });
        }
    }
}