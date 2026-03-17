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
        public ActionResult GridLines()
        {
            ViewData["DataSource"] = GanttData.ProjectNewData();
            ViewData["Data"] = DropDownLists.GridLinesData();
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