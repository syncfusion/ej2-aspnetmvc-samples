#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
        // GET: PieWithLegend
        public ActionResult PieWithLegend()
        {
            List<PieWithLegendChartData> PieChartPoints = new List<PieWithLegendChartData>
            {                
                new PieWithLegendChartData { ExpenseCategory =  "Chrome", ExpensePercentage = 57.28, legendName="Chrome", DataLabelMappingName = "57.28%" },
                new PieWithLegendChartData { ExpenseCategory =  "UC Browser", ExpensePercentage = 4.37, legendName="UC Browser", DataLabelMappingName = "4.37%" },
                new PieWithLegendChartData { ExpenseCategory =  "Internet Explorer", ExpensePercentage = 6.12, legendName="Internet <br> Explorer", DataLabelMappingName = "6.12%" },
                new PieWithLegendChartData { ExpenseCategory =  "QQ", ExpensePercentage = 5.96, legendName="QQ", DataLabelMappingName = "5.96%" },
                new PieWithLegendChartData { ExpenseCategory =  "Edge", ExpensePercentage = 7.48, legendName="Edge", DataLabelMappingName = "7.48%" },
                new PieWithLegendChartData { ExpenseCategory =  "Others", ExpensePercentage = 14.06, legendName="Others", DataLabelMappingName = "18.76%" }
            };
            ViewData["PieChartPoints"] = PieChartPoints;
            return View();
        }
        public class PieWithLegendChartData
        {
            public string ExpenseCategory;
            public double ExpensePercentage;
            public string legendName; 
            public string DataLabelMappingName;
        }
    }
}