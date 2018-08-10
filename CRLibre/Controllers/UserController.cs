using CRLibre.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace CRLibre.Controllers
{
    public class UserController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            List<MenuView> menu = new List<MenuView>
            {
                new MenuView {name= "Mi Cuenta", icon= "info", url= "/user" },
                new MenuView {name= "Certificado", icon= "info", url= "/user" },
                new MenuView {name = "Administrar", icon = "address-book", url = "/user/cuentas" }
            };
            ViewBag.menu = menu;

            base.OnActionExecuting(filterContext);
        }
        // GET: User
        public ActionResult Index()
        {
            var claims = User.Identity as ClaimsIdentity;
            var sessionKey = claims.FindFirst(ClaimTypes.Sid).Value;
            var values = new Dictionary<string, string>
                {
                   { "iam", User.Identity.Name },
                   { "sessionKey", sessionKey }
                };
            ApiConnect api = new ApiConnect();
            JToken jObjet = api.PostApi(values, "users", "users_get_my_details");
            User account = new User();

            try
            {
                account = jObjet.ToObject<User>();
                account.lastAccess = new DateTime(int.Parse(account.lastAccess) * 10000).ToString();
            }
            catch (Exception e)
            {

            }
            return View(account);
        }

               // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
