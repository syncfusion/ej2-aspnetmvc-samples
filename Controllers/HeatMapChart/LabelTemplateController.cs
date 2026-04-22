#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.HeatMapChart
{
    public partial class HeatMapChartController : Controller
    {
        // GET: LabelTemplate
        public ActionResult LabelTemplate()
        {
            ViewData["textStyle"] = new
            {
                size = "15px",
                fontWeight = "500",
                fontStyle = "Normal",
                fontFamily = "inherit"
            };
            ViewData["labelTextStyle"] = new
            {
                fontFamily = "inherit"
            };
            ViewData["xtitle"] = new { text = "LIKELIHOOD" };
            ViewData["ytitle"] = new { text = "IMPACT" };
            string[] xlabels = new string[5] { "Improbable", "Remote", "Occasional", "Probable", "Frequent" };
            ViewData["xLabels"] = xlabels;
            string[] yLabels = new string[5] { "Negligible", "Low", "Moderate", "Significant", "Catastrophic" };
            ViewData["yLabels"] = yLabels;
            ViewData["labelTemplateData"] = new HeatmapData().GetData();
            return View();
        }

        public class HeatmapData
        {
            public string RowId { get; set; }
            public string ColumnId { get; set; }
            public string Value { get; set; }
            public string Image { get; set; }

            public List<HeatmapData> GetData()
            {
                List<HeatmapData> data = new List<HeatmapData>();
                data.Add(new HeatmapData { RowId = "Improbable", ColumnId = "Negligible", Value = "2", Image = "../Content/HeatMapChart/green-cross.png" });
                data.Add(new HeatmapData { RowId = "Improbable", ColumnId = "Low", Value = "4", Image = "../Content/HeatMapChart/green-cross.png" });
                data.Add(new HeatmapData { RowId = "Improbable", ColumnId = "Moderate", Value = "6", Image = "../Content/HeatMapChart/green-cross.png" });
                data.Add(new HeatmapData { RowId = "Improbable", ColumnId = "Significant", Value = "8", Image = "../Content/HeatMapChart/green-cross.png" });
                data.Add(new HeatmapData { RowId = "Improbable", ColumnId = "Catastrophic", Value = "10", Image = "../Content/HeatMapChart/green-cross.png" });
                data.Add(new HeatmapData { RowId = "Remote", ColumnId = "Negligible", Value = "4", Image = "../Content/HeatMapChart/green-cross.png" });
                data.Add(new HeatmapData { RowId = "Remote", ColumnId = "Low", Value = "16", Image = "../Content/HeatMapChart/green-cross.png" });
                data.Add(new HeatmapData { RowId = "Remote", ColumnId = "Moderate", Value = "24", Image = "../Content/HeatMapChart/orange-tick.png" });
                data.Add(new HeatmapData { RowId = "Remote", ColumnId = "Significant", Value = "32", Image = "../Content/HeatMapChart/orange-tick.png" });
                data.Add(new HeatmapData { RowId = "Remote", ColumnId = "Catastrophic", Value = "40", Image = "../Content/HeatMapChart/orange-tick.png" });
                data.Add(new HeatmapData { RowId = "Occasional", ColumnId = "Negligible", Value = "6", Image = "../Content/HeatMapChart/green-cross.png" });
                data.Add(new HeatmapData { RowId = "Occasional", ColumnId = "Low", Value = "24", Image = "../Content/HeatMapChart/orange-tick.png" });
                data.Add(new HeatmapData { RowId = "Occasional", ColumnId = "Moderate", Value = "36", Image = "../Content/HeatMapChart/orange-tick.png" });
                data.Add(new HeatmapData { RowId = "Occasional", ColumnId = "Significant", Value = "48", Image = "../Content/HeatMapChart/red-tick.png" });
                data.Add(new HeatmapData { RowId = "Occasional", ColumnId = "Catastrophic", Value = "60", Image = "../Content/HeatMapChart/red-tick.png" });
                data.Add(new HeatmapData { RowId = "Probable", ColumnId = "Negligible", Value = "8", Image = "../Content/HeatMapChart/green-cross.png" });
                data.Add(new HeatmapData { RowId = "Probable", ColumnId = "Low", Value = "32", Image = "../Content/HeatMapChart/orange-tick.png" });
                data.Add(new HeatmapData { RowId = "Probable", ColumnId = "Moderate", Value = "48", Image = "../Content/HeatMapChart/red-tick.png" });
                data.Add(new HeatmapData { RowId = "Probable", ColumnId = "Significant", Value = "64", Image = "../Content/HeatMapChart/red-tick.png" });
                data.Add(new HeatmapData { RowId = "Probable", ColumnId = "Catastrophic", Value = "80", Image = "../Content/HeatMapChart/red-tick.png" });
                data.Add(new HeatmapData { RowId = "Frequent", ColumnId = "Negligible", Value = "10", Image = "../Content/HeatMapChart/green-cross.png" });
                data.Add(new HeatmapData { RowId = "Frequent", ColumnId = "Low", Value = "40", Image = "../Content/HeatMapChart/orange-tick.png" });
                data.Add(new HeatmapData { RowId = "Frequent", ColumnId = "Moderate", Value = "60", Image = "../Content/HeatMapChart/red-tick.png" });
                data.Add(new HeatmapData { RowId = "Frequent", ColumnId = "Significant", Value = "80", Image = "../Content/HeatMapChart/red-tick.png" });
                data.Add(new HeatmapData { RowId = "Frequent", ColumnId = "Catastrophic", Value = "100", Image = "../Content/HeatMapChart/red-tick.png" });
                return data;
            }
        }
    }
}