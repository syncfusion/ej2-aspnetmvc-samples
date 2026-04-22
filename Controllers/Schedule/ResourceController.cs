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
        public ActionResult Resource()
        {
            List<OwnerRes> ownerCollections = new List<OwnerRes>();
            ownerCollections.Add(new OwnerRes { OwnerText = "Margaret", OwnerId = 1, Color = "#ea7a57" });
            ownerCollections.Add(new OwnerRes { OwnerText = "Robert", OwnerId = 2, Color = "#df5286" });
            ownerCollections.Add(new OwnerRes { OwnerText = "Laura", OwnerId = 3, Color = "#865fcf" });
            ViewData["Owners"] = ownerCollections;

            ViewData["datasource"] = new ScheduleData().GetResourceSampleData();
            return View();
        }

        public class OwnerRes
        {
            public string OwnerText { set; get; }
            public int OwnerId { set; get; }
            public string Color { set; get; }
        }
    }
}