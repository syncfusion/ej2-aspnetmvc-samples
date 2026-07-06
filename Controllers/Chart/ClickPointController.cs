using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: ClickPoint
        public ActionResult ClickPoint()
        {
            List<ClickPointChartData> ChartPoints = new List<ClickPointChartData>
            {
                new ClickPointChartData { X = 20,  Y = 20 },
                new ClickPointChartData { X = 80,  Y = 80 }
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class ClickPointChartData
        {
            public double X;
            public double Y;
        }
    }
}