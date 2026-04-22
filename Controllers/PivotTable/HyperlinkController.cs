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

        public ActionResult Hyperlink()
        {
            ViewData["data"] = new PivotTableData().GetPivot_Data();
            ViewData["drilledMembers"] = new string[] { "France", "Germany" };
            ViewData["hyperLinkOptions"] = GetOptions();
            ViewData["hyperLinkMeasures"] = GetMeasures();
            ViewData["hyperLinkConditions"] = new string[] { "Equals", "NotEquals", "GreaterThan", "GreaterThanOrEqualTo",
            "LessThan", "LessThanOrEqualTo", "Between", "NotBetween" };
            return View();
        }
        public List<HyperLinkData> GetOptions()
        {
            List<HyperLinkData> hyperOptions = new List<HyperLinkData>();
            hyperOptions.Add(new HyperLinkData { value = "allcells", text = "All cells" });
            hyperOptions.Add(new HyperLinkData { value = "rowheader", text = "Row headers" });
            hyperOptions.Add(new HyperLinkData { value = "columnheader", text = "Column headers" });
            hyperOptions.Add(new HyperLinkData { value = "valuecells", text = "Value cells" });
            hyperOptions.Add(new HyperLinkData { value = "summarycells", text = "Summary cells" });
            hyperOptions.Add(new HyperLinkData { value = "conditional", text = "Condition based option" });
            hyperOptions.Add(new HyperLinkData { value = "headertext", text = "Header based option" });
            return hyperOptions;
        }
        public List<HyperLinkData> GetMeasures()
        {
            List<HyperLinkData> hyperMeasures = new List<HyperLinkData>();
            hyperMeasures.Add(new HyperLinkData { value = "In_Stock", text = "In Stock" });
            hyperMeasures.Add(new HyperLinkData { value = "Sold", text = "Units Sold" });
            hyperMeasures.Add(new HyperLinkData { value = "Amount", text = "Sold Amount" });
            return hyperMeasures;
        }
        public class HyperLinkData
        {
            public string value { get; set; }
            public string text { get; set; }
        }
    }
}
