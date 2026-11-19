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
        public ActionResult TicksAndLabels()
        {
            ViewData["ticks"] = new string[] { "Major Ticks", "Minor Ticks" };
            ViewData["tickPosition"] = new string[] { "Inside", "Cross", "Outside" };
            ViewData["labelPosition"] = new string[] { "Outside", "Cross", "Inside" };
            return View();
        }
    }
}