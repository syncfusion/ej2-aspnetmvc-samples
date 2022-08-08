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
        public ActionResult GroupedColumn()
        {
            List<GroupedColumnData> chartData = new List<GroupedColumnData>
            {
                new GroupedColumnData { x = 2012, y = 104, y1 = 46, y2 = 65, y3 = 29, y4 = 91, y5 = 38 },
                new GroupedColumnData { x = 2016, y = 121, y1 = 46, y2 = 67, y3 = 27, y4 = 70, y5 = 26 },
                new GroupedColumnData { x = 2020, y = 113, y1 = 39, y2 = 65, y3 = 22, y4 = 88, y5 = 38 }
            };
            ViewBag.data = chartData;
            return View();
        }
        public class GroupedColumnData
        {
            public double x;
            public double y;
            public double y1;
            public double y2;
            public double y3;
            public double y4;
            public double y5;
        }
    }
}