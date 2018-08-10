using CRLibre.Models;
using System;
using System.Web.Mvc;
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Security.Principal;
using System.Web;
using Microsoft.Owin.Security;
using System.Configuration;
using System.Security.Claims;

namespace CRLibre.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return Redirect("/Home");
            }
            else
            {
                return View();

            }
        }
        // POST: Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Index(Login model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                
                IAuthenticationManager authenticationManager = HttpContext.GetOwinContext().Authentication;
                var authService = new ApiAuthenticationService(authenticationManager);
                var authenticationResult = authService.SignIn(model.userName, model.pwd);
                if (authenticationResult.IsSuccess)
                {
                    return Redirect("/Home");

                }
                ModelState.AddModelError("", authenticationResult.ErrorMessage);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);

            }
            return View(model);
        }
        public ActionResult Logoff()
        {
            try
            {
                var claims = User.Identity as ClaimsIdentity;
                var sessionKey = claims.FindFirst(ClaimTypes.Sid).Value;
                var values = new Dictionary<string, string>
                {
                   { "iam", User.Identity.Name },
                   { "sessionKey", sessionKey }
                };
                ApiConnect api = new ApiConnect();
                JToken jObjet = api.PostApi(values, "users", "users_log_me_out");
                
            }
            catch (Exception e)
            {

            }
            IAuthenticationManager authenticationManager = HttpContext.GetOwinContext().Authentication;
            authenticationManager.SignOut(MyAuthentication.ApplicationCookie);
            return RedirectToAction("Index");
        }
        
    }

}