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
        // GET: ParetoChart
        public ActionResult ParetoChart()
        {
            List<ParetoChartData> chartData = new List<ParetoChartData>
            {
                new ParetoChartData { xValue = "Traffic", yValue = 56, yValue1 = 33.8 },
                new ParetoChartData { xValue = "Child Care", yValue = 44.8, yValue1 = 60.9 },
                new ParetoChartData { xValue = "Transport", yValue = 27.2, yValue1 = 77.3 },
                new ParetoChartData { xValue = "Weather", yValue = 19.6, yValue1 = 89.1 },
                new ParetoChartData { xValue = "Emergency", yValue = 6.6, yValue1 = 100 },
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class ParetoChartData
        {
            public string xValue;
            public double yValue;
            public double yValue1;
        }
    }
}