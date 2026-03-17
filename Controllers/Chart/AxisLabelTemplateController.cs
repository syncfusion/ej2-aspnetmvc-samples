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
        // GET: AxisLabelTemplate
        public ActionResult AxisLabelTemplate()
        {
            // Build C# lists matching your CountryGame model
            var olympicsGoldData = new List<CountryGame>
            {
                new CountryGame { Country = "USA",            Count = 40 },
                new CountryGame { Country = "China",          Count = 40 },
                new CountryGame { Country = "Great Britain",  Count = 14 },
                new CountryGame { Country = "France",         Count = 16 },
                new CountryGame { Country = "Australia",      Count = 18 },
                new CountryGame { Country = "Japan",          Count = 20 },
                new CountryGame { Country = "Italy",          Count = 12 },
                new CountryGame { Country = "Netherlands",    Count = 15 },
                new CountryGame { Country = "Germany",        Count = 12 },
                new CountryGame { Country = "South Korea",    Count = 13 }
            };

            var olympicsSilverData = new List<CountryGame>
            {
                new CountryGame { Country = "USA",            Count = 44 },
                new CountryGame { Country = "China",          Count = 27 },
                new CountryGame { Country = "Great Britain",  Count = 22 },
                new CountryGame { Country = "France",         Count = 26 },
                new CountryGame { Country = "Australia",      Count = 19 },
                new CountryGame { Country = "Japan",          Count = 12 },
                new CountryGame { Country = "Italy",          Count = 13 },
                new CountryGame { Country = "Netherlands",    Count = 7 },
                new CountryGame { Country = "Germany",        Count = 13 },
                new CountryGame { Country = "South Korea",    Count = 9 }
            };

            var olympicsBronzeData = new List<CountryGame>
            {
                new CountryGame { Country = "USA",            Count = 42 },
                new CountryGame { Country = "China",          Count = 24 },
                new CountryGame { Country = "Great Britain",  Count = 29 },
                new CountryGame { Country = "France",         Count = 22 },
                new CountryGame { Country = "Australia",      Count = 16 },
                new CountryGame { Country = "Japan",          Count = 13 },
                new CountryGame { Country = "Italy",          Count = 15 },
                new CountryGame { Country = "Netherlands",    Count = 12 },
                new CountryGame { Country = "Germany",        Count = 8 },
                new CountryGame { Country = "South Korea",    Count = 10 }
            };

            // Pass to the view (optional)
            ViewBag.OlympicsGoldData = olympicsGoldData;
            ViewBag.OlympicsSilverData = olympicsSilverData;
            ViewBag.OlympicsBronzeData = olympicsBronzeData;

            return View();
        }

        public class CountryGame
        {
            public string Country { get; set; }
            public double Count { get; set; }
        }
    }
}