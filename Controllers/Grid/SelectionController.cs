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

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        // GET: Selection
        public ActionResult Selection()
        {
            var DataSource = EmployeeView.GetAllRecords();
            ViewData["dataSource"] = DataSource;
            ViewData["type"] = new string[] { "Single", "Multiple" };
            ViewData["mode"] = new string[] { "Row", "Cell", "Both" };
            return View();
        }
    }
}