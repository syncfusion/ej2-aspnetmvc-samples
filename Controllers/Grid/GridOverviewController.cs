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

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        // GET: GridOverview
        public ActionResult GridOverview()
        {
            List<object> DataRange = new List<object>();
            DataRange.Add(new { Text = "1,000 Rows 11 Columns", Value= "1000"});
            DataRange.Add(new { Text = "10,000 Rows 11 Columns" , Value= "10000"});
            DataRange.Add(new { Text = "1,00,000 Rows 11 Columns", Value = "100000" });
            ViewData["Data"] = DataRange;
            return View();
        }
    }
}