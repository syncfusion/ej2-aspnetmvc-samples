using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Heatmap
{
    public partial class HeatmapController : Controller
    {
        // GET: BubbleHeatmap
        public ActionResult BubbleTypes()
        {
            ViewBag.textStyle = new
            {
                size = "15px",
                fontWeight = "500",
                fontStyle = "Normal",
                fontFamily = "Segoe UI"
            };
            string[] xlabels = new string[8] { "Singapore", "Spain", "Australia", "Germany", "Belgium", "USA", "France", "UK" };
            ViewBag.xLabels = xlabels;
            ViewBag.border = new
            {
                width = 1
            };
            string[] yLabels = new string[5] { "1995", "2000", "2005", "2010", "2015" };
            ViewBag.yLabels = yLabels;
            ViewBag.dataSource = new HeatMapData().tableBubbleData();
            return View();
        }
    }
}