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
        // GET: Column
        public ActionResult Column()
        {
            List<ColumnChartData> ChartPoints = new List<ColumnChartData>
            {
                new ColumnChartData { Country = "Chile", Walnuts = 175000, Almonds = 11300 },
                new ColumnChartData { Country = "European Union", Walnuts = 140000, Almonds = 135000 },
                new ColumnChartData {Country = "Turkey", Walnuts = 67000, Almonds = 24000 },
                new ColumnChartData {Country = "India", Walnuts = 33000, Almonds = 4200 },
                new ColumnChartData {Country = "Australia", Walnuts = 12000, Almonds = 154000 }
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class ColumnChartData
        {
            public string Country;
            public double Walnuts;
            public double Almonds;
        }
    }
}