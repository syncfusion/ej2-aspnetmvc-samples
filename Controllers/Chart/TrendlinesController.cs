using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: Trendlines
        public ActionResult Trendlines()
        {
            ViewBag.trendlineTypes = new string[] { "Linear", "Exponential", "Power", "Logarithmic", "Polynomial", "MovingAverage" };
            return View();
        }
    }
}