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
using EJ2CoreSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class RichTextEditorController : Controller
    {
        public ActionResult Image()
        {
            ViewData["Data"] = new FormatOption().SaveFormat();
            object tools1 = new
            {
                tooltipText = "Rotate Left",
                template = "<button class='e-tbar-btn e-btn' id='roatateLeft'><span class='e-btn-icon e-icons e-rotate-left'></span>"
            };
            object tools2 = new
            {
                tooltipText = "Rotate Right",
                template = "<button class='e-tbar-btn e-btn' id='roatateRight'><span class='e-btn-icon e-icons e-rotate-right'></span>"
            };
            ViewData["Image"] = new[] {
                "Replace", "Align", "Caption", "Remove", "InsertLink", "OpenImageLink", "|",
                "EditImageLink", "RemoveImageLink", "Display", "AltText", "Dimension",tools1
                , tools2
            };

            return View();
        }
    }
}
