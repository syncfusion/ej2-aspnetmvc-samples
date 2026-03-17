#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult AdaptiveGrouping()
        {
            ScheduleData data = new ScheduleData();
            List<ScheduleData.ResourceData> resourceData = data.GetResourceData();
            List<ScheduleData.ResourceData> timelineResourceData = data.GetTimelineResourceData();
            ViewData["datasource"] = resourceData.Concat(timelineResourceData);

            List<ResourceDataSourceModel> projects = new List<ResourceDataSourceModel>();
            projects.Add(new ResourceDataSourceModel { text = "PROJECT 1", id = 1, color = "#cb6bb2" });
            projects.Add(new ResourceDataSourceModel { text = "PROJECT 2", id = 2, color = "#56ca85" });
            projects.Add(new ResourceDataSourceModel { text = "PROJECT 3", id = 3, color = "#df5286" });
            ViewData["Projects"] = projects;

            List<ResourceDataSourceModel> categories = new List<ResourceDataSourceModel>();
            categories.Add(new ResourceDataSourceModel { text = "Nancy", id = 1, groupId = 1, color = "#df5286" });
            categories.Add(new ResourceDataSourceModel { text = "Steven", id = 2, groupId = 1, color = "#7fa900" });
            categories.Add(new ResourceDataSourceModel { text = "Robert", id = 3, groupId = 2, color = "#ea7a57" });
            categories.Add(new ResourceDataSourceModel { text = "Smith", id = 4, groupId = 2, color = "#5978ee" });
            categories.Add(new ResourceDataSourceModel { text = "Michael", id = 5, groupId = 3, color = "#df5286" });
            categories.Add(new ResourceDataSourceModel { text = "Root", id = 6, groupId = 3, color = "#00bdae" });
            ViewData["Categories"] = categories;

            ViewData["Resources"] = new string[] { "Projects", "Categories" };
            return View();
        }
    }
}