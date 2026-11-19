using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: NestedDonut
        public ActionResult NestedDonut()
        {
            Dictionary<string, string> regionColors = new Dictionary<string, string>
            {
                { "South Asia", "#1f4e8c" },
                { "Middle East", "#7a3b8f" },
                { "S.E. Asia", "#e91e63" },
                { "Africa", "#f4c20d" },
                { "Others", "#66a99c" }
            };

            List<NestedDonutChartData> RegionData = new List<NestedDonutChartData>
            {
                new NestedDonutChartData { X = "South Asia", Y = 55.85, Color = regionColors["South Asia"], Text = "South Asia" },
                new NestedDonutChartData { X = "Middle East", Y = 16.15, Color = regionColors["Middle East"], Text = "Middle East" },
                new NestedDonutChartData { X = "S.E. Asia", Y = 7.36, Color = regionColors["S.E. Asia"], Text = "S.E. Asia" },
                new NestedDonutChartData { X = "Africa", Y = 11.25, Color = regionColors["Africa"], Text = "Africa" },
                new NestedDonutChartData { X = "Others", Y = 9.39, Color = regionColors["Others"], Text = "Others" }
            };

            List<NestedDonutChartData> CountryData = new List<NestedDonutChartData>
            {
                new NestedDonutChartData { X = "India", Y = 21.8, Color = regionColors["South Asia"], Text = "India" },
                new NestedDonutChartData { X = "Bangladesh", Y = 12.5, Color = regionColors["South Asia"], Text = "Bangladesh" },
                new NestedDonutChartData { X = "Nepal", Y = 12.5, Color = regionColors["South Asia"], Text = "Nepal" },
                new NestedDonutChartData { X = "Pakistan", Y = 4.7, Color = regionColors["South Asia"], Text = "Pakistan" },
                new NestedDonutChartData { X = "Sri Lanka", Y = 4.35, Color = regionColors["South Asia"], Text = "Sri Lanka" },

                new NestedDonutChartData { X = "Qatar", Y = 10.5, Color = regionColors["Middle East"], Text = "Qatar" },
                new NestedDonutChartData { X = "Iran", Y = 1.0, Color = regionColors["Middle East"], Text = "Iran" },
                new NestedDonutChartData { X = "Jordan", Y = 1.6, Color = regionColors["Middle East"], Text = "Jordan" },
                new NestedDonutChartData { X = "Syria", Y = 1.8, Color = regionColors["Middle East"], Text = "Syria" },
                new NestedDonutChartData { X = "Lebanon", Y = 1.25, Color = regionColors["Middle East"], Text = "Lebanon" },

                new NestedDonutChartData { X = "Philippines", Y = 7.36, Color = regionColors["S.E. Asia"], Text = "Philippines" },

                new NestedDonutChartData { X = "Sudan", Y = 1.9, Color = regionColors["Africa"], Text = "Sudan" },
                new NestedDonutChartData { X = "Egypt", Y = 9.35, Color = regionColors["Africa"], Text = "Egypt" },

                new NestedDonutChartData { X = "Others", Y = 9.39, Color = regionColors["Others"], Text = "Others" }
            };

            ViewData["CountryData"] = CountryData;
            ViewData["RegionData"] = RegionData;

            return View();
        }

        public class NestedDonutChartData
        {
            public string X { get; set; }
            public double Y { get; set; }
            public string Color { get; set; }
            public string Text { get; set; }
        }
    }
}