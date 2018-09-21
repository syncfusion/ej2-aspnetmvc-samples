using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class NumericTextboxController : Controller
    {
        public class Cultures
        {
            public string CultureName { get; set; }
           
        }

            public ActionResult Internationalization()
        {
            List<Cultures> cultureData = new List<Cultures>();
            cultureData.Add(new Cultures() { CultureName = "de" });
            cultureData.Add(new Cultures() { CultureName = "zh" });
            cultureData.Add(new Cultures() { CultureName = "en" });
            ViewBag.cultureData = cultureData;
            return View();
        }
    }

}