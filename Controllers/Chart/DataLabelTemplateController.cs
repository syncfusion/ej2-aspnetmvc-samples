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
        // GET: DataLabelTemplate
        public ActionResult DataLabelTemplate()
        {
            List<TemplateData> data1 = new List<TemplateData>
            {
                new TemplateData { x= 2010, y= 1014 },
                new TemplateData { x= 2011, y= 1040 },
                new TemplateData { x= 2012, y= 1065 },
                new TemplateData { x= 2013, y= 1110 },
                new TemplateData { x= 2014, y= 1130 },
                new TemplateData { x= 2015, y= 1153 },
                new TemplateData { x= 2016, y= 1175 }
            };
            ViewBag.dataSource1 = data1;
            List<TemplateData> data2 = new List<TemplateData>
            {
                new TemplateData { x= 2010, y= 990 },
                new TemplateData { x= 2011, y= 1010 },
                new TemplateData { x= 2012, y= 1030 },
                new TemplateData { x= 2013, y= 1070 },
                new TemplateData { x= 2014, y= 1105 },
                new TemplateData { x= 2015, y= 1138 },
                new TemplateData { x= 2016, y= 1155 }
            };
            ViewBag.dataSource2 = data2;
            ViewBag.margin = new { Right = 30 };
            ViewBag.margin1 = new { Right = 15 };
            return View();
        }
        public class TemplateData
        {
            public double x;
            public double y;
        }
    }
}