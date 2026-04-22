#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult ViewBasedSettings()
        {
            // Datasource for events
            ViewData["datasource"] = new ScheduleData().GetFifaEventsData();

            //Datasource for Resources
            List<ResourceFields> Resources = new List<ResourceFields>();
            Resources.Add(new ResourceFields { GroupText = "Group A", GroupId = 1, GroupColor = "#1aaa55" });
            Resources.Add(new ResourceFields { GroupText = "Group B", GroupId = 2, GroupColor = "#357cd2" });
            ViewData["resourceData"] = Resources;

            return View();
        }
    }

    public class ResourceFields
    {
        public string GroupText { set; get; }
        public int GroupId { set; get; }
        public string GroupColor { set; get; }
    }
}