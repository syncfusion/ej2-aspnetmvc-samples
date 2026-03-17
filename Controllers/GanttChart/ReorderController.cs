#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
        public ActionResult Reorder()
        {
            ViewData["DataSource"] = GanttData.ProjectNewData();

            List<object> columnNames = new List<object>();
            columnNames.Add(new { text = "ID", value = "TaskId" });
            columnNames.Add(new { text = "Task Name", value = "TaskName" });
            columnNames.Add(new { text = "Start Date", value = "StartDate" });
            columnNames.Add(new { text = "End Date", value = "EndDate" });
            columnNames.Add(new { text = "Duration", value = "Duration" });
            columnNames.Add(new { text = "Dependency", value = "Predecessor" });
            columnNames.Add(new { text = "Progress", value = "Progress" });
            ViewData["columns"] = columnNames;

            List<object> ColumnsIindex = new List<object>();
            ColumnsIindex.Add(new { text = "1", value = "0" });
            ColumnsIindex.Add(new { text = "2", value = "1" });
            ColumnsIindex.Add(new { text = "3", value = "2" });
            ColumnsIindex.Add(new { text = "4", value = "3" });
            ColumnsIindex.Add(new { text = "5", value = "4" });
            ColumnsIindex.Add(new { text = "6", value = "5" });
            ColumnsIindex.Add(new { text = "7", value = "6" });
            ViewData["index"] = ColumnsIindex;
            return View();
        }
    }
}