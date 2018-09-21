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
        // GET: InversedSpline
        public ActionResult InversedSpline()
        {
            List<InversedLineChartData> chartData = new List<InversedLineChartData>
            {
                new InversedLineChartData { xValue = "Jan", yValue = -1, yValue1 = 7 },
                new InversedLineChartData { xValue = "Mar", yValue = 12, yValue1 = 2 },
                new InversedLineChartData { xValue = "Apr", yValue = 25, yValue1 = 13 },
                new InversedLineChartData { xValue = "Jun", yValue = 31, yValue1 = 21 },
                new InversedLineChartData { xValue = "Aug", yValue = 26, yValue1 = 26 },
                new InversedLineChartData { xValue = "Oct", yValue = 14, yValue1 = 10 },
                new InversedLineChartData { xValue = "Dec", yValue = 8, yValue1 = 0 },
            };
            ViewBag.dataSource = chartData;
            return View();
        }

        public class InversedLineChartData
        {
            public String xValue;
            public double yValue;
            public double yValue1;
        }
    }
}