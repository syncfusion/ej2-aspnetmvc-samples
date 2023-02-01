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
        // GET: IndexedCategoryAxis
        public ActionResult IndexedCategoryAxis()
        {
            List<IndexedCategoryData> chartData1 = new List<IndexedCategoryData>
            {
                new IndexedCategoryData { x = "Myanmar", y = 7.3 },
                new IndexedCategoryData { x = "India", y = 7.9 },
                new IndexedCategoryData { x = "Bangladesh", y = 6.0 },
                new IndexedCategoryData { x = "Cambodia", y = 7.0 },
                new IndexedCategoryData { x = "China", y = 6.9 },
             };
            ViewBag.dataSource1 = chartData1;
            List<IndexedCategoryData> chartData2 = new List<IndexedCategoryData>
            {
                new IndexedCategoryData { x = "Poland", y = 2.7 },
                new IndexedCategoryData { x = "Australia", y = 2.5 },
                new IndexedCategoryData { x = "Singapore", y = 2.0 },
                new IndexedCategoryData { x = "Canada", y = 1.4 },
                new IndexedCategoryData { x = "Germany", y = 1.8 },
             };
            ViewBag.dataSource2 = chartData2;
            return View();
        }
        public class IndexedCategoryData
        {
            public string x;
            public double y;
        }
    }
}