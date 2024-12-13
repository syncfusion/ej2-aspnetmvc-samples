#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.EJ2.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.OtpInput
{
    public partial class OtpInputController : Controller
    {
        public ActionResult API()
        {
            List<object> stylingMode = new List<object>();
            stylingMode.Add(new { text = "Outlined", value = "Outlined" });
            stylingMode.Add(new { text = "Underlined", value = "Underlined" });
            stylingMode.Add(new { text = "Filled", value = "Filled" });
            ViewBag.stylingMode = stylingMode;

            List<object> validationStatus = new List<object>();
            validationStatus.Add(new { text = "None", value = "" });
            validationStatus.Add(new { text = "Success", value = "e-success" });
            validationStatus.Add(new { text = "Warning", value = "e-warning" });
            validationStatus.Add(new { text = "Error", value = "e-error" });
            ViewBag.validationStatus = validationStatus;

            return View();
        }
    }
}