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
        public ActionResult DependencyTypes()
        {
            ViewData["DataSource"] = GanttData.DependencyData();
            ViewData["ToolbarItems"] = new List<string> { "Add", "Edit", "Update", "Delete", "Cancel", "ExpandAll", "CollapseAll" };
            return View();
        }
    }
}