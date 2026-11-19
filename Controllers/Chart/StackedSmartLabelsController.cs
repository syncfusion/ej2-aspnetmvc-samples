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
        // GET: StackedSmartLabels
        public ActionResult StackedSmartLabels()
        {
            List<StackedSmartLabelsChartData> ChartPoints = new List<StackedSmartLabelsChartData>
            {
                new StackedSmartLabelsChartData { X = "Q1 2025", Samsung = 72.3, Apple = 56.2, Xiaomi = 42.7, Oppo = 7.4, Vivo = 5.2, Others = 70.7 },
                new StackedSmartLabelsChartData { X = "Q2 2025", Samsung = 75.9, Apple = 57.1, Xiaomi = 43.9, Oppo = 6.2, Vivo = 3.9, Others = 4.9 },
                new StackedSmartLabelsChartData { X = "Q3 2025", Samsung = 80.1, Apple = 60.3, Xiaomi = 46.0, Oppo = 4.8, Vivo = 3.9, Others = 78.9 },
                new StackedSmartLabelsChartData { X = "Q4 2025", Samsung = 85.5, Apple = 62.7, Xiaomi = 48.9, Oppo = 6.4, Vivo = 5.8, Others = 81.5 }
            };

            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }

        public class StackedSmartLabelsChartData
        {
            public string X;
            public double Samsung;
            public double Apple;
            public double Xiaomi;
            public double Oppo;
            public double Vivo;
            public double Others;
        }
    }
}
