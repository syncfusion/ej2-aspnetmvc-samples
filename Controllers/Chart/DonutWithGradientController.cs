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
        // GET: DonutWithGradient
        public ActionResult DonutWithGradient()
        {
            var seriesData = new List<DonutGradientData>
            {
                new DonutGradientData { Country = "Austria", Share = 38.03, DataLabelMappingName = "Austria: 38.03%" },
                new DonutGradientData { Country = "Belgium", Share = 33.7, DataLabelMappingName = "Belgium: 33.7%" },
                new DonutGradientData { Country = "Germany", Share = 31.27, DataLabelMappingName = "Germany: 31.27%" },
                new DonutGradientData { Country = "The Netherlands", Share = 29.71, DataLabelMappingName = "The Netherlands: 29.71%" },
                new DonutGradientData { Country = "Lithuania", Share = 27.72, DataLabelMappingName = "Lithuania: 27.72%" },
                new DonutGradientData { Country = "Czechia", Share = 27.37, DataLabelMappingName = "Czechia: 27.37%" },
                new DonutGradientData { Country = "Poland", Share = 22.1, DataLabelMappingName = "Poland: 22.1%" },
                new DonutGradientData { Country = "Ireland", Share = 18.87, DataLabelMappingName = "Ireland: 18.87%" },
                new DonutGradientData { Country = "Croatia", Share = 14.88, DataLabelMappingName = "Croatia: 14.88%" }
            };

            ViewData["ChartPoints"] = seriesData;
            return View();
        }
    }

    public class DonutGradientData
    {
        public string Country { get; set; }
        public double Share { get; set; }
        public string DataLabelMappingName { get; set; }
    }
}