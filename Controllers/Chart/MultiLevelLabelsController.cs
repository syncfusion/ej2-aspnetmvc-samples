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
        // GET: MultiLevelLabels
        public ActionResult MultiLevelLabels()
        {
            List<MultiLevelLabelsData> chartData = new List<MultiLevelLabelsData>
            {
                new MultiLevelLabelsData { x = "Grapes",  y = 28 },
                new MultiLevelLabelsData { x = "Apples",  y = 87 },
                new MultiLevelLabelsData { x = "Pears",   y = 42 },
                new MultiLevelLabelsData { x = "Grapes",  y = 13 },
                new MultiLevelLabelsData { x = "Apples",  y = 13 },
                new MultiLevelLabelsData { x = "Pears",   y = 10 },
                new MultiLevelLabelsData { x = "Tomato",  y = 31 },
                new MultiLevelLabelsData { x = "Potato",  y = 96 },
                new MultiLevelLabelsData { x = "Cucumber",y = 41 },
                new MultiLevelLabelsData { x = "Onion",   y = 59 }
             };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class MultiLevelLabelsData
        {
            public string x;
            public double y;
        }
    }
}