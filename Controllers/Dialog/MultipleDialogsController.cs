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
        // GET: MultipleDialog
        public ActionResult MultipleDialogs()
        {
            List<DialogDialogButton> button = new List<DialogDialogButton>() { };
            button.Add(new DialogDialogButton() { Click = "dlgButtonClick", ButtonModel = new default1Button() { content = "Next", isPrimary = true } });
            ViewData["NextButton"] = button;
            List<DialogDialogButton> button1 = new List<DialogDialogButton>() { };
            button1.Add(new DialogDialogButton() { Click = "dlg2ButtonClick", ButtonModel = new default2Button() { content = "Close", isPrimary = true } });
            ViewData["CloseButton"] = button1;
            return View();
        }
    }

    public class default1Button
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }

    }
    public class default2Button
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }

    }
}