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
        // GET: Default
        public ActionResult Default()
        {
            List<DefaultBulletData> bulletData1 = new List<DefaultBulletData>
            {
                new DefaultBulletData { value = 270, target = 250}     
            };
            List<DefaultBulletData> bulletData2 = new List<DefaultBulletData>
            {
                new DefaultBulletData { value = 23, target = 27}
            };
            List<DefaultBulletData> bulletData3 = new List<DefaultBulletData>
            {
                new DefaultBulletData { value = 350, target = 550}
            };
            List<DefaultBulletData> bulletData4 = new List<DefaultBulletData>
            {
                new DefaultBulletData { value = 1600, target = 2100}
            };
            List<DefaultBulletData> bulletData5 = new List<DefaultBulletData>
            {
                new DefaultBulletData { value = 4.9, target = 4}
            };
            ViewData["dataSource1"] = bulletData1;
            ViewData["dataSource2"] = bulletData2;
            ViewData["dataSource3"] = bulletData3;
            ViewData["dataSource4"] = bulletData4;
            ViewData["dataSource5"] = bulletData5;
            return View();
        }
        public class DefaultBulletData
        {           
            public double value;
            public double target;
        }
    }
}