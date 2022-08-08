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
        // GET: Export
        public ActionResult Export()
        {
            List<ExportChartData> chartData = new List<ExportChartData>
            {
                new ExportChartData { xValue = "DEU", yValue = 35.5 },
                new ExportChartData { xValue = "CHN", yValue = 18.3 },
                new ExportChartData { xValue = "ITA", yValue = 17.6 },
                new ExportChartData { xValue = "JPN", yValue = 13.6 },
                new ExportChartData { xValue = "US",  yValue = 12   },
                new ExportChartData { xValue = "ESP", yValue = 5.6  },
                new ExportChartData { xValue = "FRA", yValue = 4.6  },
                new ExportChartData { xValue = "AUS", yValue = 3.3  },
                new ExportChartData { xValue = "BEL", yValue = 3    },
                new ExportChartData { xValue = "UK",  yValue = 2.9  }
                
            };
            ViewBag.dataSource = chartData;
            ViewBag.data = new string[] { "JPEG", "PNG", "SVG", "PDF" };
            return View();
        }
        public class ExportChartData
        {
            public string xValue;
            public double yValue;
            public double yValue1;
            public double yValue2;
        }
    }
}