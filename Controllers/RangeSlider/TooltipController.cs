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
        public ActionResult Tooltip()
        {
            ViewData["sliderValue"] = new int[] { 30, 70 };
            List<object> placement = new List<object>();
            placement.Add(new { text = "Before", id = "Before" });
            placement.Add(new { text = "After", id = "After" });
            ViewData["placement"] = placement;
            List<object> showon = new List<object>();
            showon.Add(new { text = "Auto", id = "Auto" });
            showon.Add(new { text = "Focus", id = "Focus" });
            showon.Add(new { text = "Hover", id = "Hover" });
            showon.Add(new { text = "Always", id = "Always" });
            ViewData["showon"] = showon;
            return View();
        }
    }
}
