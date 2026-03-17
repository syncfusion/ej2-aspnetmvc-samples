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
        public ActionResult Ticks()
        {
            ViewData["sliderValue"] = new int[] { 30, 70 };
            List<object> data = new List<object>();
            data.Add(new { text = "Before", id = "Before" });
            data.Add(new { text = "After", id = "After" });
            data.Add(new { text = "Both", id = "Both" });
            data.Add(new { text = "None", id = "None" });
            ViewData["dataSource"] = data;
            return View();
        }
    }
}
