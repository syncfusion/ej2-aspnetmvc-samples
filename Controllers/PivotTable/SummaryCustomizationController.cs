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

        public ActionResult SummaryCustomization()
        {
            ViewData["data"] = new PivotTableData().GetPivot_Data();
            ViewData["drilledMembers"] = new string[] { "France", "Germany" };
            ViewData["filterMembers"] = new string[] { "Gloves", "Helmets", "Shorts", "Vests" };
            ViewData["summaryOption"] = GetSummaryOption();
            ViewData["summaryFields"] = GetSummaryFields();
            return View();
        }
        public List<SummaryOption> GetSummaryOption()
        {
            List<SummaryOption> summaryOption = new List<SummaryOption>();
            summaryOption.Add(new SummaryOption { value = "grandTotals", text = "Grand Totals" });
            summaryOption.Add(new SummaryOption { value = "subTotals", text = "Sub-totals" });
            return summaryOption;
        }
        public List<SummaryFields> GetSummaryFields()
        {
            List<SummaryFields> summaryFields = new List<SummaryFields>();
            summaryFields.Add(new SummaryFields { Name = "Country" });
            summaryFields.Add(new SummaryFields { Name = "Year" });
            return summaryFields;
        }
        public class SummaryOption
        {
            public string value { get; set; }
            public string text { get; set; }
        }
        public class SummaryFields
        {
            public string Name { get; set; }
        }
    }
}
