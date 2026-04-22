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
        public ActionResult MentionIntegration()
        {
            ViewData["Value"] = @"Hello [Albert](mailto:albert@gmail.com)

Welcome to the mention integration with markdown editor demo. Type @ character and tag user from the suggestion list.";
            ViewData["MentionChar"] = '@';
            var tool = new {
                template = @"<button id='preview-code' class='e-tbar-btn e-control e-btn e-icon-btn' aria-label='Preview Code'>
                        <span class='e-btn-icon e-md-preview e-icons'></span></button>"
            };
            ViewData["Items"] = new object[] {"Bold", "Italic", "StrikeThrough", "|",
                "Formats", "Blockquote", "OrderedList", "UnorderedList","Superscript", "Subscript", "|", "CreateTable",
                "CreateLink", "Image", "|", tool
                , "|", "Undo", "Redo"};
            ViewData["EmailData"] = new EmailDatas().EmailList();
            return View();
        }
    }
}