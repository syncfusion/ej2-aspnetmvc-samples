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

        public ActionResult ExternalDataBasedFiltering()
        {
            ViewData["data"] = new PivotTableData().GetPivotFilterData();
            ViewData["startDate"] = new DateTime(2024, 01, 01);
            ViewData["endDate"] = new DateTime(2024, 12, 01);
            ViewData["format"] = "MMM yyyy";
            ViewData["start"] = "Year";
            ViewData["depth"] = "Year";
            ViewData["startMax"] = new DateTime(2024, 10, 31);
            ViewData["startMin"] = new DateTime(2019, 1, 1);
            ViewData["endMax"] = new DateTime(2024, 12, 31);
            ViewData["endMin"] = new DateTime(2019, 1, 1);
            ViewData["dataSource"] = new List<object>(); // Empty initial data
            ViewData["drilledMembers"] = new string[] { "Canada" };
            ViewData["groupMembers"] = new string[] { "Years", "Months" };
            return View();
        }
    }
}
