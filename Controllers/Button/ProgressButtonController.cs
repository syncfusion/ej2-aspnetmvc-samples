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
using Syncfusion.EJ2.SplitButtons;

namespace EJ2MVCSampleBrowser.Controllers.Button
{
    public partial class ButtonController : Controller
    {
        public ActionResult ProgressButton()
        {
            ProgressButtonSpinSettings spinRight = new ProgressButtonSpinSettings() { Position = SpinPosition.Right };
            ProgressButtonSpinSettings spinTop = new ProgressButtonSpinSettings() { Position = SpinPosition.Top };
            ProgressButtonSpinSettings spinBottom = new ProgressButtonSpinSettings() { Position = SpinPosition.Bottom };
            ProgressButtonSpinSettings spinCenter = new ProgressButtonSpinSettings() { Position = SpinPosition.Center };

            ViewData["spinRight"] = spinRight;
            ViewData["spinTop"] = spinTop;
            ViewData["spinBottom"] = spinBottom;
            ViewData["spinCenter"] = spinCenter;

            ProgressButtonAnimationSettings slideLeft = new ProgressButtonAnimationSettings() { Effect = AnimationEffect.SlideLeft };
            ProgressButtonAnimationSettings slideRight = new ProgressButtonAnimationSettings() { Effect = AnimationEffect.SlideRight };
            ProgressButtonAnimationSettings zoomIn = new ProgressButtonAnimationSettings() { Effect = AnimationEffect.ZoomIn };
            ProgressButtonAnimationSettings zoomOut = new ProgressButtonAnimationSettings() { Effect = AnimationEffect.ZoomOut };

            ViewData["slideLeft"] = slideLeft;
            ViewData["slideRight"] = slideRight;
            ViewData["zoomIn"] = zoomIn;
            ViewData["zoomOut"] = zoomOut;
            return View();
        }
    }

}