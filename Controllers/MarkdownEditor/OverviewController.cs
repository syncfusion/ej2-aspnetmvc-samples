#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
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
        public ActionResult Overview()
        {
            ViewBag.Value = @"In Rich Text Editor , you click the toolbar buttons to format the words and the changes are visible immediately. 
Markdown is not like that. When you format the word in Markdown format, you need to add Markdown syntax to the word to indicate which words 
and phrases should look different from each other

Rich Text Editor supports markdown editing when the editorMode set as **markdown** and using both *keyboard interaction* and *toolbar action*, you can apply the formatting to text.

We can add our own custom formation syntax for the Markdown formation, [sample link](https://ej2.syncfusion.com/home/).

The third-party library <b>Marked</b> is used in this sample to convert markdown into HTML content";
            ViewBag.Items = new object[] {"Bold", "Italic", "StrikeThrough", "|", "Formats", "Blockquote", "OrderedList", "UnorderedList", "|", "CreateTable", "CreateLink", "Image", "|", "Undo", "Redo" };
            return View();
        }
    }
}
