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
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: BackToBackColumn
        public ActionResult BackToBackColumn()
        {
            List<ColumnPlacementChartData> ChartPoints = new List<ColumnPlacementChartData>
            {
                new ColumnPlacementChartData { Country = "India", Population = 1450935791, Male = 748323427, Female = 702612364 },
                new ColumnPlacementChartData { Country = "China", Population = 1419321278, Male = 723023723, Female = 696297555 },
                new ColumnPlacementChartData { Country = "USA", Population = 345426571, Male = 173551527, Female = 171875044 },
                new ColumnPlacementChartData { Country = "Indonesia", Population = 283487931, Male = 142407931, Female = 141080014 },
                new ColumnPlacementChartData { Country = "Pakistan", Population = 251269164, Male = 127433405, Female = 123835758 }
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class ColumnPlacementChartData
        {
            public string Country;
            public double Population;
            public double Male;
            public double Female;
            public double GrapesCount;
            public string DataLabelMappingName;
        }

        public class Label
        {
            public string size;
        }
    }
}