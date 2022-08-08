using Syncfusion.EJ2.Navigations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Tooltip
{
    public partial class TooltipController : Controller
    {

        public ActionResult Template()
        {
            List<ToolbarItem> items = new List<ToolbarItem>();
            items.Add(new ToolbarItem { PrefixIcon = "e-cut-icon tb-icons", TooltipText = "Cut" });
            items.Add(new ToolbarItem { PrefixIcon = "e-copy-icon tb-icons", TooltipText = "Copy" });
            items.Add(new ToolbarItem { PrefixIcon = "e-paste-icon tb-icons", TooltipText = "Paste" });
            items.Add(new ToolbarItem { Type = ItemType.Separator });
            items.Add(new ToolbarItem { PrefixIcon = "e-bold-icon tb-icons", TooltipText = "Bold" });
            items.Add(new ToolbarItem { PrefixIcon = "e-underline-icon tb-icons", TooltipText = "Underline" });
            items.Add(new ToolbarItem { PrefixIcon = "e-italic-icon tb-icons", TooltipText = "Italic" });
            ViewBag.tbItems = items;
            return View();
        }
    }
}
