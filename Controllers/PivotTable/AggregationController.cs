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

        public ActionResult Aggregation()
        {
            ViewData["data"] = new PivotTableData().GetrenewableEnergy();
            ViewData["drilledMembers"] = new string[] { "Biomass", "Free Energy" };
            ViewData["unitdrpdwnOptions"] = GetUnitData();
            ViewData["costdrpdwnOptions"] = GetCostData();
            return View();
        }
        public List<AggregationFields> GetUnitData()
        {
            List<AggregationFields> unitData = new List<AggregationFields>();
            unitData.Add(new AggregationFields { value = "Sum", text = "Sum" });
            unitData.Add(new AggregationFields { value = "Avg", text = "Average" });
            unitData.Add(new AggregationFields { value = "Median", text = "Median" });
            unitData.Add(new AggregationFields { value = "Min", text = "Min" });
            unitData.Add(new AggregationFields { value = "Max", text = "Max" });
            unitData.Add(new AggregationFields { value = "Count", text = "Count" });
            unitData.Add(new AggregationFields { value = "DistinctCount", text = "Distinct Count" });
            unitData.Add(new AggregationFields { value = "Product", text = "Product" });
            unitData.Add(new AggregationFields { value = "Index", text = "Index" });
            unitData.Add(new AggregationFields { value = "PopulationStDev", text = "Population StDev" });
            unitData.Add(new AggregationFields { value = "SampleStDev", text = "Sample StDev" });
            unitData.Add(new AggregationFields { value = "PopulationVar", text = "Population Var" });
            unitData.Add(new AggregationFields { value = "SampleVar", text = "Sample Var" });
            unitData.Add(new AggregationFields { value = "RunningTotals", text = "Running Totals" });
            unitData.Add(new AggregationFields { value = "DifferenceFrom", text = "Difference From" });
            unitData.Add(new AggregationFields { value = "PercentageOfDifferenceFrom", text = "% of Difference From" });
            unitData.Add(new AggregationFields { value = "PercentageOfGrandTotal", text = "% of Grand Total" });
            unitData.Add(new AggregationFields { value = "PercentageOfColumnTotal", text = "% of Column Total" });
            unitData.Add(new AggregationFields { value = "PercentageOfRowTotal", text = "% of Row Total" });
            unitData.Add(new AggregationFields { value = "PercentageOfParentTotal", text = "% of Parent Total" });
            unitData.Add(new AggregationFields { value = "PercentageOfParentColumnTotal", text = "% of Parent Column Total" });
            unitData.Add(new AggregationFields { value = "PercentageOfParentRowTotal", text = "% of Parent Row Total" });
            return unitData;
        }
        public List<AggregationFields> GetCostData()
        {
            List<AggregationFields> costData = new List<AggregationFields>();
            costData.Add(new AggregationFields { value = "Sum", text = "Sum" });
            costData.Add(new AggregationFields { value = "Avg", text = "Average" });
            costData.Add(new AggregationFields { value = "Median", text = "Median" });
            costData.Add(new AggregationFields { value = "Min", text = "Min" });
            costData.Add(new AggregationFields { value = "Max", text = "Max" });
            costData.Add(new AggregationFields { value = "Product", text = "Product" });
            costData.Add(new AggregationFields { value = "Index", text = "Index" });
            costData.Add(new AggregationFields { value = "PopulationStDev", text = "Population StDev" });
            costData.Add(new AggregationFields { value = "SampleStDev", text = "Sample StDev" });
            costData.Add(new AggregationFields { value = "PopulationVar", text = "Population Var" });
            costData.Add(new AggregationFields { value = "SampleVar", text = "Sample Var" });
            costData.Add(new AggregationFields { value = "RunningTotals", text = "Running Totals" });
            costData.Add(new AggregationFields { value = "DifferenceFrom", text = "Difference From" });
            costData.Add(new AggregationFields { value = "PercentageOfDifferenceFrom", text = "% of Difference From" });
            costData.Add(new AggregationFields { value = "PercentageOfGrandTotal", text = "% of Grand Total" });
            costData.Add(new AggregationFields { value = "PercentageOfColumnTotal", text = "% of Column Total" });
            costData.Add(new AggregationFields { value = "PercentageOfRowTotal", text = "% of Row Total" });
            costData.Add(new AggregationFields { value = "PercentageOfParentTotal", text = "% of Parent Total" });
            costData.Add(new AggregationFields { value = "PercentageOfParentColumnTotal", text = "% of Parent Column Total" });
            costData.Add(new AggregationFields { value = "PercentageOfParentRowTotal", text = "% of Parent Row Total" });
            return costData;
        }
        public class AggregationFields
        {
            public string value { get; set; }
            public string text { get; set; }
        }
    }
}
