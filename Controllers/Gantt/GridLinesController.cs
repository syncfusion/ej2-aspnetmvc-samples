using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Gantt
{
    public partial class GanttController : Controller
    {
        // GET: Gantt
        public ActionResult GridLines()
        {
            ViewBag.DataSource = GanttData.ProjectNewData();
            ViewBag.Data = DropDownLists.GridLinesData();
            return View();
        }

        public class DropDownLists
        {
            public string id { get; set; }
            public string type { get; set; }

            public static List<DropDownLists> GridLinesData()
            {
                List<DropDownLists> Data = new List<DropDownLists>();
                Data.Add(new DropDownLists { id = "Both", type = "Both" });
                Data.Add(new DropDownLists { id = "Vertical", type = "Vertical" });
                Data.Add(new DropDownLists { id = "Horizontal", type = "Horizontal" });
                Data.Add(new DropDownLists { id = "None", type = "None" });
                return Data;
            }
        }
    }
}