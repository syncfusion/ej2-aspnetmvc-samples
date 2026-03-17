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

namespace EJ2MVCSampleBrowser.Controllers.InPlaceEditor
{
    public partial class InPlaceEditorController : Controller
    {
        // GET: Pickers
        public ActionResult Pickers()
        {
            ViewData["ModeData"] = new string[] { "Inline", "Popup" };
            ViewData["DateData"] = new { placeholder = "Select a date" };
            ViewData["TimeData"] = new { placeholder = "Select a time" };
            ViewData["DateTimeData"] = new { placeholder = "Select a date and time" };
            ViewData["DateRangeData"] = new { placeholder = "Select a date range" };
            ViewData["DateRangeValue"] = new DateTime[2] { new DateTime(2017, 05, 23), new DateTime(2017, 07, 05) };
            ViewData["DateValue"] =new DateTime(2017, 05, 23);
            return View();
        }
    }
}
