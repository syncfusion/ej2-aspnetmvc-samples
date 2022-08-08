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
        public ActionResult ShowHide()
        {
            ViewBag.DataSource = GanttData.ProjectNewData();
            List<object> ColumnNames = new List<object>();
            ColumnNames.Add(new { text = "ID", value = "TaskId" });
            ColumnNames.Add(new { text = "Start Date", value = "StartDate" });
            ColumnNames.Add(new { text = "End Date", value = "EndDate" });
            ColumnNames.Add(new { text = "Duration", value = "Duration" });
            ColumnNames.Add(new { text = "Progress", value = "Progress" });
            ColumnNames.Add(new { text = "Dependency", value = "Predecessor" });
            ViewBag.columns = ColumnNames;
            return View();
        }
    }
}