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
        // GET: PieWithLegend
        public ActionResult PieWithLegend()
        {
            List<PieWithLegendCircularData> ChartPoints = new List<PieWithLegendCircularData>
            {
                new PieWithLegendCircularData { X = "Chrome",            Y = 62.92, Text = "62.92%" },
                new PieWithLegendCircularData { X = "Internet Explorer", Y = 6.12,  Text = "6.12%"  },
                new PieWithLegendCircularData { X = "Opera",             Y = 3.15,  Text = "3.15%"  },
                new PieWithLegendCircularData { X = "Edge",              Y = 5.5,   Text = "5.5%"   },
                new PieWithLegendCircularData { X = "Safari",            Y = 19.97, Text = "19.97%" },
                new PieWithLegendCircularData { X = "Others",            Y = 2.34,  Text = "2.34%"  }
            };
            ViewData["ChartData"] = ChartPoints;
            return View();
        }
        public class PieWithLegendCircularData
        {
            public string X;
            public double Y;
            public string Text;
        }
    }
}