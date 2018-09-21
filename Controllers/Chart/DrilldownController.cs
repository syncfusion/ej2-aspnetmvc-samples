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
        // GET: Drilldown
        public ActionResult Drilldown()
        {

            List<CategoryData> chartData = new List<CategoryData>
            {
                new CategoryData { x = "SUV", y = 25 },
                new CategoryData { x = "Car", y = 37 },
                new CategoryData { x = "Pickup", y = 15 },
                new CategoryData { x = "Minivan", y = 23 },
                
             };
            ViewBag.dataSource = chartData;

            return View();
        }

        
    }

    public class CategoryData
    {
        public string x;
        public double y;
    }

}