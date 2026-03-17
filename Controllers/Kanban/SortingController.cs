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
namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class KanbanController : Controller
    {
        List<sortData> sortData = new List<sortData>();
        // GET: Sorting
        public ActionResult Sorting()
        {
            ViewData["data"] = new KanbanDataModels().KanbanTasks();
            sortData.Add(new sortData { Id = "DataSourceOrder", Sort = "Data Source Order" });
            sortData.Add(new sortData { Id = "Index", Sort = "Index" });
            sortData.Add(new sortData { Id = "Custom", Sort = "Custom" });
            ViewData["SortByData"] = sortData;
            ViewData["FieldData"] = new string[] { "None" };
            ViewData["DirectionData"] = new string[] { "Ascending", "Descending" };
            return View();
        }
    }
    public class sortData
    {
        public string Id { get; set; }
        public string Sort { get; set; }

    }
}