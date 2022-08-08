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
        // GET: PieWithLegend
        public ActionResult PieWithLegend()
        {
            List<PieWithLegendChartData> chartData = new List<PieWithLegendChartData>
            {
                new PieWithLegendChartData { x = "Net-tution",           y = 21, text = "21%"},
                new PieWithLegendChartData { x = "Private Gifts",                 y = 8 , text = "8%"},
                new PieWithLegendChartData { x = "All Other",                     y = 9 , text = "9%"},
                new PieWithLegendChartData { x = "Local Revenue",                 y = 4 , text = "4%"},
                new PieWithLegendChartData { x = "State Revenue",                 y = 21, text = "21%"},
                new PieWithLegendChartData { x = "Federal Revenue",               y = 16, text = "16%"},
                new PieWithLegendChartData { x = "Self-supporting Operations",    y = 21, text = "21%"},
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class PieWithLegendChartData
        {
            public string x;
            public double y;
            public string text;
        }
    }
}