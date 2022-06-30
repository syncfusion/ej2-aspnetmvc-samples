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
        // GET: BackToBackColumn
        public ActionResult BackToBackColumn()
        {
            List<BackToBackColumnData> chartData = new List<BackToBackColumnData>
            {
                new BackToBackColumnData { x= "Jamesh", yValue= 10, yValue1=5, yValue2=4, yValue3=1, text= "Total 10" },
                new BackToBackColumnData { x= "Michael", yValue= 9, yValue1=4, yValue2=3, yValue3=2, text= "Total 9" },
                new BackToBackColumnData { x= "John", yValue= 11, yValue1=5, yValue2=4, yValue3=2, text= "Total 11" }
            };
            ViewBag.dataSource = chartData;
            ViewBag.font = new { fontWeight = "600", color = "#ffffff" };
            return View();
        }
        public class BackToBackColumnData
        {
            public string x;
            public double yValue;
            public double yValue1;
            public double yValue2;
            public double yValue3;
            public string text;
        }

        public class Label
        {
            public string size;
        }
    }
}