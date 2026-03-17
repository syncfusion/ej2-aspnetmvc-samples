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
        // GET: MultipleDrag
        public ActionResult MultipleDrag()
        {
            ScheduleData data = new ScheduleData();
            List<ScheduleData.ResourceData> resourceData = data.GetResourceData();
            List<ScheduleData.ResourceData> timelineResourceData = data.GetTimelineResourceData();
            ViewData["datasource"] = resourceData.Concat(timelineResourceData);

            List<ResourceDataSourceModel> ownerData = new List<ResourceDataSourceModel>();
            ownerData.Add(new ResourceDataSourceModel { text = "Nancy", id = 1, color = "#df5286" });
            ownerData.Add(new ResourceDataSourceModel { text = "Steven", id = 2, color = "#7fa900" });
            ownerData.Add(new ResourceDataSourceModel { text = "Robert", id = 3, color = "#ea7a57" });
            ownerData.Add(new ResourceDataSourceModel { text = "Smith", id = 4, color = "#5978ee" });
            ownerData.Add(new ResourceDataSourceModel { text = "Michael", id = 5, color = "#df5286" });
            ViewData["Owners"] = ownerData;

            ViewData["Resources"] = new string[] { "Owners" };
            return View();
        }
    }
}