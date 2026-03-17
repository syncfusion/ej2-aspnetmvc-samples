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

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class DashboardLayoutController : Controller
    {
        // GET: PredefinedLayouts
        public ActionResult PredefinedLayouts()
        {
            spacingModel modelValue = new spacingModel();
            modelValue.cellSpacing = new double[] { 5, 5 };
            return View(modelValue);
        }
    }
}