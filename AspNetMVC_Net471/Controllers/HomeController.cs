using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC_Net471.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public ActionResult Invalid()
        {
            return Foo();
        }

        private ActionResult Foo()
        {
            int x = 5;
            int y = 6;
            int z = x + y;

            return Bar();
        }

        private ActionResult Bar()
        {
            int aa = 11;
            int bb = 15;
            int cc = aa * bb;
            throw new InvalidOperationException();
        }
    }
}