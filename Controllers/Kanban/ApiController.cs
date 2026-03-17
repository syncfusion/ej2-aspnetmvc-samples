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
using Syncfusion.EJ2.Popups;
namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class KanbanController : Controller
    {
        public ActionResult Api()
        {
            ViewData["data"] = new KanbanDataModels().KanbanTasks();
            ViewData["ApiDropDown"] = new KanbanDataModels().ApiData();
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "dlgButtonClick", ButtonModel = new CustomButtonModel() { content = "OK", isPrimary = true } });
            ViewData["DefaultButtons"] = buttons;
            return View();
        }
    }
    public class CustomButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
}