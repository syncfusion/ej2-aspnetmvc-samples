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
        public ActionResult OverView()
        {
            ViewData["DataSource"] = GanttData.OverviewData();
            ViewData["Resources"] = this.GetResources();
            ViewData["Data"] = GanttDropDownLists.GridLinesData();
            return View();
        }

        public class GanttDropDownLists
        {
            public string id { get; set; }
            public string type { get; set; }

            public static List<GanttDropDownLists> GridLinesData()
            {
                List<GanttDropDownLists> Data = new List<GanttDropDownLists>();
                Data.Add(new GanttDropDownLists { id = "Default", type = "Default" });
                Data.Add(new GanttDropDownLists { id = "Grid", type = "Grid" });
                Data.Add(new GanttDropDownLists { id = "Gantt", type = "Gantt" });
                return Data;
            }
        }
    }
}