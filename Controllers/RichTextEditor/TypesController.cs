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
        // GET: /<controller>/
        public ActionResult Types()
        {
            List<Data> datasource = new List<Data>();
            datasource.Add(new Data() { text = "Expand", value = 1 });
            datasource.Add(new Data() { text = "Multi Row", value = 2 });
            datasource.Add(new Data() { text = "Scrollable", value = 3 });
            datasource.Add(new Data() { text = "Popup", value = 4 });
            ViewData["Data"] = datasource;
            ViewData["Items"] = new[] {"Bold", "Italic", "Underline", "StrikeThrough", "SuperScript", "SubScript", "|",
                "FontName", "FontSize", "FontColor", "BackgroundColor",  "|",
                "LowerCase", "UpperCase",
                "Formats", "Alignments", "Blockquote", "|", "NumberFormatList", "BulletFormatList", "|",
                "Outdent", "Indent", "|",
                "CreateLink", "Image", "Video", "Audio", "CreateTable", "|", "FormatPainter", "ClearFormat", "|", "EmojiPicker", "Print", "|",
                "SourceCode", "FullScreen", "|", "Undo", "Redo"};
            return View();
        }
    }
}
