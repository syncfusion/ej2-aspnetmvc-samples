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

namespace EJ2MVCSampleBrowser.Controllers.CircularChart3D
{
    public partial class CircularChart3DController : Controller
    {
        // GET: Pie
        public ActionResult Pie()
        {
            List<PieCircularData> ChartPoints = new List<PieCircularData>
            {
                new PieCircularData { X = "Canada",         Y = 46,  Text= "Canada: 46" },
                new PieCircularData { X = "Hungary",        Y = 30,  Text= "Hungary: 30" },
                new PieCircularData { X = "Germany",        Y = 79,  Text= "Germany: 79" },
                new PieCircularData { X = "Mexico",         Y = 13,  Text= "Mexico: 13" },
                new PieCircularData { X = "China",          Y = 56,  Text= "China: 56" },
                new PieCircularData { X = "India",          Y = 41,  Text= "India: 41" },
                new PieCircularData { X = "Bangladesh",     Y = 25,  Text= "Bangladesh: 25" },
                new PieCircularData { X = "United States",  Y = 32,  Text= "United States: 32" },
                new PieCircularData { X = "Belgium",        Y = 34,  Text= "Belgium: 34" }
            };
            ViewData["ChartData"] = ChartPoints;
            return View();
        }
        public class PieCircularData
        {
            public string X;
            public double Y;
            public string Text;
        }
    }
}