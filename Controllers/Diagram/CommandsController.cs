#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.EJ2.Diagrams;
using Syncfusion.EJ2.Navigations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: Commands
        public ActionResult Commands()
        {
            List<DiagramNode> nodes = new List<DiagramNode>();
            nodes.Add(new DiagramNode()
            {
                Shape = new { type = "Text", content = "Select the below shapes" },
                Constraints = NodeConstraints.PointerEvents,
                Style = new NodeStyleNodes()
                {
                    FontSize = 10,
                    Fill = "None",
                    FontFamily = "sans-serif",
                    StrokeWidth = 0
                },
                OffsetX = 150,
                OffsetY = 40,
            });
            nodes.Add(new DiagramNode()
            {
                Id = "node1",
                Width = 60,
                Height = 40,
                Style = new NodeStyleNodes()
                {
                    Fill = "#DAEBFF",
                    StrokeColor = "white"
                },
                OffsetX = 150,
                OffsetY = 100,
            });
            nodes.Add(new DiagramNode()
            {
                Id = "node2",
                Width = 80,
                Height = 40,
                Style = new NodeStyleNodes()
                {
                    Fill = "#F5E0F7",
                    StrokeColor = "white"
                },
                OffsetX = 150,
                OffsetY = 170,
            });
            nodes.Add(new DiagramNode()
            {
                Id = "node3",
                Width = 100,
                Height = 40,
                Style = new NodeStyleNodes()
                {
                    Fill = "#E0E5BB",
                    StrokeColor = "white"
                },
                OffsetX = 150,
                OffsetY = 240,
            });
            nodes.Add(new DiagramNode()
            {
                Shape = new { type = "Text", content = "Try Alignment Commandss(AlignRight, AlignLeft \n and AlignCenter)" },
                Constraints = NodeConstraints.PointerEvents,
                Style = new NodeStyleNodes()
                {
                    FontSize = 10,
                    Fill = "None",
                    FontFamily = "sans-serif",
                    StrokeWidth = 0
                },
                OffsetX = 150,
                OffsetY = 310,

            });
            nodes.Add(new DiagramNode()
            {
                Shape = new { type = "Text", content = "Select the below shapes" },
                Constraints = NodeConstraints.PointerEvents,
                Style = new NodeStyleNodes()
                {
                    FontSize = 10,
                    Fill = "None",
                    FontFamily = "sans-serif",
                    StrokeWidth = 0
                },
                OffsetX = 150,
                OffsetY = 380,
            });
            nodes.Add(new DiagramNode()
            {
                Id = "node4",
                Width = 40,
                Height = 60,
                Style = new NodeStyleNodes()
                {
                    Fill = "#DAEBFF",
                    StrokeColor = "white"
                },
                OffsetX = 80,
                OffsetY = 470,
            });
            nodes.Add(new DiagramNode()
            {
                Id = "node5",
                Width = 40,
                Height = 80,
                Style = new NodeStyleNodes()
                {
                    Fill = "#F5E0F7",
                    StrokeColor = "white"
                },
                OffsetX = 160,
                OffsetY = 470,
            });
            nodes.Add(new DiagramNode()
            {
                Id = "node6",
                Width = 40,
                Height = 100,
                Style = new NodeStyleNodes()
                {
                    Fill = "#E0E5BB",
                    StrokeColor = "white"
                },
                OffsetX = 240,
                OffsetY = 470,
            });
            nodes.Add(new DiagramNode()
            {
                Shape = new { type = "Text", content = "Try Alignment Commandss(AlignTop, AlignBottom \n and AlignMiddle)" },
                Constraints = NodeConstraints.PointerEvents,
                Style = new NodeStyleNodes()
                {
                    FontSize = 10,
                    Fill = "None",
                    FontFamily = "sans-serif",
                    StrokeWidth = 0
                },
                OffsetX = 150,
                OffsetY = 550,
            });
            nodes.Add(new DiagramNode()
            {
                Shape = new { type = "Text", content = "Select the below shapes" },
                Constraints = NodeConstraints.PointerEvents,
                Style = new NodeStyleNodes()
                {
                    FontSize = 10,
                    Fill = "None",
                    FontFamily = "sans-serif",
                    StrokeWidth = 0
                },
                OffsetX = 550,
                OffsetY = 40,
            });
            nodes.Add(new DiagramNode()
            {
                Id = "node7",
                Width = 80,
                Height = 40,
                Style = new NodeStyleNodes()
                {
                    Fill = "#DAEBFF",
                    StrokeColor = "white"
                },
                OffsetX = 475,
                OffsetY = 100,
            });
            nodes.Add(new DiagramNode()
            {
                Id = "node8",
                Width = 80,
                Height = 40,
                Style = new NodeStyleNodes()
                {
                    Fill = "#F5E0F7",
                    StrokeColor = "white"
                },
                OffsetX = 625,
                OffsetY = 100,
            });
            nodes.Add(new DiagramNode()
            {
                Id = "node9",
                Width = 80,
                Height = 40,
                Style = new NodeStyleNodes()
                {
                    Fill = "#E0E5BB",
                    StrokeColor = "white"
                },
                OffsetX = 595,
                OffsetY = 180,
            });
            nodes.Add(new DiagramNode()
            {
                Shape = new { type = "Text", content = "Try SpaceAcross Commands" },
                Constraints = NodeConstraints.PointerEvents,
                Style = new NodeStyleNodes()
                {
                    FontSize = 10,
                    Fill = "None",
                    FontFamily = "sans-serif",
                    StrokeWidth = 0
                },
                OffsetX = 550,
                OffsetY = 240,
            });
            nodes.Add(new DiagramNode()
            {
                Shape = new { type = "Text", content = "Select the below shapes" },
                Constraints = NodeConstraints.PointerEvents,
                Style = new NodeStyleNodes()
                {
                    FontSize = 10,
                    Fill = "None",
                    FontFamily = "sans-serif",
                    StrokeWidth = 0
                },
                OffsetX = 550,
                OffsetY = 320,
            });
            nodes.Add(new DiagramNode()
            {
                Id = "node10",
                Width = 80,
                Height = 40,
                Style = new NodeStyleNodes()
                {
                    Fill = "#DAEBFF",
                    StrokeColor = "white"
                },
                OffsetX = 475,
                OffsetY = 400,
            });
            nodes.Add(new DiagramNode()
            {
                Id = "node11",
                Width = 80,
                Height = 40,
                Style = new NodeStyleNodes()
                {
                    Fill = "#F5E0F7",
                    StrokeColor = "white"
                },
                OffsetX = 475,
                OffsetY = 500,
            });
            nodes.Add(new DiagramNode()
            {
                Id = "node12",
                Width = 80,
                Height = 40,
                Style = new NodeStyleNodes()
                {
                    Fill = "#E0E5BB",
                    StrokeColor = "white"
                },
                OffsetX = 625,
                OffsetY = 430,
            });
            nodes.Add(new DiagramNode()
            {
                Shape = new { type = "Text", content = "Try SpaceAcross Commands" },
                Constraints = NodeConstraints.PointerEvents,
                Style = new NodeStyleNodes()
                {
                    FontSize = 10,
                    Fill = "None",
                    FontFamily = "sans-serif",
                    StrokeWidth = 0
                },
                OffsetX = 550,
                OffsetY = 550,
            });
            nodes.Add(new DiagramNode()
            {
                Shape = new { type = "Text", content = "Select the below shapes" },
                Constraints = NodeConstraints.PointerEvents,
                Style = new NodeStyleNodes()
                {
                    FontSize = 10,
                    Fill = "None",
                    FontFamily = "sans-serif",
                    StrokeWidth = 0
                },
                OffsetX = 950,
                OffsetY = 40,
            });
            nodes.Add(new DiagramNode()
            {
                Id = "RightTriangle",
                Width = 100,
                Height = 100,
                Style = new NodeStyleNodes()
                {
                    Fill = "#E0E5BB",
                    StrokeColor = "white"
                },
                Shape = new { type = "Basic", shape = "RightTriangle" },
                OffsetX = 950,
                OffsetY = 120,
            });
            nodes.Add(new DiagramNode()
            {
                Shape = new { type = "Text", content = "Try Flip Commands" },
                Constraints = NodeConstraints.PointerEvents,
                Style = new NodeStyleNodes()
                {
                    FontSize = 10,
                    Fill = "None",
                    FontFamily = "sans-serif",
                    StrokeWidth = 0
                },
                OffsetX = 950,
                OffsetY = 240,
            });
            nodes.Add(new DiagramNode()
            {
                Shape = new { type = "Text", content = "Select the below shapes" },
                Constraints = NodeConstraints.PointerEvents,
                Style = new NodeStyleNodes()
                {
                    FontSize = 10,
                    Fill = "None",
                    FontFamily = "sans-serif",
                    StrokeWidth = 0
                },
                OffsetX = 950,
                OffsetY = 300,
            });
            nodes.Add(new DiagramNode()
            {
                Id = "node14",
                Width = 60,
                Height = 20,
                Style = new NodeStyleNodes()
                {
                    Fill = "#DAEBFF",
                    StrokeColor = "white"
                },
                OffsetX = 950,
                OffsetY = 350,
            });
            nodes.Add(new DiagramNode()
            {
                Id = "node15",
                Width = 80,
                Height = 40,
                Style = new NodeStyleNodes()
                {
                    Fill = "#F5E0F7",
                    StrokeColor = "white"
                },
                OffsetX = 950,
                OffsetY = 420,
            });
            nodes.Add(new DiagramNode()
            {
                Id = "node16",
                Width = 100,
                Height = 50,
                Style = new NodeStyleNodes()
                {
                    Fill = "#E0E5BB",
                    StrokeColor = "white"
                },
                OffsetX = 950,
                OffsetY = 500,
            });
            nodes.Add(new DiagramNode()
            {
                Shape = new { type = "Text", content = "Try Sizing Commands" },
                Constraints = NodeConstraints.PointerEvents,
                Style = new NodeStyleNodes()
                {
                    FontSize = 10,
                    Fill = "None",
                    FontFamily = "sans-serif",
                    StrokeWidth = 0
                },
                OffsetX = 950,
                OffsetY = 550,
            });

            List<ToolbarItem> items = new List<ToolbarItem>();
            {
                items.Add(new ToolbarItem { PrefixIcon = "e-cut e-icons", TooltipText = "Cut", Disabled = true });
                items.Add(new ToolbarItem { PrefixIcon = "e-copy e-icons", TooltipText = "Copy", Disabled = true });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-paste", TooltipText = "Paste", Disabled = true });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-undo", TooltipText = "Undo", Disabled = true });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-redo", TooltipText = "Redo", Disabled = true });
                items.Add(new ToolbarItem { Type = ItemType.Separator });
                items.Add(new ToolbarItem { PrefixIcon = "sf-icon-align-left-1", TooltipText = "Align Left", Disabled = true });
                items.Add(new ToolbarItem { PrefixIcon = "sf-icon-align-center-1", TooltipText = "Align Center", Disabled = true });
                items.Add(new ToolbarItem { PrefixIcon = "sf-icon-align-right-1", TooltipText = "Align Right", Disabled = true });
                items.Add(new ToolbarItem { PrefixIcon = "sf-icon-align-top-1", TooltipText = "Align Top", Disabled = true });
                items.Add(new ToolbarItem { PrefixIcon = "sf-icon-align-middle-1", TooltipText = "Align Middle", Disabled = true });
                items.Add(new ToolbarItem { PrefixIcon = "sf-icon-align-bottom-1", TooltipText = "Align Bottom",Disabled = true });
                items.Add(new ToolbarItem { Type = ItemType.Separator });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-transform-right", TooltipText = "Rotate Right", Disabled = true });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-transform-left", TooltipText = "Rotate Left", Disabled = true });
                items.Add(new ToolbarItem { Type = ItemType.Separator });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-flip-vertical", TooltipText = "Flip Vertical", Disabled = true });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-flip-horizontal", TooltipText = "Flip Horizontal", Disabled = true });
                items.Add(new ToolbarItem { Type = ItemType.Separator });
                items.Add(new ToolbarItem { PrefixIcon = "sf-icon-distribute-horizontal", TooltipText = "Distribute Objects Horizontally", Disabled = true });
                items.Add(new ToolbarItem { PrefixIcon = "sf-icon-distribute-vertical", TooltipText = "Distribute Objects Vertically", Disabled = true });
                items.Add(new ToolbarItem { Type = ItemType.Separator });
                items.Add(new ToolbarItem { PrefixIcon = "sf-icon-same-width", TooltipText = "Same Width", Disabled = true });
                items.Add(new ToolbarItem { PrefixIcon = "sf-icon-same-height", TooltipText = "Same Height", Disabled = true });
                items.Add(new ToolbarItem { PrefixIcon = "sf-icon-same-size", TooltipText = "Same Size", Disabled = true });


            }
            ViewData["tbItems"] = items;
            ViewData["nodes"] = nodes;
            return View();
        }
    }
}