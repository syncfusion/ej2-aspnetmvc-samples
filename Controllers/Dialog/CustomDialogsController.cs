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
        // GET: Dialog
        public ActionResult CustomDialogs()
        {
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "alertBtnClick", ButtonModel = new customButtonModel() { content = "Dismiss", isPrimary = true } });
            ViewData["AlertButton"] = buttons;
            List<DialogDialogButton> button = new List<DialogDialogButton>() { };
            button.Add(new DialogDialogButton() { Click = "confirmBtnClick", ButtonModel = new confirmButtonModel() { content = "Yes", isPrimary = true } });
            button.Add(new DialogDialogButton() { Click = "confirmBtnClick", ButtonModel = new confirmButtonModel() { content = "No"} });
            ViewData["ConfirmButton"] = button;
            List<DialogDialogButton> btn = new List<DialogDialogButton>() { };
            btn.Add(new DialogDialogButton() { Click = "promptBtnClick", ButtonModel = new promptButtonModel() { content = "Connect", isPrimary = true } });
            btn.Add(new DialogDialogButton() { Click = "promptBtnClick", ButtonModel = new promptButtonModel() { content = "Cancel" } });
            ViewData["PromptButton"] = btn;
            return View();            
        }
    }
    public class customButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
    public class confirmButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
    public class promptButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
}