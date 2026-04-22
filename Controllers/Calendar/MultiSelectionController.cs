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
    public partial class CalendarController : Controller
    {
        // GET: MultiSelection
        public ActionResult MultiSelection()
        {
            var month = DateTime.Now.Month;
            var year = DateTime.Now.Year;
            ViewData["multiValue"] = new DateTime[] { new DateTime(year, month, 10), new DateTime(year, month, 15), new DateTime(year, month, 25) };
            return View();
        }
    }
}