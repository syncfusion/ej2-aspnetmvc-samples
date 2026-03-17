#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.EJ2.Navigations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Controllers.Stepper
{
    public partial class StepperController : Controller
    {
        public ActionResult Linear()
        {       
            List<Step> linearStepper = new List<Step>();
            linearStepper.Add(new Step { IconCss = "sf-icon-form", Label = "Project Setup" });
            linearStepper.Add(new Step { IconCss = "sf-icon-tasksheet", Label = "Task Planning" });
            linearStepper.Add(new Step { IconCss = "sf-icon-progress", Label = "Progress Tracking" });
            linearStepper.Add(new Step { IconCss = "sf-icon-submit", Label = "Project Completion" });
            ViewData["LinearStepper"] = linearStepper;

            return View();
        }
    }
}