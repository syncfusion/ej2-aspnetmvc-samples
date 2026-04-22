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
        public ActionResult Template()
        {
            List<TimelineItem> customData = new List<TimelineItem>();
            customData.Add(new TimelineItem { Content = "Created 10 commits in 5 repositories", DotCss = "sf-icon-commit" });
            customData.Add(new TimelineItem { Content = "Created 1 repository", DotCss = "sf-icon-create" });
            customData.Add(new TimelineItem { Content = "Created a pull request in <u>syncfusion/new-control-roadmap</u>", DotCss = "sf-icon-pull" });
            customData.Add(new TimelineItem { Content = "Reviewed 3 pull requests in 2 repositories", DotCss = "sf-icon-review" });
            ViewData["CustomData"] = customData;

            return View();
        }
    }
}