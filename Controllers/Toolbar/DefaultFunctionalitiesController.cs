#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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
            items.Add(new ToolbarItem { PrefixIcon = "e-icons e-cut", TooltipText = "Cut" });
            items.Add(new ToolbarItem { PrefixIcon = "e-icons e-copy", TooltipText = "Copy" });
            items.Add(new ToolbarItem { PrefixIcon = "e-icons e-paste", TooltipText = "Paste" });
            
            items.Add(new ToolbarItem { PrefixIcon = "e-icons e-bold", TooltipText = "Bold" });
            items.Add(new ToolbarItem { PrefixIcon = "e-icons e-underline", TooltipText = "Underline" });
            items.Add(new ToolbarItem { PrefixIcon = "e-icons e-italic", TooltipText = "Italic" });
            items.Add(new ToolbarItem { PrefixIcon = "e-icons e-paint-bucket", TooltipText = "Color-Picker" });

            items.Add(new ToolbarItem { PrefixIcon = "e-icons e-align-left", TooltipText = "Align-Left" });
            items.Add(new ToolbarItem { PrefixIcon = "e-icons e-align-right", TooltipText = "Align-Right" });
            items.Add(new ToolbarItem { PrefixIcon = "e-icons e-align-center", TooltipText = "Align-Center" });
            items.Add(new ToolbarItem { PrefixIcon = "e-icons e-justify", TooltipText = "Align-Justify" });

            items.Add(new ToolbarItem { PrefixIcon = "e-icons e-list-unordered", TooltipText = "Bullets" });
            items.Add(new ToolbarItem { PrefixIcon = "e-icons e-list-ordered", TooltipText = "Numbering" });

            items.Add(new ToolbarItem { PrefixIcon = "e-icons e-undo", TooltipText = "Undo" });
            items.Add(new ToolbarItem { PrefixIcon = "e-icons e-redo", TooltipText = "Redo" });

            items.Add(new ToolbarItem { PrefixIcon = "e-icons e-upload-1", TooltipText = "Upload" });
            items.Add(new ToolbarItem { PrefixIcon = "e-icons e-download", TooltipText = "Download" });

            items.Add(new ToolbarItem { PrefixIcon = "e-icons e-increase-indent", TooltipText = "Text Indent" });
            items.Add(new ToolbarItem { PrefixIcon = "e-icons e-decrease-indent", TooltipText = "Text Outdent" });

            items.Add(new ToolbarItem { PrefixIcon = "e-icons e-erase", TooltipText = "Clear" });
            items.Add(new ToolbarItem { PrefixIcon = "e-icons e-refresh", TooltipText = "Reload" });
            items.Add(new ToolbarItem { PrefixIcon = "e-icons e-export", TooltipText = "Export" });

            ViewBag.tbItems = items;

            return View();
        }
    }

}