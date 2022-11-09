#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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
        // GET: Pyramid
        public ActionResult Pyramid()
        {
            List<PyramidData> data = new List<PyramidData>
            {
                  new PyramidData { x= "Sweet Treats", y= 120, text= "120 cal" },
                  new PyramidData { x= "Milk, Youghnut, Cheese", y= 435, text= "435 cal" },
                  new PyramidData { x= "Vegetables", y= 470, text= "470 cal" },
                  new PyramidData { x= "Meat, Poultry, Fish", y= 475, text= "475 cal" },
                  new PyramidData { x= "Fruits", y= 520, text= "520 cal" },
                  new PyramidData { x= "Bread, Rice, Pasta", y= 930, text= "930 cal" }
            };
            ViewBag.dataSource = data;
            return View();
        }
        public class PyramidData
        {
            public string x;
            public double y;
            public string text;
        }
    }
}