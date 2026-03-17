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
        // GET: IndexedCategoryAxis
        public ActionResult IndexedCategoryAxis()
        {
            List<IndexedCategoryData> GDP_2015 = new List<IndexedCategoryData>
            {
                new IndexedCategoryData { Country = "India", GDPGrowthRate = 7.9 },
                new IndexedCategoryData { Country = "Myanmar", GDPGrowthRate = 7.3 },
                new IndexedCategoryData { Country = "Bangladesh", GDPGrowthRate = 6.0 },
                new IndexedCategoryData { Country = "Cambodia", GDPGrowthRate = 7.0 },
                new IndexedCategoryData { Country = "China", GDPGrowthRate = 6.9 },
             };
            ViewData["GDP_2015"] = GDP_2015;
            List<IndexedCategoryData> GDP_2016 = new List<IndexedCategoryData>
            {
                new IndexedCategoryData { Country = "Australia", GDPGrowthRate = 2.5 },
                new IndexedCategoryData { Country = "Poland", GDPGrowthRate = 2.7 },
                new IndexedCategoryData { Country = "Singapore", GDPGrowthRate = 2.0 },
                new IndexedCategoryData { Country = "Canada", GDPGrowthRate = 1.4 },
                new IndexedCategoryData { Country = "Germany", GDPGrowthRate = 1.8 },
             };
            ViewData["GDP_2016"] = GDP_2016;
            return View();
        }
        public class IndexedCategoryData
        {
            public string Country;
            public double GDPGrowthRate;
        }
    }
}