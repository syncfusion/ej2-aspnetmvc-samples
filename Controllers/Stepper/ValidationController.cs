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
using System.Web.UI.WebControls;
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Controllers.Stepper
{
    public partial class StepperController : Controller
    {
        public ActionResult Validation()
        {
            List<Step> stepperWithText = new List<Step>();
            stepperWithText.Add(new Step { IconCss = "sf-icon-survey-intro", Text = "Survey Introduction" });
            stepperWithText.Add(new Step { IconCss = "sf-icon-survey-feedback", Text = "Feedback" });
            stepperWithText.Add(new Step { IconCss = "sf-icon-survey-status", Text = "Status" });
            ViewData["StepperWithText"] = stepperWithText;
            return View();
        }
    }
}