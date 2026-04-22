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

namespace EJ2MVCSampleBrowser.Controllers.Toast
{
    public partial class ToastController : Controller
    {
        // GET: Types
        public ActionResult API()
        {
            List<object> easingData = new List<object>();
            easingData.Add(new { Id = "ease", Value = "Ease" });
            easingData.Add(new { Id = "linear", Value = "Linear" });
            ViewData["EasingData"] = easingData;
            List<object> directionData = new List<object>();
            directionData.Add(new { Id = "Rtl", Value = "Right to Left" });
            directionData.Add(new { Id = "Ltr", Value = "Left to Right" });
            ViewData["directionData"] = directionData;
            List<object> animationData = new List<object>();
            animationData.Add(new { Id = "SlideBottomIn", Value = "Slide Bottom In" });
            animationData.Add(new { Id = "FadeIn", Value = "Fade In" });
            animationData.Add(new { Id = "FadeZoomIn", Value = "Fade Zoom In" });
            animationData.Add(new { Id = "FadeZoomOut", Value = "Fade Zoom Out" });
            animationData.Add(new { Id = "FlipLeftDownIn", Value = "Flip Left Down In" });
            animationData.Add(new { Id = "FlipLeftDownOut", Value = "Flip Left Down Out" });
            animationData.Add(new { Id = "FlipLeftUpIn", Value = "Flip Left Up In" });
            animationData.Add(new { Id = "FlipLeftUpOut", Value = "Flip Left Up Out" });
            animationData.Add(new { Id = "FlipRightDownIn", Value = "Flip Right Down In" });
            animationData.Add(new { Id = "FlipRightDownOut", Value = "Flip Right Down Out" });
            animationData.Add(new { Id = "FlipRightUpIn", Value = "Flip Right Up In" });
            animationData.Add(new { Id = "FlipRightUpOut", Value = "Flip Right Up Out" });
            animationData.Add(new { Id = "SlideBottomOut", Value = "Slide Bottom Out" });
            animationData.Add(new { Id = "SlideLeftIn", Value = "Slide Left In" });
            animationData.Add(new { Id = "SlideLeftOut", Value = "Slide Left Out" });
            animationData.Add(new { Id = "SlideRightIn", Value = "Slide Right In" });
            animationData.Add(new { Id = "SlideRightOut", Value = "Slide Right Out" });
            animationData.Add(new { Id = "SlideTopIn", Value = "Slide Top In" });
            animationData.Add(new { Id = "SlideTopOut", Value = "Slide Top Out" });
            animationData.Add(new { Id = "ZoomIn", Value = "Zoom In" });
            animationData.Add(new { Id = "ZoomOut", Value = "Zoom Out" });
            ViewData["AnimationData"] = animationData;
            return View();
        }
    }
}