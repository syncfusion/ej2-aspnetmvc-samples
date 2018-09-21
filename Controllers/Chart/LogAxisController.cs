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
        // GET: LogAxis
        public ActionResult LogAxis()
        {
            List<LogAxisChartData> chartData = new List<LogAxisChartData>
            {
                new LogAxisChartData {xValue = new DateTime(1995, 1, 1), yValue1 =80  },
                new LogAxisChartData {xValue = new DateTime(1996, 1, 1), yValue1 =200  },
                new LogAxisChartData {xValue = new DateTime(1997, 1, 1), yValue1 =400  },
                new LogAxisChartData {xValue = new DateTime(1998, 1, 1), yValue1 = 600  },
                new LogAxisChartData {xValue = new DateTime(1999, 1, 1), yValue1 = 700 },
                new LogAxisChartData {xValue = new DateTime(2000, 1, 1), yValue1 = 1400 },
                new LogAxisChartData {xValue = new DateTime(2001, 1, 1), yValue1 = 2000 } ,
                new LogAxisChartData {xValue = new DateTime(2002, 1, 1), yValue1 = 4000 },
                new LogAxisChartData {xValue = new DateTime(2003, 1, 1), yValue1 = 6000 },
                new LogAxisChartData {xValue = new DateTime(2004, 1, 1), yValue1 = 8000  },
                new LogAxisChartData {xValue = new DateTime(2005, 1, 1), yValue1 = 11000  },

            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class LogAxisChartData
        {
            public DateTime xValue;
            public double yValue1;
        }
    }
}