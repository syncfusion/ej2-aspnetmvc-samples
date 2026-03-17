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
        // GET: Pyramid
        public ActionResult Pyramid()
        {
            List<PyramidChartData> ChartPoints = new List<PyramidChartData>
            {
                new PyramidChartData { Foods = "Oils",        Calories = 2,  DataLabelMappingName = "Oils: 2%" },
                new PyramidChartData { Foods = "Protein",     Calories = 10, DataLabelMappingName = "Protein: 10%" },
                new PyramidChartData { Foods = "Fruits",      Calories = 15, DataLabelMappingName = "Fruits: 15%" },
                new PyramidChartData { Foods = "Dairy",       Calories = 23, DataLabelMappingName = "Dairy: 23%" },
                new PyramidChartData { Foods = "Vegetables",  Calories = 23, DataLabelMappingName = "Vegetables: 23%" },
                new PyramidChartData { Foods = "Grains",      Calories = 27, DataLabelMappingName = "Grains: 27%" }
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class PyramidChartData
        {
            public string Foods;
            public double Calories;
            public string DataLabelMappingName;
        }
    }
}