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
            items.Add(new ToolbarItem { PrefixIcon = "e-cut-icon tb-icons", TooltipText = "Cut" });
            items.Add(new ToolbarItem { PrefixIcon = "e-copy-icon tb-icons", TooltipText = "Copy" });
            items.Add(new ToolbarItem { PrefixIcon = "e-paste-icon tb-icons", TooltipText = "Paste" });
            
            items.Add(new ToolbarItem { PrefixIcon = "e-bold-icon tb-icons", TooltipText = "Bold" });
            items.Add(new ToolbarItem { PrefixIcon = "e-underline-icon tb-icons", TooltipText = "Underline" });
            items.Add(new ToolbarItem { PrefixIcon = "e-italic-icon tb-icons", TooltipText = "Italic" });
            items.Add(new ToolbarItem { PrefixIcon = "e-color-icon tb-icons", TooltipText = "Color-Picker" });

            items.Add(new ToolbarItem { PrefixIcon = "e-alignleft-icon tb-icons", TooltipText = "Align-Left" });
            items.Add(new ToolbarItem { PrefixIcon = "e-alignright-icon tb-icons", TooltipText = "Align-Right" });
            items.Add(new ToolbarItem { PrefixIcon = "e-aligncenter-icon tb-icons", TooltipText = "Align-Center" });
            items.Add(new ToolbarItem { PrefixIcon = "e-alignjustify-icon tb-icons", TooltipText = "Align-Justify" });

            items.Add(new ToolbarItem { PrefixIcon = "e-bullets-icon tb-icons", TooltipText = "Bullets" });
            items.Add(new ToolbarItem { PrefixIcon = "e-numbering-icon tb-icons", TooltipText = "Numbering" });

            items.Add(new ToolbarItem { PrefixIcon = "e-ascending-icon tb-icons", TooltipText = "Sort A - Z" });
            items.Add(new ToolbarItem { PrefixIcon = "e-descending-icon tb-icons", TooltipText = "Sort Z - A" });

            items.Add(new ToolbarItem { PrefixIcon = "e-upload-icon tb-icons", TooltipText = "Upload" });
            items.Add(new ToolbarItem { PrefixIcon = "e-download-icon tb-icons", TooltipText = "Download" });

            items.Add(new ToolbarItem { PrefixIcon = "e-indent-icon tb-icons", TooltipText = "Text Indent" });
            items.Add(new ToolbarItem { PrefixIcon = "e-outdent-icon tb-icons", TooltipText = "Text Outdent" });

            items.Add(new ToolbarItem { PrefixIcon = "e-clear-icon tb-icons", TooltipText = "Clear" });
            items.Add(new ToolbarItem { PrefixIcon = "e-reload-icon tb-icons", TooltipText = "Reload" });
            items.Add(new ToolbarItem { PrefixIcon = "e-export-icon tb-icons", TooltipText = "Export" });

            ViewBag.tbItems = items;

            return View();
        }
    }

}