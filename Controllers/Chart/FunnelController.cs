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
        // GET: Funnel
        public ActionResult Funnel()
        {
            List<FunnelChartData> chartData = new List<FunnelChartData>
            {
                new FunnelChartData { xValue = "Renewed",      yValue = 18.20, text = "18.20%"},
                new FunnelChartData { xValue = "Subscribed",    yValue = 27.3 , text = "27.3%"},
                new FunnelChartData { xValue = "Support",      yValue = 55.9 , text = "55.9% "},
                new FunnelChartData { xValue = "Downloadeded", yValue = 76.8 , text = "76.8% "},
                new FunnelChartData { xValue = "Visited",      yValue = 100  , text = "100%  "}
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class FunnelChartData
        {
            public string xValue;
            public double yValue;
            public string text;
        }
    }
}