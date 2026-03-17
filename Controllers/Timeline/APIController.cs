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
        public ActionResult API()
        {
            List<object> orientationData = new List<object>();
            orientationData.Add(new { text = "Vertical", value = "vertical" });
            orientationData.Add(new { text = "Horizontal", value = "horizontal" });
            ViewData["OrientationData"] = orientationData;

            List<object> alignData = new List<object>();
            alignData.Add(new { text = "Before", value = "before" });
            alignData.Add(new { text = "After", value = "after" });
            alignData.Add(new { text = "Alternate", value = "alternate" });
            alignData.Add(new { text = "Alternate reverse", value = "alternatereverse" });
            ViewData["AlignData"] = alignData;

            return View();
        }
    }
}