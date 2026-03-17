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
using EJ2MVCSampleBrowser.Controllers.Schedule;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Gantt
{
    public partial class GanttChartController : Controller
    {
        // GET: Gantt
        public ActionResult WorkingTimeRange()
        {
            ViewData["DataSource"] = GanttData.ProjectNewData();
            ViewData["workWeek"] = DropDownData.GetDays();
            return View();
        }

        public class DropDownData
        {
            public string id { get; set; }
            public string day { get; set; }

            public static List<DropDownData> GetDays()
            {
                List<DropDownData> dayOfWeek = new List<DropDownData>();
                dayOfWeek.Add(new DropDownData { id = "Monday", day = "Monday" });
                dayOfWeek.Add(new DropDownData { id = "Tuesday", day = "Tuesday" });
                dayOfWeek.Add(new DropDownData { id = "Wednesday", day = "Wednesday" });
                dayOfWeek.Add(new DropDownData { id = "Thursday", day = "Thursday" });
                dayOfWeek.Add(new DropDownData { id = "Friday", day = "Friday" });
                return dayOfWeek;
            }
        }
    }
}