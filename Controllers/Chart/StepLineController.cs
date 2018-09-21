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
        // GET: StepLine
        public ActionResult StepLine()
        {
            List<StepLineChartData> chartData = new List<StepLineChartData>
            {
                new StepLineChartData { xValue = new DateTime(1975, 01, 01), yValue = 16, yValue1 = 10 },
                new StepLineChartData { xValue = new DateTime(1980, 01, 01), yValue = 12.5, yValue1 = 7.5 },
                new StepLineChartData { xValue = new DateTime(1985, 01, 01), yValue = 19, yValue1 = 11 },
                new StepLineChartData { xValue = new DateTime(1990, 01, 01), yValue = 14.4, yValue1 = 7 },
                new StepLineChartData { xValue = new DateTime(1995, 01, 01), yValue = 11.5, yValue1 = 8 },
                new StepLineChartData { xValue = new DateTime(2000, 01, 01), yValue = 14, yValue1 = 6 },
                new StepLineChartData { xValue = new DateTime(2005, 01, 01), yValue = 10, yValue1 = 3.5 },
                new StepLineChartData { xValue = new DateTime(2010, 01, 01), yValue = 16, yValue1 = 7 },
            };
            ViewBag.dataSource = chartData;
            return View();
        }

        public class StepLineChartData
        {
            public DateTime xValue;
            public double yValue;
            public double yValue1;
        }
    }
}