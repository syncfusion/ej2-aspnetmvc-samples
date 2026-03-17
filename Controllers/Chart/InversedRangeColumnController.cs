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
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: InversedRangeColumn
        public ActionResult InversedRangeColumn()
        {
            List<InversedRangeColumnData> ChartPoints = new List<InversedRangeColumnData>
            {
                new InversedRangeColumnData { Country = "Solomon Islands", Low = 44, High = 134 },
                new InversedRangeColumnData { Country = "Tonga", Low = 52, High = 131 },
                new InversedRangeColumnData { Country = "Trinidad and Tobago", Low = 36, High = 151 },
                new InversedRangeColumnData { Country = "Samoa", Low = 49, High = 131 },
                new InversedRangeColumnData { Country = "Saint Lucia", Low = 39, High = 148 },
                new InversedRangeColumnData { Country = "Georgia", Low = 68, High = 122 },
                new InversedRangeColumnData { Country = "Peru", Low = 56, High = 141 },
                new InversedRangeColumnData { Country = "Grenada", Low = 41, High = 147 },
                new InversedRangeColumnData { Country = "Dominica", Low = 46, High = 143 },
                new InversedRangeColumnData { Country = "Ukraine", Low = 64, High = 148 },
                new InversedRangeColumnData { Country = "Colombia", Low = 64, High = 134 }
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class InversedRangeColumnData
        {
            public string Country;
            public double Low;
            public double High;
        }
    }
}