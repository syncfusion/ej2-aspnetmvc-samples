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
                new PieWithLegendChartData { xValue = "Net-tution and Fees",           yValue = 21, text = "21%"},
                new PieWithLegendChartData { xValue = "Self-supporting Operations",    yValue = 21, text = "21%"},
                new PieWithLegendChartData { xValue = "Private Gifts",                 yValue = 8 , text = "8%"},
                new PieWithLegendChartData { xValue = "All Other",                     yValue = 8 , text = "8%"},
                new PieWithLegendChartData { xValue = "Local Revenue",                 yValue = 4 , text = "4%"},
                new PieWithLegendChartData { xValue = "State Revenue",                 yValue = 21, text = "21%"},
                new PieWithLegendChartData { xValue = "Federal Revenue",               yValue = 16, text = "16%"}
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class PieWithLegendChartData
        {
            public string xValue;
            public double yValue;
            public string text;
        }
    }
}