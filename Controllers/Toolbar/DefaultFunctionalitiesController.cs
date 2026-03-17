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
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Controllers.Toolbar
{
    public partial class ToolbarController : Controller
    {
        public ActionResult DefaultFunctionalities()
        {
            List<ToolbarItem> items = new List<ToolbarItem>();
            {
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-cut", TooltipText = "Cut" });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-copy", TooltipText = "Copy" });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-paste", TooltipText = "Paste" });

                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-bold", TooltipText = "Bold" });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-underline", TooltipText = "Underline" });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-italic", TooltipText = "Italic" });

                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-align-left", TooltipText = "Align-Left" });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-align-right", TooltipText = "Align-Right" });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-align-center", TooltipText = "Align-Center" });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-justify", TooltipText = "Align-Justify" });

                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-list-unordered", TooltipText = "Bullets" });
            }
            ViewData["tbItems"] = items;

            List<ToolbarItem> item = new List<ToolbarItem>();
            {
                item.Add(new ToolbarItem { PrefixIcon = "e-icons e-cut", TooltipText = "Cut", Text = "Cut" });
                item.Add(new ToolbarItem { PrefixIcon = "e-icons e-copy", TooltipText = "Copy", Text = "Copy" });
                item.Add(new ToolbarItem { PrefixIcon = "e-icons e-paste", TooltipText = "Paste", Text = "Paste" });

                item.Add(new ToolbarItem { PrefixIcon = "e-icons e-bold", TooltipText = "Bold", Text = "Bold" });
                item.Add(new ToolbarItem { PrefixIcon = "e-icons e-underline", TooltipText = "Underline", Text = "Underline" });
                item.Add(new ToolbarItem { PrefixIcon = "e-icons e-italic", TooltipText = "Italic", Text = "Italic" });

                item.Add(new ToolbarItem { PrefixIcon = "e-icons e-align-left", TooltipText = "Align-Left", Text = "Align-Left" });
                item.Add(new ToolbarItem { PrefixIcon = "e-icons e-align-right", TooltipText = "Align-Right", Text = "Align-Right" });
                item.Add(new ToolbarItem { PrefixIcon = "e-icons e-align-center", TooltipText = "Align-Center", Text = "Align-Center" });
                item.Add(new ToolbarItem { PrefixIcon = "e-icons e-justify", TooltipText = "Align-Justify", Text = "Align-Justify" });

                item.Add(new ToolbarItem { PrefixIcon = "e-icons e-list-unordered", TooltipText = "Bullets", Text = "Bullets" });
                item.Add(new ToolbarItem { PrefixIcon = "e-icons e-list-ordered", TooltipText = "Numbering", Text = "Numbering" });

                item.Add(new ToolbarItem { PrefixIcon = "e-icons e-undo", TooltipText = "Undo", Text = "Undo" });
                item.Add(new ToolbarItem { PrefixIcon = "e-icons e-redo", TooltipText = "Redo", Text = "Redo" });

                item.Add(new ToolbarItem { PrefixIcon = "e-icons e-increase-indent", TooltipText = "Text Indent", Text = "Text Indent" });
                item.Add(new ToolbarItem { PrefixIcon = "e-icons e-decrease-indent", TooltipText = "Text Outdent", Text = "Text Outdent" });
                item.Add(new ToolbarItem { PrefixIcon = "e-icons e-erase", TooltipText = "Clear", Text = "Clear" });
            }
            ViewData["overflowItems"] = item;

            return View();
        }
    }

}