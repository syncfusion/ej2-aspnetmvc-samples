#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Newtonsoft.Json;
using Syncfusion.EJ2;
using Syncfusion.EJ2.Diagrams;
using Syncfusion.EJ2.Navigations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Web.Mvc;
using System.Web.UI;


namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        public ActionResult WorkFlowDiagram()
        {
            // Main Toolbar Items
            List<ToolbarItem> firstTbItems = new List<ToolbarItem>
            {
                new ToolbarItem { PrefixIcon = "e-icons e-circle-add", Text = "New", TooltipText = "New Diagram" },
                new ToolbarItem { PrefixIcon = "e-icons e-folder-open", Text = "Open", TooltipText = "Open Diagram" },
                new ToolbarItem { PrefixIcon = "e-icons e-save", Text = "Save", TooltipText = "Save Diagram" },
                new ToolbarItem { Type = ItemType.Separator },
                new ToolbarItem { PrefixIcon = "e-icons e-play", Text = "Execute", TooltipText = "Start Workflow", Width= "90", Overflow = OverflowOption.Show },
                new ToolbarItem { PrefixIcon = "e-icons e-reset", Text = "Reset", TooltipText = "Reset View/State", Overflow= OverflowOption.Show },
                new ToolbarItem { PrefixIcon = "e-icons e-trash", Text = "Delete", TooltipText = "Delete Selected" },
                new ToolbarItem { Type = ItemType.Separator },
                new ToolbarItem { PrefixIcon = "e-icons e-mouse-pointer", Text = "Select", TooltipText = "Select Tool", Overflow= OverflowOption.Show },
                new ToolbarItem { PrefixIcon = "e-icons e-pan", Text = "Pan", TooltipText = "Pan Tool", Overflow= OverflowOption.Show },
                new ToolbarItem { Type = ItemType.Separator },
                new ToolbarItem { Text = "Palette", Template = "<aside id='symbolPalette'></aside>", Overflow= OverflowOption.Show }
            };

            // Second Toolbar with toggle switch
            List<ToolbarItem> secondTbItems = new List<ToolbarItem>
            {
                new ToolbarItem { Template = "<div id='switch-container'><span id='editLabel' style='font-size: 14px; margin-right: 6px;'>Edit</span><input type='checkbox' id='switchMode' /></div>" },
            };

            // User handles Items
            List<DiagramUserHandle> userHandles = new List<DiagramUserHandle>
            {
                new DiagramUserHandle
                {
                    Name = "delete",
                    PathData = "M0.97,3.04 L12.78,3.04 L12.78,12.21 C12.78,12.64,12.59,13,12.2,13.3 C11.82,13.6,11.35,13.75,10.8,13.75 L2.95,13.75 C2.4,13.75,1.93,13.6,1.55,13.3 C1.16,13,0.97,12.64,0.97,12.21 Z M4.43,0 L9.32,0 L10.34,0.75 L13.75,0.75 L13.75,2.29 L0,2.29 L0,0.75 L3.41,0.75 Z",
                    Tooltip = new DiagramDiagramTooltip { Content = "Delete Node" },
                    Side = Side.Bottom,
                    Offset = 0.5,
                    Margin = new DiagramMargin { Bottom = 5 },
                    DisableConnectors = true
                },
                new DiagramUserHandle
                {
                    Name = "drawConnector",
                    PathData = "M6.09,0 L13.75,6.88 L6.09,13.75 L6.09,9.64 L0,9.64 L0,4.11 L6.09,4.11 Z",
                    Tooltip = new DiagramDiagramTooltip { Content = "Draw Connector" },
                    Side = Side.Right,
                    Offset = 0.5,
                    Margin = new DiagramMargin { Right = 5 },
                    DisableConnectors = true
                },
                new DiagramUserHandle
                {
                    Name = "stopAnimation",
                    PathData = "M4.75,0.75 L9.25,0.75 L9.25,9.25 L4.75,9.25 Z",
                    Tooltip = new DiagramDiagramTooltip { Content = "Enable Animation" },
                    DisableNodes = true
                }
            };

            ViewData["firstTbItems"] = firstTbItems;
            ViewData["secondTbItems"] = secondTbItems;
            ViewData["userHandles"] = userHandles;

            return View();
        }
    }
}