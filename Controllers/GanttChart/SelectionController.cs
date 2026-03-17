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
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Gantt
{
    public partial class GanttChartController : Controller
    {
        // GET: Gantt
        public ActionResult Selection()
        {
            ViewData["dataSource"] = GanttData.ProjectNewData();
            ViewData["data1"] = DropDownListData1.SelectionModeList();
            ViewData["data2"] = DropDownListData1.SelectionTypeList();
            ViewData["data3"] = DropDownListData2.SelectionToggleList();
            return View();
        }
        public class DropDownListData1
        {
            public string id { get; set; }
            public string type { get; set; }

            public static List<DropDownListData1> SelectionModeList()
            {
                List<DropDownListData1> Data = new List<DropDownListData1>();
                Data.Add(new DropDownListData1 { id = "Row", type = "Row" });
                Data.Add(new DropDownListData1 { id = "Cell", type = "Cell" });
                return Data;
            }

            public static List<DropDownListData1> SelectionTypeList()
            {
                List<DropDownListData1> Data = new List<DropDownListData1>();
                Data.Add(new DropDownListData1 { id = "Single", type = "Single" });
                Data.Add(new DropDownListData1 { id = "Multiple", type = "Multiple" });
                return Data;
            }
        }
        public class DropDownListData2
        {
            public bool id { get; set; }
            public string type { get; set; }

            public static List<DropDownListData2> SelectionToggleList()
            {
                List<DropDownListData2> Data = new List<DropDownListData2>();
                Data.Add(new DropDownListData2 { id = true, type = "Enable" });
                Data.Add(new DropDownListData2 { id = false, type = "Disable" });
                return Data;
            }
        }
    }
}