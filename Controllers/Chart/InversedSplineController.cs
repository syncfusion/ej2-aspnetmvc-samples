#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
        // GET: InversedSpline
        public ActionResult InversedSpline()
        {
            List<InversedLineChartData> ChartPoints = new List<InversedLineChartData>
            {
                new InversedLineChartData { Month = 2000, LDN_Temperature = -1, FR_Temperature = 10 },
                new InversedLineChartData { Month = 2002, LDN_Temperature = -1, FR_Temperature = 7 },
                new InversedLineChartData { Month = 2004, LDN_Temperature = 25, FR_Temperature = 13 },
                new InversedLineChartData { Month = 2005, LDN_Temperature = 31, FR_Temperature = 16 },
                new InversedLineChartData { Month = 2007, LDN_Temperature = 14, FR_Temperature = 11 },
                new InversedLineChartData { Month = 2010, LDN_Temperature = 8, FR_Temperature = 10 },
                new InversedLineChartData { Month = 2011, LDN_Temperature = 8, FR_Temperature = 15 },
                new InversedLineChartData { Month = 2013, LDN_Temperature = 8, FR_Temperature = 20 },
                new InversedLineChartData { Month = 2014, LDN_Temperature = 8, FR_Temperature = 17 },
                new InversedLineChartData { Month = 2015, LDN_Temperature = 8, FR_Temperature = 5 }
            };
            ViewBag.ChartPoints = ChartPoints;
            return View();
        }

        public class InversedLineChartData
        {
            public double Month ;
            public double LDN_Temperature ;
            public double FR_Temperature ;
        }
    }
}