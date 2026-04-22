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
        public ActionResult Template()
        {
            List<ToolbarItem> templateItems = new List<ToolbarItem>();
            templateItems.Add(new ToolbarItem { PrefixIcon = "e-icons e-folder", TooltipText = "Open File", Text = "open", ShowTextOn = DisplayMode.Overflow, Align = ItemAlign.Left });
            templateItems.Add(new ToolbarItem { Type = ItemType.Separator });
            templateItems.Add(new ToolbarItem { PrefixIcon = "e-icons e-first-page", TooltipText = "Show first page", Text = "First", ShowTextOn = DisplayMode.Overflow, Align = ItemAlign.Left, Disabled=true });
            templateItems.Add(new ToolbarItem { PrefixIcon = "e-icons e-chevron-left", TooltipText = "Show previous page", Text = "Previous", ShowTextOn = DisplayMode.Overflow, Align = ItemAlign.Left, Disabled = true });
            templateItems.Add(new ToolbarItem { PrefixIcon = "e-icons e-chevron-right", TooltipText = "Show next page", Text = "Next", ShowTextOn = DisplayMode.Overflow, Align = ItemAlign.Left });
            templateItems.Add(new ToolbarItem { PrefixIcon = "e-icons e-last-page", TooltipText = "Show last page", Text = "Last", ShowTextOn = DisplayMode.Overflow, Align = ItemAlign.Left });
            templateItems.Add(new ToolbarItem { Template = "#count-textbox", Type = ItemType.Input, CssClass = "page-count" });
            templateItems.Add(new ToolbarItem { Type = ItemType.Separator });
            templateItems.Add(new ToolbarItem { PrefixIcon = "e-icons e-zoom-out", TooltipText = "Zoom-Out", Text = "Bold", ShowTextOn = DisplayMode.Overflow, Align = ItemAlign.Left, TabIndex = '0' });
            templateItems.Add(new ToolbarItem { PrefixIcon = "e-icons e-zoom-in", TooltipText = "Underline", Text = "Underline", ShowTextOn = DisplayMode.Overflow, Align = ItemAlign.Left });
            templateItems.Add(new ToolbarItem { Template = "#combo-element", Type = ItemType.Input, CssClass = "percentage" });
            templateItems.Add(new ToolbarItem { Type = ItemType.Separator });
            templateItems.Add(new ToolbarItem { PrefixIcon = "e-icons e-mouse-pointer", TooltipText = "Text Selection Tool", Text = "Text", ShowTextOn = DisplayMode.Overflow, Align = ItemAlign.Left, TabIndex = '0' });
            templateItems.Add(new ToolbarItem { PrefixIcon = "e-icons e-pan", TooltipText = "Pan Mode", Text = "Pan Mode", ShowTextOn = DisplayMode.Overflow, Align = ItemAlign.Left });
            templateItems.Add(new ToolbarItem { Type = ItemType.Separator });
            templateItems.Add(new ToolbarItem { PrefixIcon = "e-icons e-undo", TooltipText = "Undo", Text = "Undo", ShowTextOn = DisplayMode.Overflow, Align = ItemAlign.Left });
            templateItems.Add(new ToolbarItem { PrefixIcon = "e-icons e-redo", TooltipText = "Redo", Text = "Redo", ShowTextOn = DisplayMode.Overflow, Align = ItemAlign.Left });
            templateItems.Add(new ToolbarItem { Type = ItemType.Separator });
            templateItems.Add(new ToolbarItem { PrefixIcon = "e-pv-comment-icon", TooltipText = "Add Comments", Text = "Add", ShowTextOn = DisplayMode.Overflow, Align = ItemAlign.Left, TabIndex = '0'  });
            templateItems.Add(new ToolbarItem { Type = ItemType.Separator });
            templateItems.Add(new ToolbarItem { Text = "Submit", Align = ItemAlign.Left, TabIndex = '0'  });
            templateItems.Add(new ToolbarItem { Template = "#text-element", Type = ItemType.Input, CssClass = "find", Align = ItemAlign.Right, Overflow = OverflowOption.Show });
            templateItems.Add(new ToolbarItem { PrefixIcon = "e-icons e-annotation-edit", TooltipText = "Edit Annotations", Text = "Edit", ShowTextOn = DisplayMode.Overflow, Align = ItemAlign.Right });
            templateItems.Add(new ToolbarItem { PrefixIcon = "e-icons e-print", TooltipText = "Print File", Text = "Print", ShowTextOn = DisplayMode.Overflow, Align = ItemAlign.Right });
            templateItems.Add(new ToolbarItem { PrefixIcon = "e-icons e-download", TooltipText = "Download File", Text = "Download", ShowTextOn = DisplayMode.Overflow, Align = ItemAlign.Right });

            ViewData["templateItems"] = templateItems;
            ViewData["data"] = new string[] { "25%", "50%", "75%", "100%" };

            return View();

        }
    }
}