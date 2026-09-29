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
        public ActionResult MultipleAxes()
        {
            ViewData["axis"] = new string[] { "Axis 1", "Axis 2" };
            ViewData["axisDirection"] = new string[] { "Clockwise", "Anti-clockwise" };
            return View();
        }
    }
}