using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: BarWithGradient
        public ActionResult BarWithGradient()
        {
            var chartPoints = new List<BarGradientData>
            {
                new BarGradientData { Company = "Tata Motors", Revenue = 52.9 },
                new BarGradientData { Company = "State Bank of India", Revenue = 71.8 },
                new BarGradientData { Company = "Oil and Natural Gas Corporation", Revenue = 77.5 },
                new BarGradientData { Company = "Indian Oil Corporation", Revenue = 93.8 },
                new BarGradientData { Company = "Life Insurance Corporation of India", Revenue = 98.0 },
                new BarGradientData { Company = "Reliance Industries", Revenue = 108.8 }
            };

            ViewBag.ChartPoints = chartPoints;
            return View();
        }
    }
    public class BarGradientData
    {
        public string Company { get; set; }
        public double Revenue { get; set; }
    }
}
