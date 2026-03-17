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
        List<statusData> data = new List<statusData>();
        public ActionResult SearchFilter()
        {
            ViewData["PriorityData"] = new string[] { "None", "High", "Normal", "Low" };
            data.Add(new statusData { Id = "None", Value = "None" });
            data.Add(new statusData { Id = "To Do", Value = "Open" });
            data.Add(new statusData { Id = "In Progress", Value = "InProgress" });
            data.Add(new statusData { Id = "Testing", Value = "Testing" });
            data.Add(new statusData { Id = "Done", Value = "Close" });
            ViewData["StatusData"] = data;
            ViewData["data"] = new KanbanDataModels().KanbanTasks();
            return View();
        }
    }
    public class statusData
    {
        public string Id { get; set; }
        public string Value { get; set; }

    }
}