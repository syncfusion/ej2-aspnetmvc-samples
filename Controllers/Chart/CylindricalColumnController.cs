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
        // GET: CylindricalColumn
        public ActionResult CylindricalColumn()
        {
            List<CylindricalColumnChartData> ChartPoints = new List<CylindricalColumnChartData>
            {
                new CylindricalColumnChartData { Year = "2017 - 18", Energy = 228.0 },
                new CylindricalColumnChartData { Year = "2018 - 19", Energy = 261.8 },
                new CylindricalColumnChartData { Year = "2019 - 20", Energy = 294.3 },
                new CylindricalColumnChartData { Year = "2020 - 21", Energy = 297.5 },
                new CylindricalColumnChartData { Year = "2021 - 22", Energy = 322.6 },
                new CylindricalColumnChartData { Year = "2022 - 23", Energy = 365.59 },
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class CylindricalColumnChartData
        {
            public string Year;
            public double Energy;
        }
    }
}