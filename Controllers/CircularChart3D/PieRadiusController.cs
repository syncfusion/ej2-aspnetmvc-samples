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
        // GET: PieRadius
        public ActionResult PieRadius()
        {
            List<PieRadiusData> ChartPoints = new List<PieRadiusData>
            {
                new PieRadiusData { X = "Argentina",          Y = 505370, R = "100",    Text = "Argentina" },
                new PieRadiusData { X = "Belgium",            Y = 551500, R = "118.7",  Text = "Belgium" },
                new PieRadiusData { X = "Dominican Republic", Y = 312685, R = "137.5",  Text = "Dominican Republic" },
                new PieRadiusData { X = "Cuba",               Y = 350000, R = "124.6",  Text = "Cuba" },
                new PieRadiusData { X = "Egypt",              Y = 301000, R = "150.8",  Text = "Egypt" },
                new PieRadiusData { X = "Kazakhstan",         Y = 300000, R = "155.5",  Text = "Kazakhstan" },
                new PieRadiusData { X = "Somalia",            Y = 357022, R = "160.6",  Text = "Somalia" }
            };
            ViewData["ChartData"] = ChartPoints;
            return View();
        }
        public class PieRadiusData
        {
            public string X;
            public double Y;
            public string R;
            public string Text;
        }
    }
}