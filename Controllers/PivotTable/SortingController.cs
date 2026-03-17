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

        public ActionResult Sorting()
        {
            ViewData["data"] = new PivotTableData().GetPivot_Data();
            ViewData["fieldsData"] = GetFieldsData();
            ViewData["orderData"] = new string[] { "Ascending", "Descending" }; ;
            return View();
        }
        public List<SortData> GetFieldsData()
        {
            List<SortData> fieldsData = new List<SortData>();
            fieldsData.Add(new SortData { Field = "Country", Order = "Country_asc" });
            fieldsData.Add(new SortData { Field = "Products", Order = "Products_asc" });
            fieldsData.Add(new SortData { Field = "Year", Order = "Year_asc" });
            fieldsData.Add(new SortData { Field = "Order Source", Order = "Order Source_asc" });
            return fieldsData;
        }
        public class SortData
        {
            public string Field { get; set; }
            public string Order { get; set; }
        }
    }
}
