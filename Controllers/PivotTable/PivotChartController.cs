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

        public ActionResult PivotChart()
        {
            ViewData["data"] = new PivotTableData().GetPivot_Data();
            ViewData["chartTypes"] = GetChartTypes();
            return View();
        }
        public List<ChartData> GetChartTypes()
        {
            List<ChartData> chartData = new List<ChartData>();
            chartData.Add(new ChartData { Name = "Line", Value = "Line" });
            chartData.Add(new ChartData { Name = "Column", Value = "Column" });
            chartData.Add(new ChartData { Name = "Bar", Value = "Bar" });
            chartData.Add(new ChartData { Name = "Spline", Value = "Spline" });
            chartData.Add(new ChartData { Name = "Area", Value = "Area" });
            chartData.Add(new ChartData { Name = "SplineArea", Value = "SplineArea" });
            chartData.Add(new ChartData { Name = "StepLine", Value = "StepLine" });
            chartData.Add(new ChartData { Name = "StepArea", Value = "StepArea" });
            chartData.Add(new ChartData { Name = "StackingColumn", Value = "StackingColumn" });
            chartData.Add(new ChartData { Name = "StackingBar", Value = "StackingBar" });
            chartData.Add(new ChartData { Name = "StackingArea", Value = "StackingArea" });
            chartData.Add(new ChartData { Name = "StackingColumn100", Value = "StackingColumn100" });
            chartData.Add(new ChartData { Name = "StackingBar100", Value = "StackingBar100" });
            chartData.Add(new ChartData { Name = "StackingArea100", Value = "StackingArea100" });
            chartData.Add(new ChartData { Name = "Scatter", Value = "Scatter" });
            chartData.Add(new ChartData { Name = "Bubble", Value = "Bubble" });
            chartData.Add(new ChartData { Name = "Pareto", Value = "Pareto" });
            chartData.Add(new ChartData { Name = "Polar", Value = "Polar" });
            chartData.Add(new ChartData { Name = "Radar", Value = "Radar" });
            chartData.Add(new ChartData { Name = "Pie", Value = "Pie" });
            chartData.Add(new ChartData { Name = "Doughnut", Value = "Doughnut" });
            chartData.Add(new ChartData { Name = "Funnel", Value = "Funnel" });
            chartData.Add(new ChartData { Name = "Pyramid", Value = "Pyramid" });
            return chartData;
        }
        public class ChartData
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }  
    }
}
