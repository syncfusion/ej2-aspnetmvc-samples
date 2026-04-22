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

namespace EJ2MVCSampleBrowser.Controllers.BulletChart
{
    public partial class BulletChartController : Controller
    {
        // GET: Custom
        public ActionResult Custom()
        {
            List<CustomBulletData> bulletData1 = new List<CustomBulletData>
            {
                new CustomBulletData { value = 1.7, target = 2.5}     
            };
           
            ViewData["dataSource"] = bulletData1;
            return View();
        }
        public class CustomBulletData
        {           
            public double value;
            public double target;
        }
    }
}