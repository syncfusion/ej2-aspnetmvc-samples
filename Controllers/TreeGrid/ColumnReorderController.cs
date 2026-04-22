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

namespace EJ2MVCSampleBrowser.Controllers.TreeGrid
{
    public partial class TreeGridController : Controller
    {
        public ActionResult ColumnReorder()
        {
            var treeData = TreeGridItems.GetTreeData();
            ViewData["datasource"] = treeData;

            List<object> dd = new List<object>();
            dd.Add(new { text = "Task ID", value = "TaskId" });
            dd.Add(new { text = "Task Name", value = "TaskName" });
            dd.Add(new { text = "Start Date", value = "StartDate" });
            dd.Add(new { text = "Duration", value = "Duration" });
            dd.Add(new { text = "Progress", value = "Progress" });
            ViewData["columns"] = dd;

            List<object> index = new List<object>();
            index.Add(new { text = "1", value = "0" });
            index.Add(new { text = "2", value = "1" });
            index.Add(new { text = "3", value = "2" });
            index.Add(new { text = "4", value = "3" });
            index.Add(new { text = "5", value = "4" });
            ViewData["index"] = index;

            return View();
        }
    }
}