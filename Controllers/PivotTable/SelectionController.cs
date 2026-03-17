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

        public ActionResult Selection()
        {
            ViewData["data"] = new PivotTableData().GetPivot_Data();
            ViewData["modeData"] = GetModeData();
            ViewData["typeData"] = GetTypeData();
            return View();
        }
        public List<SelectionData> GetModeData()
        {
            List<SelectionData> modeData = new List<SelectionData>();
            modeData.Add(new SelectionData { Value = "Cell", Text = "Cell" });
            modeData.Add(new SelectionData { Value = "Row", Text = "Row Only" });
            modeData.Add(new SelectionData { Value = "Column", Text = "Column Only" });
            modeData.Add(new SelectionData { Value = "Both", Text = "Both" });
            return modeData;
        }
        public List<SelectionData> GetTypeData()
        {
            List<SelectionData> typeData = new List<SelectionData>();
            typeData.Add(new SelectionData { Value = "Single", Text = "Single" });
            typeData.Add(new SelectionData { Value = "RMultipleow", Text = "Multiple" });
            return typeData;
        }
        public class SelectionData
        {
            public string Value { get; set; }
            public string Text { get; set; }
        }  
    }
}
