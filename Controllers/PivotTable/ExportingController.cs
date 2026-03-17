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
using Syncfusion.EJ2.PivotView;
using EJ2MVCSampleBrowser.Models;


namespace EJ2MVCSampleBrowser.Controllers.PivotView
{
    public partial class PivotTableController : Controller
    {

        public ActionResult Exporting()
        {
            ViewData["data"] = new PivotTableData().GetPivot_Data();
            ViewData["YearFilterMembers"] = new string[] { "FY 2026" };
            ViewData["ProductsFilterMembers"] = new string[] { "Gloves", "Fenders" };
            ViewData["drilledMembers"] = new string[] { "France" };
            ViewData["exportMode"] = GetMode();
            return View();
        }
        public List<ExportMode> GetMode()
        {
            List<ExportMode> exportMode = new List<ExportMode>();
            exportMode.Add(new ExportMode { value = "excel", text = "Excel" });
            exportMode.Add(new ExportMode { value = "csv", text = "CSV" });
            exportMode.Add(new ExportMode { value = "pdf", text = "PDF" });
            return exportMode;
        }
        public class ExportMode
        {
            public string value { get; set; }
            public string text { get; set; }
        }
    }
}
