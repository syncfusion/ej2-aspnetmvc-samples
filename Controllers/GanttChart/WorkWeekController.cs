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
        public ActionResult WorkWeek()
        {
            ViewData["DataSource"] = GanttData.ProjectNewData();
            ViewData["Data"] = CheckList.Days();
            return View();
        }

        public class CheckList
        {
            public string id { get; set; }
            public string day { get; set; }

            public static List<CheckList> Days()
            {
                List<CheckList> Data = new List<CheckList>();
                Data.Add(new CheckList { id = "Sunday", day = "Sunday" });
                Data.Add(new CheckList { id = "Monday", day = "Monday" });
                Data.Add(new CheckList { id = "Tuesday", day = "Tuesday" });
                Data.Add(new CheckList { id = "Wednesday", day = "Wednesday" });
                Data.Add(new CheckList { id = "Thursday", day = "Thursday" });
                Data.Add(new CheckList { id = "Friday", day = "Friday" });
                Data.Add(new CheckList { id = "Saturday", day = "Saturday" });
                return Data;
            }
        }
    }
}