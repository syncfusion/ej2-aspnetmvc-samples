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
using System.Threading.Tasks;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class MarkdownEditorController : Controller
    {
        public ActionResult CustomFormat()
        {
            ViewData["value"] = "The sample is configured with customized markdown syntax using the __formatter__ property. Type the content and click the toolbar item to view customized markdown syntax. For an unordered list, you need to add a plus sign before the word (e.g., + list1). Or To make a phrase bold, you need to add two underscores before and after the phrase (e.g., __this text is bold__).";
            ViewData["Items"] = new object[] {"Bold", "Italic", "StrikeThrough", "|",
                "Formats", "Blockquote", "OrderedList", "UnorderedList", "|",
                "CreateLink", "Image", "|",
                new {
                    template= @"<button id='preview-code' class='e-tbar-btn e-control e-btn e-icon-btn' aria-label='Preview Code'>
                        <span class='e-btn-icon e-icons e-md-preview'></span></button>"
                },"Undo", "Redo"};

            return View();
        }
    }
}
