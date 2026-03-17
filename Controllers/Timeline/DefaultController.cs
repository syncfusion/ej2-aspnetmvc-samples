#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.EJ2.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Layouts;
namespace EJ2MVCSampleBrowser.Controllers.Timeline
{
    public partial class TimelineController : Controller
    {
        public ActionResult Default()
        {
            List<TimelineItem> customData = new List<TimelineItem>();
            customData.Add(new TimelineItem { Content = "Ordered \n 9:15 AM, January 1, 2024", DotCss = "state-success", CssClass = "completed" });
            customData.Add(new TimelineItem { Content = "Shipped \n 12:20 PM, January 4, 2024", DotCss = "state-success", CssClass = "completed" });
            customData.Add(new TimelineItem { Content = "Out for delivery \n 07:00 AM, January 8, 2024", DotCss = "state-progress", CssClass = "intermediate" });
            customData.Add(new TimelineItem { Content = "Delivered \n Estimated delivery by 09:20 AM" });
            ViewData["CustomData"] = customData;

            return View();
        }
    }
}