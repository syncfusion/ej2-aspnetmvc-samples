#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
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
        public ActionResult DialogEditing()
        {
            ViewBag.data = new KanbanDataModels().KanbanTasks();
            ViewBag.status = new KanbanDataModels().DialogStatus();
            ViewBag.assignee = new KanbanDataModels().AssigneeData();
            ViewBag.priority = new KanbanDataModels().PriorityData();
            return View();
        }
    }
}