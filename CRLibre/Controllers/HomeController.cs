using CRLibre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRLibre.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            List<MenuView> menu = new List<MenuView>
            {
                new MenuView {name= "Acerca", icon= "info", url= "/home/acerca" },
                new MenuView {name = "Contactenos", icon = "address-book", url = "/home/contactenos" }
            };
            ViewBag.menu = menu; 

            base.OnActionExecuting(filterContext);
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Acerca()
        {
            return View();
        }
        public ActionResult Contactenos()
        {
            return View();
        }
    }
}