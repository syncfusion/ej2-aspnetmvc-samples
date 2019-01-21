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
        // GET: PieRadius
        public ActionResult PieRadius()
        {
            List<PieRadiusChartData> chartData = new List<PieRadiusChartData>
            {
                new PieRadiusChartData { xValue = "Argentina", yValue = 505370, r = "100"},
                new PieRadiusChartData { xValue = "Belgium",    yValue = 551500, r = "118.7"},
                new PieRadiusChartData { xValue = "Cuba",  yValue = 312685 , r = "124.6"},
                new PieRadiusChartData { xValue = "Dominican Republic", yValue = 350000 , r = "137.5"},
                new PieRadiusChartData { xValue = "Egypt", yValue = 301000 , r = "150.8"},
                new PieRadiusChartData { xValue = "Kazakhstan", yValue = 300000, r = "155.5"},
                new PieRadiusChartData { xValue = "Somalia",  yValue = 357022, r = "160.6"}
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class PieRadiusChartData
        {
            public string xValue;
            public double yValue;
            public string r;
        }
    }
}