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
        // GET: DateTimeCategoryAxis
        public ActionResult DateTimeCategoryAxis()
        {
            List<DateTimeCategoryData> chartData = new List<DateTimeCategoryData>
            {
                new DateTimeCategoryData { xValue = new DateTime(2017, 12, 20), yValue1 = 21},
                new DateTimeCategoryData { xValue = new DateTime(2017, 12, 21), yValue1 = 24 },
                new DateTimeCategoryData { xValue = new DateTime(2017, 12, 22), yValue1 = 24},
                new DateTimeCategoryData { xValue = new DateTime(2017, 12, 26), yValue1 = 70},
                new DateTimeCategoryData { xValue = new DateTime(2017, 12, 27), yValue1 = 75 },
                new DateTimeCategoryData { xValue = new DateTime(2018, 01, 02), yValue1 = 82 },
                new DateTimeCategoryData { xValue = new DateTime(2018, 01, 03), yValue1 = 53 },
                new DateTimeCategoryData { xValue = new DateTime(2018, 01, 04), yValue1 = 54 },
                new DateTimeCategoryData { xValue = new DateTime(2018, 01, 05), yValue1 = 53},
                new DateTimeCategoryData { xValue = new DateTime(2018, 01, 08), yValue1 = 45 },
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class DateTimeCategoryData
        {
            public DateTime xValue;
            public double yValue1;
        }
    }
}