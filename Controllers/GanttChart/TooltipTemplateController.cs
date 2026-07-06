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
        // GET: Gantt
        public ActionResult TooltipTemplate()
        {
            ViewData["DataSource"] = GanttData.TooltipData();
            ViewData["Resources"] = GanttData.EditingResources();
            return View();
        }
    }
}