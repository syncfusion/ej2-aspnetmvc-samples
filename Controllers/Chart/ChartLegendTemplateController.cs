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
        // GET: ChartLegendTemplate
        public ActionResult ChartLegendTemplate()
        {
            List<MedalData> medalData = new List<MedalData>
            {
                new MedalData { Country = "Argentina", Gold = 22, Silver = 27, Bronze = 31 },
                new MedalData { Country = "Austria",   Gold = 22, Silver = 35, Bronze = 44 },
                new MedalData { Country = "Ethiopia",  Gold = 24, Silver = 16, Bronze = 22 },
                new MedalData { Country = "Iran",      Gold = 27, Silver = 29, Bronze = 32 },
                new MedalData { Country = "India",     Gold = 10, Silver = 10, Bronze = 21 }
            };

            ViewData["MedalData"] = medalData;

            return View();
        }

        public class MedalData
        {
            public string Country { get; set; }
            public int Gold { get; set; }
            public int Silver { get; set; }
            public int Bronze { get; set; }
        }
    }
}