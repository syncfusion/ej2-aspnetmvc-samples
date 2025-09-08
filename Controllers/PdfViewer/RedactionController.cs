#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.EJ2.Navigations;
using Syncfusion.EJ2.Popups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace EJ2MVCSampleBrowser.Controllers.PdfViewer
{
    public partial class PdfViewerController : Controller
    {
        // GET: Redaction
        public ActionResult Redaction()
        {
            ViewData["zoomList"]=new string[] {"10%","25%","50%","75%","100%","200%","400%"};
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "dlgButtonClick", ButtonModel = new RedactModalButtonModel() { content = "Cancel" } });
            ViewData["ModalButton"] = buttons;
            return View();
        }

    }
    public class RedactModalButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
}