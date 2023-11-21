#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class RichTextEditorController : Controller
    {
        public ActionResult DefaultMode()
        {
            ViewBag.Value = @"The sample is added to showcase **markdown editing**.

Type or edit the content and apply formatting to view markdown formatted content.

We can add our own custom formation syntax for the Markdown formation, [sample link](https://ej2.syncfusion.com/home/).

The third-party library <b>Marked</b> is used in this sample to convert markdown into HTML content";
            var tool = new {
                tooltipText = "Preview",
                template = @"<button id='preview-code' class='e-tbar-btn e-control e-btn e-icon-btn'>
                        <span class='e-btn-icon e-md-preview e-icons'></span></button>"
            };
            ViewBag.Items = new object[] {"Bold", "Italic", "StrikeThrough", "|",
                "Formats", "OrderedList", "UnorderedList","Superscript", "Subscript", "|", "CreateTable",
                "CreateLink", "Image", "|", tool
                , "|", "Undo", "Redo"};
            return View();
        }
    }
}
