using Helpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helpers.Controllers
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


        public ActionResult mostrar( Class1 objeto, FormCollection collection)
        {
            string pasatiempos = collection["Pasatiempos"];

            objeto.pasatiempos = pasatiempos;

            return View(objeto);
        }


        public ActionResult Formulario()
        {
            List<string> pasatiempos = new List<string>();

            pasatiempos.Add("Deportes");
            pasatiempos.Add("Programar");
            pasatiempos.Add("Ver tv");
            pasatiempos.Add("Dormir");


            ViewBag.pasatiempo = pasatiempos;
            return View();
        }
    }
}