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
        // GET: EmptyPointChart
        public ActionResult EmptyPointChart()
        {
            ViewBag.data = new string[] { "Column", "Area", "Spline" };
            ViewBag.data1 = new string[] { "Gap", "Drop", "Average", "Zero" };
            return View();
        }
    }
}