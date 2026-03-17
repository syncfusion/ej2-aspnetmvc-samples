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

namespace EJ2MVCSampleBrowser.Controllers.LinearGauge
{
    public partial class LinearGaugeController : Controller
    {
        public ActionResult PrintExport()
        {
            ViewData["format"] = new string[] { "JPEG", "PNG", "SVG", "PDF" };
            return View();
        }
    }
}