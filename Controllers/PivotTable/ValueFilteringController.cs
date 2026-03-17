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
        
        public ActionResult ValueFiltering()
        {
            ViewData["data"] = new PivotTableData().GetPivot_Data();
            ViewData["filterFields"] = new string[] { "Country", "Products", "Year" };
            ViewData["filterOperators"] = new string[] { "Equals", "DoesNotEquals", "GreaterThan", "GreaterThanOrEqualTo",
            "LessThan", "LessThanOrEqualTo", "Between", "NotBetween" };
            ViewData["filterMeasures"] = GetMeasuresData();
            return View();
        }
        public List<ValueFilterData> GetMeasuresData()
        {
			List<ValueFilterData> measuresData = new List<ValueFilterData>();
            measuresData.Add(new ValueFilterData { value = "In_Stock", text = "In Stock" });
            measuresData.Add(new ValueFilterData { value = "Sold", text = "Units Sold" });
            measuresData.Add(new ValueFilterData { value = "Amount", text = "Sold Amount" });
            return measuresData;
        }
        public class ValueFilterData
        {
            public string value { get; set; }
            public string text { get; set; }
        }        
    }
}
