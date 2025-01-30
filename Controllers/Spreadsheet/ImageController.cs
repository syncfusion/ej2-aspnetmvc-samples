#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
using Syncfusion.EJ2.Spreadsheet;

namespace EJ2MVCSampleBrowser.Controllers.Spreadsheet
{
    public partial class SpreadsheetController : Controller
    {
        public ActionResult Image()
        {
            return View();
        }

        public ActionResult ImageOpen(OpenRequest openRequest)
        {
            return Content(Workbook.Open(openRequest));
        }

        public void ImageSave(SaveSettings saveSettings)
        {
            Workbook.Save(saveSettings);
        }
    }
}