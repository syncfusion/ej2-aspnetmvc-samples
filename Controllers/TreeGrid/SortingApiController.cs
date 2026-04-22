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
        // GET: DefaultFunctionalities
        public ActionResult SortingApi()
        {
            var treeData = TreeGridItems.GetTreeData();
            ViewData["datasource"] = treeData;

            List<object> dd = new List<object>();
            dd.Add(new { name = "Task ID", id = "TaskId" });
            dd.Add(new { name = "Start Date", id = "StartDate" });
            dd.Add(new { name = "Duration", id = "Duration" });
            dd.Add(new { name = "Progress", id = "Progress" });
            ViewData["dd"] = dd;

            List<object> index = new List<object>();
            index.Add(new { name = "Ascending", id = "Ascending" });
            index.Add(new { name = "Descending", id = "Descending" });
            ViewData["index"] = index;
            return View();
        }
    }
}