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
        public ActionResult InsertMedia()
        {
            string hostUrl = "https://services.syncfusion.com/aspnet/production/";
            ViewData["Items"] = new[] { "Bold", "Italic", "Underline", "|", "Formats", "Alignments", "Blockquote", "OrderedList", "UnorderedList", "|", "CreateLink", "Image", "Audio", "Video", "|", "SourceCode", "Undo", "Redo" };
            ViewData["InsertAudioSettings"] = new Syncfusion.EJ2.RichTextEditor.RichTextEditorAudioSettings
            {
                SaveUrl = hostUrl + "api/RichTextEditor/SaveFile",
                RemoveUrl = hostUrl + "api/RichTextEditor/DeleteFile",
                Path = hostUrl + "RichTextEditor/"
            };
            ViewData["InsertVideoSettings"] = new Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings
            {
                SaveUrl = hostUrl + "api/RichTextEditor/SaveFile",
                RemoveUrl = hostUrl + "api/RichTextEditor/DeleteFile",
                Path = hostUrl + "RichTextEditor/"
            };

            return View();
        }
    }
}
