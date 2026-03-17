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

        public ActionResult DrillDown()
        {
            ViewData["data"] = new PivotTableData().GetPivot_Data();
            ViewData["drillDownOptions"] = GetDrillOptions();
            ViewData["drillDownFields"] = GetFields();
            ViewData["drillDownValues"] = new List<object>();
            return View();
        }
        public List<DrillDownOptions> GetDrillOptions()
        {
            List<DrillDownOptions> drillDownOptions = new List<DrillDownOptions>();
            drillDownOptions.Add(new DrillDownOptions { value = "allHeaders", text = "All headers" });
            drillDownOptions.Add(new DrillDownOptions { value = "rowHeaders", text = "Row headers" });
            drillDownOptions.Add(new DrillDownOptions { value = "columnHeader", text = "Column headers" });
            drillDownOptions.Add(new DrillDownOptions { value = "specificFields", text = "Specific fields" });
            drillDownOptions.Add(new DrillDownOptions { value = "specificHeaders", text = "Specific headers" });
            return drillDownOptions;
        }
        public List<DrillDownFields> GetFields()
        {
            List<DrillDownFields> drillDownFields = new List<DrillDownFields>();
            drillDownFields.Add(new DrillDownFields { Field = "Country", expandAll = false });
            drillDownFields.Add(new DrillDownFields { Field = "Year", expandAll = false });
            return drillDownFields;
        }
        public class DrillDownOptions
        {
            public string value { get; set; }
            public string text { get; set; }
        }
        public class DrillDownFields
        {
            public string Field { get; set; }
            public bool expandAll { get; set; }
        }
    }
}
