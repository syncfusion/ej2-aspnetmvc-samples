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
        public ActionResult Rtl()
        {
            List<ToolbarItem> rtl_items = new List<ToolbarItem>();
            rtl_items.Add(new ToolbarItem { PrefixIcon = "e-cut-icon tb-icons", TooltipText = "Cut", Overflow = OverflowOption.Show });
            rtl_items.Add(new ToolbarItem { PrefixIcon = "e-copy-icon tb-icons", TooltipText = "Copy", Overflow = OverflowOption.Show });
            rtl_items.Add(new ToolbarItem { PrefixIcon = "e-paste-icon tb-icons", TooltipText = "Paste", Overflow = OverflowOption.Show });
            rtl_items.Add(new ToolbarItem { Type = ItemType.Separator });
            rtl_items.Add(new ToolbarItem { PrefixIcon = "e-bold-icon tb-icons", TooltipText = "Bold", Overflow = OverflowOption.Show });
            rtl_items.Add(new ToolbarItem { PrefixIcon = "e-underline-icon tb-icons", TooltipText = "Underline", Overflow = OverflowOption.Show });
            rtl_items.Add(new ToolbarItem { PrefixIcon = "e-italic-icon tb-icons", TooltipText = "Italic", Overflow = OverflowOption.Show });
            rtl_items.Add(new ToolbarItem { Type = ItemType.Separator });
            rtl_items.Add(new ToolbarItem { PrefixIcon = "e-bullets-icon tb-icons", TooltipText = "Bullets", Text = "Bullets", ShowTextOn = DisplayMode.Overflow });
            rtl_items.Add(new ToolbarItem { PrefixIcon = "e-numbering-icon tb-icons", TooltipText = "Numbering", Text = "Numbering", ShowTextOn = DisplayMode.Overflow });
            rtl_items.Add(new ToolbarItem { Type = ItemType.Separator });
            rtl_items.Add(new ToolbarItem { PrefixIcon = "e-alignleft-icon tb-icons", TooltipText = "Align-Left", Text = "Left", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Show });
            rtl_items.Add(new ToolbarItem { PrefixIcon = "e-alignright-icon tb-icons", TooltipText = "Align-Right", Text = "Right", ShowTextOn = DisplayMode.Overflow });
            rtl_items.Add(new ToolbarItem { PrefixIcon = "e-aligncenter-icon tb-icons", TooltipText = "Align-Center", Text = "Center", ShowTextOn = DisplayMode.Overflow });
            rtl_items.Add(new ToolbarItem { PrefixIcon = "e-alignjustify-icon tb-icons", TooltipText = "Align-Justify", Text = "Justify", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Show });
            rtl_items.Add(new ToolbarItem { Type = ItemType.Separator });
            rtl_items.Add(new ToolbarItem { PrefixIcon = "e-undo-icon tb-icons", TooltipText = "Undo", Text = "Undo" });
            rtl_items.Add(new ToolbarItem { PrefixIcon = "e-redo-icon tb-icons", TooltipText = "Redo", Text = "Redo" });
            rtl_items.Add(new ToolbarItem { Type = ItemType.Separator });
            rtl_items.Add(new ToolbarItem { PrefixIcon = "e-radar-icon tb-icons", TooltipText = "Radar Chart", Text = "Radar", ShowTextOn = DisplayMode.Overflow });
            rtl_items.Add(new ToolbarItem { PrefixIcon = "e-line-icon tb-icons", TooltipText = "Line Chart", Text = "Line", ShowTextOn = DisplayMode.Overflow });
            rtl_items.Add(new ToolbarItem { Type = ItemType.Separator });
            rtl_items.Add(new ToolbarItem { PrefixIcon = "e-table-icon tb-icons", TooltipText = "Table", Text = "Table", ShowTextOn = DisplayMode.Overflow });
            rtl_items.Add(new ToolbarItem { PrefixIcon = "e-picture-icon tb-icons", TooltipText = "Picture", Text = "Picture", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Hide });
            rtl_items.Add(new ToolbarItem { PrefixIcon = "e-design-icon tb-icons", TooltipText = "Design", Text = "Design", ShowTextOn = DisplayMode.Overflow, Overflow = OverflowOption.Hide });
            ViewData["rtlItems"] = rtl_items;

            ViewData["overflowData"] = new string[] { "Scrollable", "Popup" };
            return View();
        }
    }

}