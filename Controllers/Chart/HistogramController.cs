using Syncfusion.EJ2.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: Histogram
        public ActionResult Histogram()
        {
            ViewBag.font = new { FontWeight = "600", Color = "#ffffff" };
            return View();
        }
    }
}