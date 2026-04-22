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

        public ActionResult CustomSorting()
        {
            ViewData["data"] = new PivotTableData().GetPivot_Data();
            ViewData["drilledMembers"] = new string[] { "Germany" };
            ViewData["sortSettings"] = new string[] { "France", "United States" };
            ViewData["sortSettings_1"] = new string[] { "FY 2018", "FY 2017" };
            ViewData["sortSettings_2"] = new string[] { "Gloves", "Bottles and Cages" };
            ViewData["customSortingOrder"] = new string[] { "Ascending", "Descending" };
            ViewData["customSortingFields"] = GetCustomSortingFields();
            ViewData["customSortingData"] = new string[] { };
            return View();
        }
        public List<CustomSortingFields> GetCustomSortingFields()
        {
            List<CustomSortingFields> customSortingFields = new List<CustomSortingFields>();
            customSortingFields.Add(new CustomSortingFields { Field = "Country", Order = "Country_asc", caption = "Country" });
            customSortingFields.Add(new CustomSortingFields { Field = "Products", Order = "Products_desc", caption = "Products" });
            customSortingFields.Add(new CustomSortingFields { Field = "Year", Order = "Year_desc", caption = "Year" });
            customSortingFields.Add(new CustomSortingFields { Field = "Order_Source", Order = "Order_Source_asc", caption = "Order Source" });
            return customSortingFields;
        }
        public class CustomSortingFields
        {
            public string Field { get; set; }
            public string Order { get; set; }
            public string caption { get; set; }
        }
    }
}
