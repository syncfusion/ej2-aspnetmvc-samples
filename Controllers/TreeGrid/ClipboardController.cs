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
using EJ2MVCSampleBrowser.Controllers.Dialog;
using Syncfusion.EJ2.Popups;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.TreeGrid
{
    public partial class TreeGridController : Controller
    {
        // GET: Clipboard
        public ActionResult Clipboard()
        {
            var treeData = TreeGridItems.GetTreeData();
            ViewData["datasource"] = treeData;
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "alertBtnClick", ButtonModel = new customButtonModel() { content = "OK", isPrimary = true } });
            ViewData["alertbutton"] = buttons;
            List<Object> dropData = new List<object>() {
                new { id = "Parent", mode = "Parent" },
                new { id = "Child", mode = "Child" },
                new { id = "Both", mode = "Both" },
                new { id = "None", mode = "None" }
            };
            ViewData["dropdata"] = dropData;
            return View();
        }
        public class customButtonModel
        {
            public string content { get; set; }
            public bool isPrimary { get; set; }
        }        
    }
}
