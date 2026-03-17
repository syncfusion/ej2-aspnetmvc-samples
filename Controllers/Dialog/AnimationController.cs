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
using Syncfusion.EJ2.Popups;

namespace EJ2MVCSampleBrowser.Controllers.Dialog
{
    public partial class DialogController : Controller
    {
        // GET: AnimationDialog
        public ActionResult Animation()
        {
            List<DialogDialogButton> button = new List<DialogDialogButton>() { };
            button.Add(new DialogDialogButton() { Click = "dlgButtonClick", ButtonModel = new defaultButton() { content = "Hide", isPrimary = true } });
            ViewData["DefaultButton"] = button;
            return View();
        }
    }
    public class defaultButton
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
}