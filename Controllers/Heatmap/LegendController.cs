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
        // GET: Arrayrow
        public ActionResult Legend()
        {
            ViewBag.textStyle = new
            {
                size = "15px",
                fontWeight = "500",
                fontStyle = "Normal",
                fontFamily = "Segoe UI"
            };
            string[] xlabels = new string[7] { "London", "Berlin", "Madrid", "Paris", "Rome", "Lisbon", "Dublin" };
            ViewBag.xLabels = xlabels;
            string[] yLabels = new string[12] { "12AM", "2AM", "4AM", "6AM", "8AM", "10AM", "12PM",
                "2PM", "4PM", "6PM", "8PM", "10PM" };
            ViewBag.yLabels = yLabels;
            ViewBag.dataSource = new HeatMapData().GetLegendData();
            return View();
        }
    }
}