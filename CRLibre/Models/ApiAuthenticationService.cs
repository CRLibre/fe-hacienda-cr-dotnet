using Microsoft.Owin.Security;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace CRLibre.Models
{
    public class ApiAuthenticationService
    {
        public class AuthenticationResult
        {
            public AuthenticationResult(string errorMessage = null)
            {
                ErrorMessage = errorMessage;
            }
            public String ErrorMessage { get; private set; }
            public Boolean IsSuccess => String.IsNullOrEmpty(ErrorMessage);
        }
        private readonly IAuthenticationManager authenticationManager;
        public ApiAuthenticationService(IAuthenticationManager authenticationManager)
        {
            this.authenticationManager = authenticationManager;
        }
        public AuthenticationResult SignIn(String username, String password)
        {

            bool isAuthenticated = false;
            string sessionKey = "";
            try
            {
                var values = new Dictionary<string, string>
                {
                   { "userName", username },
                   { "pwd", password }
                };
                ApiConnect api = new ApiConnect();
                JToken jObjet = api.PostApi(values,"users", "users_log_me_in");
                sessionKey = (string)jObjet["sessionKey"];
                isAuthenticated = true;
            }
            catch (Exception e)
            {
                return new AuthenticationResult("El usuario o la contraseña son incorrectos");
            }
            var identity = CreateIdentity(username, sessionKey);
            authenticationManager.SignOut(MyAuthentication.ApplicationCookie);
            authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, identity);
            return new AuthenticationResult();
        }
        private ClaimsIdentity CreateIdentity(string Name, string sessionKey)
        {
            var identity = new ClaimsIdentity(MyAuthentication.ApplicationCookie, ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            identity.AddClaim(new Claim("http://schemas.microsoft.com/accesscontrolservice/2010/07/claims/identityprovider", "API CrLibre"));
            identity.AddClaim(new Claim(ClaimTypes.Name, Name));
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, Name));
            identity.AddClaim(new Claim(ClaimTypes.Sid, sessionKey));
            return identity;
        }
    }
}