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
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class RichTextEditorController : Controller
    {
        // GET: FormatPainter
        public ActionResult FormatPainter()
        {
            ViewBag.Items = new object[] {"FormatPainter","Bold", "Italic", "Underline", "StrikeThrough",
                "FontName", "FontSize", "FontColor", "BackgroundColor", "SuperScript", "SubScript", "|",
                "Formats", "Alignments", "NumberFormatList", "BulletFormatList",
                "Outdent", "Indent", "|", "CreateTable", "CreateLink", "Image", "|", "Undo", "Redo","SourceCode", "FullScreen"};
            return View();
        }
    }
}