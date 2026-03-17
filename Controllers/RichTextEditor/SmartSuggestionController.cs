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
        public ActionResult SmartSuggestion()
        {
            ViewData["items"] = new object[] { "Bold", "Italic", "Underline", "StrikeThrough", "SuperScript", "SubScript", "|",
                "FontName", "FontSize", "FontColor", "BackgroundColor",  "|",
                "LowerCase", "UpperCase",
                "Formats", "Alignments", "Blockquote", "|", "NumberFormatList", "BulletFormatList", "|",
                "Outdent", "Indent", "|",
                "CreateLink", "Image", "Video", "Audio", "CreateTable", "CodeBlock", "|", "FormatPainter", "ClearFormat", "|", "EmojiPicker", "|",
                "SourceCode", "|", "Undo", "Redo"
            };
            ViewData["SlashMenuSettings"] = new Syncfusion.EJ2.RichTextEditor.RichTextEditorSlashMenuSettings
            {
                Enable = true,
                Items = new object[] { "Paragraph", "Heading 1", "Heading 2", "Heading 3", "Heading 4", "OrderedList", "UnorderedList",
                    "CodeBlock", "Blockquote", "Link", "Image", "Video", "Audio", "Table", "Emojipicker",
                    new {
                        text= "Meeting notes",
                        description= "Insert a meeting note template.",
                        iconCss= "e-icons e-description",
                        type= "Custom",
                        command= "MeetingNotes"
                    },
                    new {
                        text= "Signature",
                        description= "Insert a signature template.",
                        iconCss= "e-icons e-signature",
                        type= "Custom",
                        command= "Signature"
                    }
                }
            };
            return View();
        }
    }
}
