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
using System.Threading.Tasks;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class RichTextEditorController : Controller
    {
        public ActionResult QuickFormatToolbar()
        {
            ViewData["Text"] = new[] {
                "Formats", "|", "Bold", "Italic", "Fontcolor", "BackgroundColor", "|", "CreateLink", "Image", "CreateTable", "Blockquote", "|", "Unorderedlist", "Orderedlist", "Indent", "Outdent"
            };
            return View();
        }
    }
}
