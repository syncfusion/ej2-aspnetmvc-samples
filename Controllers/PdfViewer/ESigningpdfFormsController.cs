#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
using System.Web.Http;
using System.IO;
using System.Reflection;
using Syncfusion.EJ2.Popups;

namespace EJ2MVCSampleBrowser.Controllers.PdfViewer
{
    public partial class PdfViewerController : Controller
    {

        public ActionResult ESigningPdfForms()
        {
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "dlgButtonClick", ButtonModel = new ModalButtonModel() { content = "OK" } });
            ViewData["ModalButton"] = buttons;
            return View();
        }
    }

    public class ModalButtonModel
    {
        public string content { get; set; }
    }
}
