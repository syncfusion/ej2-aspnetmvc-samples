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
        // GET: MultiLeveLabels
        public ActionResult MultiLevelLabels()
        {
            ViewBag.textStyle = new
            {
                size = "15px",
                fontWeight = "500",
                fontStyle = "Normal",
                fontFamily = "Segoe UI"
            };
            string[] xlabels = new string[11] { "Laptop", "Mobile", "Gaming", "Cosmetics", "Fragrance",
                "Watches", "Handbags", "Apparel", "Kitchenware", "Furniture", "Home Decor"};
            ViewBag.xLabels = xlabels;
            ViewBag.border = new { width = "0" };
            ViewBag.xTextStyle = new { color = "black" };
            string[] yLabels = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            ViewBag.yLabels = yLabels;
            ViewBag.yTextStyle = new { color = "black" };
            ViewBag.dataSource = new HeatMapData().GetMultiLevelData();
            return View();
        }
    }
}