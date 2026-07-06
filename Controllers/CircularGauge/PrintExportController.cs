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
        public ActionResult PrintExport()
        {
            ViewData["format"] = new string[] { "JPEG", "PNG", "SVG", "PDF" };
            return View();
        }
    }
}