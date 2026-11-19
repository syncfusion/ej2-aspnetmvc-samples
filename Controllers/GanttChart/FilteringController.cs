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
        // GET: Filtering
        public ActionResult Filtering()
        {
            ViewData["DataSource"] = GanttData.FilteredData();
            List<Object> typedropData = new List<object>() {
                new { id = "Menu", type = "Menu" },
                new { id = "Excel", type = "Excel" }
            };
            ViewData["typedropdata"] = typedropData;
            List<Object> modedropData = new List<object>() {
                new { id = "Parent", type = "Parent" },
                new { id = "Child", type = "Child" },
                 new { id = "Both", type = "Both" },
                  new { id = "None", type = "None" }
            };
            ViewData["modedropData"] = modedropData;
            return View();
        }
    }
}