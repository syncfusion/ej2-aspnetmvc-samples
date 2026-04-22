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
        public string dateStr;
        public ActionResult Popup()
        {
            List<ToolbarItem> popItems = new List<ToolbarItem>();
            popItems.Add(new ToolbarItem { PrefixIcon = "e-cut-icon tb-icons", TooltipText = "Cut", Text = "Cut", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Show });
            popItems.Add(new ToolbarItem { PrefixIcon = "e-copy-icon tb-icons", TooltipText = "Copy", Text = "Copy", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Show });
            popItems.Add(new ToolbarItem { PrefixIcon = "e-paste-icon tb-icons", TooltipText = "Paste", Text = "Paste", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Show });
            popItems.Add(new ToolbarItem { Type = ItemType.Separator });
            popItems.Add(new ToolbarItem { PrefixIcon = "e-bold-icon tb-icons", TooltipText = "Bold", Text = "Bold", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Show });
            popItems.Add(new ToolbarItem { PrefixIcon = "e-underline-icon tb-icons", TooltipText = "Underline", Text = "Underline", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Show });
            popItems.Add(new ToolbarItem { PrefixIcon = "e-italic-icon tb-icons", TooltipText = "Italic", Text = "Italic", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Show });
            popItems.Add(new ToolbarItem { Type = ItemType.Separator });
            popItems.Add(new ToolbarItem { PrefixIcon = "e-bullets-icon tb-icons", TooltipText = "Bullets", Text = "Bullets", Overflow = OverflowOption.Show });
            popItems.Add(new ToolbarItem { PrefixIcon = "e-numbering-icon tb-icons", TooltipText = "Numbering", Text = "Numbering", Overflow = OverflowOption.Show });
            popItems.Add(new ToolbarItem { Type = ItemType.Separator });
            popItems.Add(new ToolbarItem { PrefixIcon = "e-tbar-undo-icon tb-icons", TooltipText = "Undo", Text = "Undo" });
            popItems.Add(new ToolbarItem { PrefixIcon = "e-tbar-redo-icon tb-icons", TooltipText = "Redo", Text = "Redo" });
            popItems.Add(new ToolbarItem { Type = ItemType.Separator });
            popItems.Add(new ToolbarItem { PrefixIcon = "e-alignleft-icon tb-icons", TooltipText = "Align-Left", Text = "Left", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Show });
            popItems.Add(new ToolbarItem { PrefixIcon = "e-alignright-icon tb-icons", TooltipText = "Align-Right", Text = "Right", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Show });
            popItems.Add(new ToolbarItem { PrefixIcon = "e-aligncenter-icon tb-icons", TooltipText = "Align-Center", Text = "Center", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Show });
            popItems.Add(new ToolbarItem { PrefixIcon = "e-alignjustify-icon tb-icons", TooltipText = "Align-Justify", Text = "Justify", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Show });
            popItems.Add(new ToolbarItem { Type = ItemType.Separator });
            popItems.Add(new ToolbarItem { PrefixIcon = "e-radar-icon tb-icons", TooltipText = "Radar Chart", Text = "Radar", ShowTextOn = DisplayMode.Overflow });
            popItems.Add(new ToolbarItem { PrefixIcon = "e-line-icon tb-icons", TooltipText = "Line Chart", Text = "Line", ShowTextOn = DisplayMode.Overflow });
            popItems.Add(new ToolbarItem { PrefixIcon = "e-doughnut-icon tb-icons", TooltipText = "Doughnut Chart", Text = "Doughnut", ShowTextOn = DisplayMode.Overflow });
            popItems.Add(new ToolbarItem { PrefixIcon = "e-bubble-icon tb-icons", TooltipText = "Bubble Chart", Text = "Bubble", ShowTextOn = DisplayMode.Overflow });
            popItems.Add(new ToolbarItem { PrefixIcon = "e-table-icon tb-icons", TooltipText = "Table", Text = "Table", ShowTextOn = DisplayMode.Overflow });
            popItems.Add(new ToolbarItem { PrefixIcon = "e-picture-icon tb-icons", TooltipText = "Picture", Text = "Picture", ShowTextOn = DisplayMode.Overflow });
            popItems.Add(new ToolbarItem { PrefixIcon = "e-design-icon tb-icons", TooltipText = "Design", Text = "Design", ShowTextOn = DisplayMode.Overflow });

            ViewData["popItems"] = popItems;

            dateStr = String.Format("{0:MMMM}", DateTime.Now).ToString() + " " + DateTime.Now.Year.ToString();
            List<ToolbarItem> alwaysItems = new List<ToolbarItem>();

            alwaysItems.Add(new ToolbarItem { Template = "<div class='e-tool-name'>" + dateStr +"</div>", Overflow = OverflowOption.Show });
            alwaysItems.Add(new ToolbarItem { PrefixIcon = "e-icon-day e-icons", TooltipText = "Today", Text = "Today", Overflow = OverflowOption.Hide, Align = ItemAlign.Right});
            alwaysItems.Add(new ToolbarItem { Type = ItemType.Separator });
            alwaysItems.Add(new ToolbarItem { PrefixIcon = "e-icon-week e-icons", TooltipText = "Week", Text = "Week", Overflow = OverflowOption.Hide, Align = ItemAlign.Right });
            alwaysItems.Add(new ToolbarItem { PrefixIcon = "e-icon-month e-icons", TooltipText = "Month", Text = "Month", Overflow = OverflowOption.Hide, Align = ItemAlign.Right });
            alwaysItems.Add(new ToolbarItem { PrefixIcon = "e-icon-year e-icons", TooltipText = "Year", Text = "Year", Overflow = OverflowOption.Hide, Align = ItemAlign.Right });
            alwaysItems.Add(new ToolbarItem { PrefixIcon = "e-print e-icons", TooltipText = "Print", Text = "Print", Overflow = OverflowOption.Hide, ShowAlwaysInPopup = true });
            alwaysItems.Add(new ToolbarItem { PrefixIcon = "e-reccurence-icon e-icons", TooltipText = "Sync", Text = "Sync", Overflow = OverflowOption.Hide, ShowAlwaysInPopup = true });

            ViewData["popAlwaysItems"] = alwaysItems;

            return View();
        }
    }

}