using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contactos()
        {
            return View();
        }

        public ActionResult Lector()
        {
            return View();
        }

        public ActionResult Acercade()
        {
            return View();
        }
    }
}