using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.CircularGauge;

namespace EJ2MVCSampleBrowser.Controllers.CircularGauge
{
    public partial class CircularGaugeController : Controller
    {
        public ActionResult Legend()
        {
            ViewData["legendPosition"] = new string[] { "Bottom", "Top", "Left", "Right", "Auto" };
            ViewData["legendAlignment"] = new string[] { "Center", "Far", "Near" };
            ViewData["legendShape"] = new string[] { "Circle", "Rectangle", "Triangle", "Diamond", "Inverted Triangle" };
            return View();
        }
    }
}