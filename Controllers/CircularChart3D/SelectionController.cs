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
        // GET: Selection
        public ActionResult Selection()
        {
            List<SelectionCircularData> ChartPoints = new List<SelectionCircularData>
            {
                new SelectionCircularData { X = "Chrome",             Y = 62.92 },
                new SelectionCircularData { X = "Internet Explorer",  Y = 6.12  },
                new SelectionCircularData { X = "Edge",               Y = 5.5   },
                new SelectionCircularData { X = "Opera",              Y = 3.15  },
                new SelectionCircularData { X = "Safari",             Y = 19.97 },
                new SelectionCircularData { X = "Others",             Y = 2.34  }
            };
            ViewData["ChartData"] = ChartPoints;
            return View();
        }
        public class SelectionCircularData
        {
            public string X;
            public double Y;
        }
    }
}