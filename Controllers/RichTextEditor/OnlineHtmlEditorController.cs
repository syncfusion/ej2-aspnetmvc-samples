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
    public partial class RichTextEditorController : Controller
    {
        public ActionResult OnlineHtmlEditor()
        {
            ViewData["Tools"] = new[] { "Bold", "Italic", "Underline", "StrikeThrough",
                "FontName", "FontSize", "FontColor", "BackgroundColor",
                "Formats", "Alignments", "Blockquote", "|", "OrderedList", "UnorderedList", "|",
                "Outdent", "Indent", "|",
                "CreateLink", "Image", "Video", "Audio", "CreateTable", "|", "FormatPainter", "ClearFormat", "|", "EmojiPicker",
                "SourceCode", "|", "Undo", "Redo"};
            ViewData["Value"] = @"
                            <h3>Welcome to the HTML real-time live editor!</h3>
                            <p>Create and edit the valid HTML code simply! You don't worry about the HTML syntax to format your text content. The WYSIWYG editor (left side view) provided the toolbar to make format text and insert images, tables, and more options.</p>
                            <h4>Don't worry about syntax</h4>
                            <p>The content editing works bi-directional, you can write the HTML code on the right-side view (code view), and changes will reflect in the WYSIWYG editor.</p>";
            return View();
        }
    }
}