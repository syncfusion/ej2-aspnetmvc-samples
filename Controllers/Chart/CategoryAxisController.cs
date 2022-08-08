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
        // GET: CategoryAxis
        public ActionResult CategoryAxis()
        {
            List<CategoryData> chartData = new List<CategoryData>
            {
                new CategoryData { x = "Germany", y = 72, country = "GER: 72"},
                new CategoryData { x = "Russia", y = 103.1, country = "RUS: 103.1" },
                new CategoryData { x = "Brazil", y = 139.1, country = "BRZ: 139.1" },
                new CategoryData { x = "India", y = 462.1, country = "IND: 462.1" },
                new CategoryData { x = "China", y = 721.4, country = "CHN: 721.4" },
                new CategoryData { x = "United States<br>Of America", y = 286.9, country = "USA: 286.9" },
                new CategoryData { x = "Great Britain", y = 115.1, country = "GBR: 115.1" },
                new CategoryData { x = "Nigeria", y = 97.2, country = "NGR: 97.2" },
             };
            ViewBag.dataSource = chartData;
            ViewBag.font = new
            {
                fontWeight = "600",
                color = "#ffffff"
            };
            return View();


        }
        public class CategoryData
        {
            public string x;
            public double y;
            public string country;
        }
    }
}