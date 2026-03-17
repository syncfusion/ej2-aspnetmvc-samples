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

namespace EJ2MVCSampleBrowser.Controllers.Sparkline
{
    public partial class SparklineController : Controller
    {
        // GET: Liveupdate
        public ActionResult Liveupdate()
        {
            ViewData["datasource"] = LiveData.GetData();
            return View();
        }

        public class LiveData
        {
            public double x, yval, yval1, yval2, yval3;

            public static List<LiveData> GetData()
            {
                List<LiveData> data = new List<LiveData>();
                data.Add(new LiveData() { x = 0,  yval = 50, yval1 = 6.05, yval2 = 50, yval3 = 50 });
                data.Add(new LiveData() { x = 1,  yval = 30, yval1 = 6.03, yval2 = 30, yval3 = 30 });
                data.Add(new LiveData() { x = 2,  yval = 20, yval1 = 6.02, yval2 = 20, yval3 = 20 });
                data.Add(new LiveData() { x = 3,  yval = 30, yval1 = 6.07, yval2 = 70, yval3 = 70 });
                data.Add(new LiveData() { x = 4,  yval = 50, yval1 = 6.05, yval2 = 50, yval3 = 50 });
                data.Add(new LiveData() { x = 5,  yval = 40, yval1 = 6.09, yval2 = 20, yval3 = 20 });
                data.Add(new LiveData() { x = 6,  yval = 20, yval1 = 6.08, yval2 = 80, yval3 = 80 });
                data.Add(new LiveData() { x = 7,  yval = 10, yval1 = 6.01, yval2 = 10, yval3 = 10 });
                data.Add(new LiveData() { x = 8,  yval = 30, yval1 = 6.03, yval2 = 30, yval3 = 30 });
                data.Add(new LiveData() { x = 9,  yval = 10, yval1 = 6.01, yval2 = 10, yval3 = 10 });
                data.Add(new LiveData() { x = 10, yval = 40, yval1 = 6.07, yval2 = 70, yval3 = 70 });
                data.Add(new LiveData() { x = 11, yval = 50, yval1 = 6.05, yval2 = 50, yval3 = 50 });
                data.Add(new LiveData() { x = 12, yval = 10, yval1 = 6.01, yval2 = 10, yval3 = 10 });
                data.Add(new LiveData() { x = 13, yval = 30, yval1 = 6.06, yval2 = 60, yval3 = 60 });
                data.Add(new LiveData() { x = 14, yval = 50, yval1 = 6.05, yval2 = 50, yval3 = 50 });
                data.Add(new LiveData() { x = 15, yval = 20, yval1 = 6.03, yval2 = 30, yval3 = 30 });
                data.Add(new LiveData() { x = 16, yval = 10, yval1 = 6.01, yval2 = 10, yval3 = 10 });
                data.Add(new LiveData() { x = 17, yval = 40, yval1 = 6.09, yval2 = 20, yval3 = 20 });
                data.Add(new LiveData() { x = 18, yval = 30, yval1 = 6.06, yval2 = 60, yval3 = 60 });
                data.Add(new LiveData() { x = 19, yval = 40, yval1 = 6.05, yval2 = 50, yval3 = 50 });
                return data;
            }
        }
    }
}