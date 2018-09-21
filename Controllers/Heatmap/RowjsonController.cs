using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Heatmap
{
    public partial class HeatmapController : Controller
    {
        // GET= Rowjson
        public ActionResult Rowjson()
        {
            ViewBag.textStyle = new
            {
                size = "15px",
                fontWeight = "500",
                fontStyle = "Normal",
                fontFamily = "Segoe UI"
            };
            ViewBag.border = new
            {
                width = 1,
                radius = 4,
                color = "white"
            };
            string[] xlabels = new string[9] { "China", "France", "GBR", "Germany", "Italy", "Japan", "KOR", "Russia", "USA" };
            ViewBag.xLabels = xlabels;
            string[] yLabels = new string[5] { "2000", "2004", "2008", "2012", "2016" };
            ViewBag.yLabels = yLabels;
            ViewBag.title = new { text = "Olympic Year" };
            return View();
        }
    }
}
