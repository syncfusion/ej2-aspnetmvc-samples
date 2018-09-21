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
        // GET: DateTimeAxis
        public ActionResult DateTimeAxis()
        {
            List<DateTimeData> chartData = new List<DateTimeData>
            {
                new DateTimeData { xValue = new DateTime(2016, 03, 01), yValue1 = 6.3, yValue2 = -5.3},
                new DateTimeData { xValue = new DateTime(2016, 04, 01), yValue1 = 13.3, yValue2 = 1.0 },
                new DateTimeData { xValue = new DateTime(2016, 05, 01), yValue1 = 18.0, yValue2 = 6.9 },
                new DateTimeData { xValue = new DateTime(2016, 06, 01), yValue1 = 19.8, yValue2 = 9.4 },
                new DateTimeData { xValue = new DateTime(2016, 07, 01), yValue1 = 18.1, yValue2 = 7.6 },
                new DateTimeData { xValue = new DateTime(2016, 08, 01), yValue1 = 13.1, yValue2 = 2.6 },
                new DateTimeData { xValue = new DateTime(2016, 09, 01), yValue1 = 4.1, yValue2 = -4.9 },
            };
            ViewBag.dataSource = chartData;
            return View();
        }

        public class DateTimeData
        {
            public DateTime xValue;
            public double yValue1;
            public double yValue2;
        }
    }
}