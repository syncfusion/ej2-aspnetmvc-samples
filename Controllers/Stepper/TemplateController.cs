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
        public ActionResult Template()
        {
            List<Step> stepperTemplate = new List<Step>();
            stepperTemplate.Add(new Step { IconCss = "e-icons e-check", Text = "Step 1" });
            stepperTemplate.Add(new Step { IconCss = "e-icons e-check", Text = "Step 2" });
            stepperTemplate.Add(new Step { IconCss = "e-icons e-check", Text = "Step 3" });
            stepperTemplate.Add(new Step { IconCss = "e-icons e-check", Text = "Step 4" });
            ViewData["StepperTemplate"] = stepperTemplate;
            return View();
        }
    }
}