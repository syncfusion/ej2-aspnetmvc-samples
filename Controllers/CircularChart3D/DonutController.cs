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
        // GET: Donut
        public ActionResult Donut()
        {
            List<DonutCircularData> ChartPoints = new List<DonutCircularData>
            {
                new DonutCircularData { X = "Tesla",   Y = 137429 },
                new DonutCircularData { X = "Aion",    Y = 80308 },
                new DonutCircularData { X = "Wuling",  Y = 76418 },
                new DonutCircularData { X = "Changan", Y = 52849 },
                new DonutCircularData { X = "Geely",   Y = 47234 },
                new DonutCircularData { X = "Nio",     Y = 31041 },
                new DonutCircularData { X = "Neta",    Y = 22449 },
                new DonutCircularData { X = "BMW",     Y = 18733 }
            };
            ViewData["ChartData"] = ChartPoints;
            return View();
        }
        public class DonutCircularData
        {
            public string X;
            public double Y;
        }
    }
}