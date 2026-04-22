#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Schedule;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult GroupEditing()
        {
            ViewData["datasource"] = new ScheduleData().GetResourceConferenceData();
            var monthEventTemplate = "<div class='subject'>${Subject}</div>";
            List<ScheduleView> viewOption = new List<ScheduleView>()
            {
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Day },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Week },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.WorkWeek },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Month, EventTemplate = monthEventTemplate},
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.TimelineWeek }
            };
            ViewData["view"] = viewOption;

            List<ResourceDataSourceModel> conferences = new List<ResourceDataSourceModel>();
            conferences.Add(new ResourceDataSourceModel { text = "Margaret", id = 1, color = "#1aaa55" });
            conferences.Add(new ResourceDataSourceModel { text = "Robert", id = 2, color = "#357cd2" });
            conferences.Add(new ResourceDataSourceModel { text = "Laura", id = 3, color = "#7fa900" });
            ViewData["Conferences"] = conferences;

            string[] resources = new string[] { "Conferences" };
            ViewData["Resources"] = resources;
            return View();
        }
    }
}