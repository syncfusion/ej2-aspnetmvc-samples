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
        // GET: TooltipTemplate
        public ActionResult TooltipTemplate()
        {
            List<TooltipTemplateData> chartData = new List<TooltipTemplateData>
            {
                new TooltipTemplateData { xValue = "2002", yValue = 1.16 },
                new TooltipTemplateData { xValue = "2003", yValue = 2.34 },
                new TooltipTemplateData { xValue = "2004", yValue = 2.16 },
                new TooltipTemplateData { xValue = "2005", yValue = 2.10 },
                new TooltipTemplateData { xValue = "2006", yValue = 1.81 },
                new TooltipTemplateData { xValue = "2007", yValue = 2.05 },
                new TooltipTemplateData { xValue = "2008", yValue = 2.50 },
                new TooltipTemplateData { xValue = "2009", yValue = 2.22 },
                new TooltipTemplateData { xValue = "2010", yValue = 2.21 },
                new TooltipTemplateData { xValue = "2011", yValue = 2.00 },
                new TooltipTemplateData { xValue = "2012", yValue = 2.27 },
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class TooltipTemplateData
        {
            public string xValue;
            public double yValue;
        }
    }
}