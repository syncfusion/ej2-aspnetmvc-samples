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
using Syncfusion.EJ2.ImageEditor;

namespace EJ2MVCSampleBrowser.Controllers.ImageEditor
{
    public partial class ImageEditorController : Controller
    {
        public ActionResult ProfilePicture()
        {
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "openBtn", ButtonModel = new ButtonModel() { content = "Open", isPrimary = false, cssClass = "e-custom-img-btn e-img-custom-open" } });
            buttons.Add(new DialogDialogButton() { Click = "resetBtn", ButtonModel = new ButtonModel() { content = "Reset", isPrimary = false, cssClass = "e-custom-img-btn e-img-custom-reset" } });
            buttons.Add(new DialogDialogButton() { Click = "rotateBtn", ButtonModel = new ButtonModel() { content = "Rotate", isPrimary = false, cssClass = "e-custom-img-btn e-img-custom-rotate" } });
            buttons.Add(new DialogDialogButton() { Click = "doneBtn", ButtonModel = new ButtonModel() { content = "Apply", isPrimary = true, cssClass = "e-custom-img-btn e-img-custom-apply" } });
            ViewData["ImageButton"] = buttons;
            ViewData["imageTool"] = new string[] { };
            return View();
        }
    }
    public class ButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
        public string cssClass { get; set; }
    }

}