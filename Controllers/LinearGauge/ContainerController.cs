using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.LinearGauge
{
    public partial class LinearGaugeController : Controller
    {
        public ActionResult Container()
        {
            ViewData["orientation"] = new string[] { "Vertical", "Horizontal" };
            ViewData["container"] = new string[] { "Thermometer", "Normal", "Rounded Rectangle" };
            return View();
        }
    }
}