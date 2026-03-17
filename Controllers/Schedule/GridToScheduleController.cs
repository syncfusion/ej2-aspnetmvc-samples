#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult GridToSchedule()
        {
            ScheduleData data = new ScheduleData();

            // Get resource data
            List<ScheduleData.ResourceData> resourceData = data.GetResourceData();
            List<ScheduleData.ResourceData> timelineResourceData = data.GetTimelineResourceData();

            // Combine resource data and set ViewData["datasource"]
            ViewData["datasource"] = resourceData.Concat(timelineResourceData).ToList();

            // Define New York office categories
            List<ResourceDataSourceModel> EmployeeData = new List<ResourceDataSourceModel>
            {
                new ResourceDataSourceModel { text = "Nancy", id = 1, color = "#df5286" },
                new ResourceDataSourceModel { text = "Steven", id = 2, color = "#7fa900" },
                new ResourceDataSourceModel { text = "Robert", id = 3, color = "#ea7a57" },
                new ResourceDataSourceModel { text = "Smith", id = 4, color = "#5978ee" },
                new ResourceDataSourceModel { text = "Michael", id = 5, color = "#f57b42" },
                new ResourceDataSourceModel { text = "Root", id = 6, color = "#1aaa55" },
                new ResourceDataSourceModel { text = "John", id = 7, color = "#ffb74d" },
                new ResourceDataSourceModel { text = "Chirish", id = 8, color = "#7460ee" },
                new ResourceDataSourceModel { text = "Megan", id = 9, color = "#c0ca33" }
            };

            // Example grid data
            var gridData = new List<object>
            {
                new { Task = "Test report validation", Duration = "3 Hours" },
                new { Task = "Timeline estimation", Duration = "4 Hours" },
                new { Task = "Workflow Analysis", Duration = "2 Hours" },
                new { Task = "Quality Analysis", Duration = "5 Hours" },
                new { Task = "Cross-browser testing", Duration = "1 Hour" },
                new { Task = "Resolution-based testing", Duration = "3 Hours" },
                new { Task = "Project Preview", Duration = "6 Hours" },
                new { Task = "Developers Meeting", Duration = "2 Hours" },
                new { Task = "Test case correction", Duration = "7 Hours" },
                new { Task = "Debugging", Duration = "4 Hours" },
                new { Task = "Exception handling", Duration = "5 Hours" },
                new { Task = "Bug fixing", Duration = "1 Hour" },
                new { Task = "Bug Automation", Duration = "3 Hours" },
                new { Task = "Bug fixing", Duration = "6 Hours" }
            };

            ViewData["EmployeeData"] = EmployeeData;
            ViewData["gridData"] = gridData;
            ViewData["Resources"] = new string[] { "Employees" };

            return View();
        }
    }
}