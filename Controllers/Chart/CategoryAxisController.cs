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
        // GET: CategoryAxis
        public ActionResult CategoryAxis()
        {
            List<CategoryData> ChartPoints = new List<CategoryData>
            {
                new CategoryData { Country = "Germany", Users = 72, TooltipMappingName = "GER: 72" },
                new CategoryData { Country = "Russia", Users = 103.1, TooltipMappingName = "RUS: 103.1" },
                new CategoryData { Country = "Brazil", Users = 139.1, TooltipMappingName = "BRZ: 139.1" },
                new CategoryData { Country = "India", Users = 462.1, TooltipMappingName = "IND: 462.1" },
                new CategoryData { Country = "China", Users = 721.4, TooltipMappingName = "CHN: 721.4" },
                new CategoryData { Country = "United States<br>Of America", Users = 286.9, TooltipMappingName = "USA: 286.9" },
                new CategoryData { Country = "Great Britain", Users = 115.1, TooltipMappingName = "GBR: 115.1" },
                new CategoryData { Country = "Nigeria", Users = 97.2, TooltipMappingName = "NGR: 97.2" }
             };
            ViewData["ChartPoints"] = ChartPoints;
            ViewData["font"] = new
            {
                fontWeight = "600",
                color = "#ffffff"
            };
            return View();


        }
        public class CategoryData
        {
            public string Country;
            public double Users;
            public string TooltipMappingName;
        }
    }
}