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
        // GET: DashedLine
        public ActionResult DashedLine()
        {
            List<DashedLineChartData> chartData = new List<DashedLineChartData>
            {
                new DashedLineChartData { xValue = new DateTime(2005, 01, 01), yValue = 12, yValue1 = 9.5 },
                new DashedLineChartData { xValue = new DateTime(2006, 01, 01), yValue = 10.6, yValue1 = 19.9 },
                new DashedLineChartData { xValue = new DateTime(2007, 01, 01), yValue = 15.6, yValue1 = 25.2 },
                new DashedLineChartData { xValue = new DateTime(2008, 01, 01), yValue = 38.6, yValue1 = 36 },
                new DashedLineChartData { xValue = new DateTime(2009, 01, 01), yValue = 27.4, yValue1 = 16.6 },
                new DashedLineChartData { xValue = new DateTime(2010, 01, 01), yValue = 23.5, yValue1 = 14.2 },
                new DashedLineChartData { xValue = new DateTime(2011, 01, 01), yValue = 16.6, yValue1 = 10.3 },
            };
            ViewBag.dashedDataSource = chartData;
            return View();
        }

        public class DashedLineChartData
        {
            public DateTime xValue;
            public double yValue;
            public double yValue1;
        }
    }
}