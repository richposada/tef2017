using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TEF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Golf");
        }

        public ActionResult Mission()
        {
            return View();
        }
        public ActionResult Evan()
        {
            return View();
        }

        public ActionResult Neuroblastoma()
        {
            return View();
        }

        public ActionResult Donate()
        {
            return View();
        }

        public ActionResult Help()
        {
            return View();
        }

        public ActionResult Treats()
        {
            return View();
        }

        public ActionResult Leadership()
        {
            return View();
        }

        public ActionResult Research()
        {
            return View();
        }

        public ActionResult News()
        {
            return View("Golf");
        }

        
    }
}
