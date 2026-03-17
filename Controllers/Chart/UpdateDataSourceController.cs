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

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: UpdateDataSource
        public ActionResult UpdateDataSource()
        {
            List<UpdateChartData> ChartPoints = new List<UpdateChartData>
            {
                new UpdateChartData { X = "Jewellery",          Y = 75 },
                new UpdateChartData { X = "Shoes",              Y = 45 },
                new UpdateChartData { X = "Footwear",           Y = 73 },
                new UpdateChartData { X = "Pet Services",       Y = 53 },
                new UpdateChartData { X = "Business Clothing",  Y = 85 },
                new UpdateChartData { X = "Office Supplies",    Y = 68 },
                new UpdateChartData { X = "Food",               Y = 45 }
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class UpdateChartData
        {
            public string X;
            public double Y;
        }
    }
}