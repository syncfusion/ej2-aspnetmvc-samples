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
        // GET: Trendlines
        public ActionResult RTL()
        {
            List<RTLData> chartData = new List<RTLData>
            {
                new RTLData { x = 2016, y = 1000, y1 = 400, y2 = 600 },
                new RTLData { x = 2017, y = 970, y1 = 360, y2 = 610 },
                new RTLData { x = 2018, y = 1060, y1 = 920, y2 = 140 },
                new RTLData { x = 2019, y = 1030, y1 = 540, y2 = 490 }
            };
            ViewBag.data = chartData;
            return View();
        }
        public class RTLData
        {
            public double x;
            public double y;
            public double y1;
            public double y2;
        }
    }
}