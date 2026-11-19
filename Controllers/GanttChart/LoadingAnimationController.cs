using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Gantt
{
    public partial class GanttChartController : Controller
    {
        // GET: LoadingAnimation
        public ActionResult LoadingAnimation()
        {
            ViewData["dataSource"] = GanttData.VirtualData();
            ViewData["data"] = new string[] { "Shimmer", "Spinner" };
            return View();
        }
    }
}