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
using Syncfusion.EJ2.PivotView;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.PivotView
{
    public partial class PivotTableController : Controller
    {
        public ActionResult DynamicBinding()
        {
            // Provide default relational data. Users can switch to CSV/remote/OLAP at runtime from the UI.
            ViewData["data"] = new PivotTableData().GetPivot_Data();
            // Initial drilled members (used by the view)
            ViewData["drilledMembers"] = new string[] { "France" };
            // Default toolbar items used by the view
            ViewData["toolbarItems"] = new string[] { "Grid", "Chart", "Export", "SubTotal", "GrandTotal", "Formatting", "FieldList" };
            return View();
        }
    }
}
