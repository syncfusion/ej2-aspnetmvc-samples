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
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class RangeSliderController : Controller
    {
        public ActionResult Formatting()
        {
            ViewData["currencyValue"] = new int[] { 20, 80 };
            ViewData["kilometerValue"] = new int[] { 1100, 1850 };
            ViewData["timeValue"] = new decimal[] { 1373697000000, 1373718600000 };
            return View();
        }
    }
}
