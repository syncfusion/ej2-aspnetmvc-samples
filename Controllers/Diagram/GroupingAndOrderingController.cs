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
        // GET: GroupingAndOrdering
        public ActionResult GroupingAndOrdering()
        {
            List<Syncfusion.EJ2.Diagrams.DiagramNode> basicShapes = new List<Syncfusion.EJ2.Diagrams.DiagramNode>();
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Rectangle", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Rectangle }, Style = new DiagramStrokeStyle { StrokeWidth = 2 } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Ellipse", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Ellipse }, Style = new DiagramStrokeStyle { StrokeWidth = 2 } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Hexagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Hexagon }, Style = new DiagramStrokeStyle { StrokeWidth = 2 } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Parallelogram", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Parallelogram }, Style = new DiagramStrokeStyle { StrokeWidth = 2 } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Triangle", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Triangle }, Style = new DiagramStrokeStyle { StrokeWidth = 2 } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Plus", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Plus }, Style = new DiagramStrokeStyle { StrokeWidth = 2 } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Star", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Star }, Style = new DiagramStrokeStyle { StrokeWidth = 2 } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Pentagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Pentagon }, Style = new DiagramStrokeStyle { StrokeWidth = 2 } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Heptagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Heptagon }, Style = new DiagramStrokeStyle { StrokeWidth = 2 } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Octagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Octagon }, Style = new DiagramStrokeStyle { StrokeWidth = 2 } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Trapezoid", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Trapezoid }, Style = new DiagramStrokeStyle { StrokeWidth = 2 } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Decagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Decagon }, Style = new DiagramStrokeStyle { StrokeWidth = 2 } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "RightTriangle", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.RightTriangle }, Style = new DiagramStrokeStyle { StrokeWidth = 2 } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Cylinder", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Cylinder }, Style = new DiagramStrokeStyle { StrokeWidth = 2 } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Diamond", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Diamond }, Style = new DiagramStrokeStyle { StrokeWidth = 2 } });
            ViewData["BasicShapes"] = basicShapes;

            List<SymbolPalettePalette> palettes = new List<SymbolPalettePalette>();
            palettes.Add(new SymbolPalettePalette() { Id = "basic", Expanded = true, Symbols = basicShapes, IconCss = "shapes", Title = "Basic Shapes" });
            ViewData["palettes"] = palettes;

            List<DiagramNode> nodes = new List<DiagramNode>();
            List<DiagramNodeAnnotation> Node1 = new List<DiagramNodeAnnotation>();
            Node1.Add(new DiagramNodeAnnotation() { Content = "Decision" });
            List<DiagramNodeAnnotation> Node2 = new List<DiagramNodeAnnotation>();
            Node2.Add(new DiagramNodeAnnotation() { Content = "Start/Stop" });
            List<DiagramNodeAnnotation> Node3 = new List<DiagramNodeAnnotation>();
            Node3.Add(new DiagramNodeAnnotation() { Content = "Group 1" });
            List<DiagramNodeAnnotation> Node4 = new List<DiagramNodeAnnotation>();
            Node4.Add(new DiagramNodeAnnotation() { Content = "Process" });
            nodes.Add(new DiagramNode()
            {
                Id = "Diamond",
                OffsetY = 250,
                OffsetX = 350,
                Width = 100,
                Height = 100,
                Annotations = Node1,
                Shape = new { type = "Basic", shape = "Diamond" }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "ellipse",
                OffsetY = 250,
                OffsetX = 150,
                Width = 100,
                Height = 60,
                Annotations = Node2,
                Shape = new { type = "Basic", shape = "Ellipse" }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "node1",
                OffsetY = 100,
                OffsetX = 150,
                Width = 100,
                Height = 55,
                Shape = new { type = "Basic", shape = "Rectangle" }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "node2",
                OffsetY = 100,
                OffsetX = 350,
                Width = 90,
                Height = 55,
                Shape = new { type = "Basic", shape = "Rectangle", cornerRadius = 5 }
            });
            string[] children = { "node1", "node2" };

            nodes.Add(new DiagramNode()
            {
                Id = "group",
                Children = children,
                //Padding = {left= 10},
                //Padding={ left= 10,right= 10,top= 10,bottom= 10},
                Annotations = Node3,
            });
            nodes.Add(new DiagramNode()
            {
                Id = "rectangle",
                OffsetY = 400,
                OffsetX = 150,
                Width = 100,
                Height = 60,
                Annotations = Node4,
                Shape = new { type = "Basic", shape = "Rectangle" }
            });
            ViewData["nodes"] = nodes;

            List<DiagramUserHandle> handle = new List<DiagramUserHandle>();
            handle.Add(new DiagramUserHandle()
            {
                Name = "Clone",
                PathData = "M0,2.4879999 L0.986,2.4879999 0.986,9.0139999 6.9950027,9.0139999 6.9950027,10 0.986,10 C0.70400238,10 0.47000122,9.9060001 0.28100207,9.7180004 0.09400177,9.5300007 0,9.2959995 0,9.0139999 z M3.0050011,0 L9.0140038,0 C9.2960014,0 9.5300026,0.093999863 9.7190018,0.28199956 9.906002,0.47000027 10,0.70399952 10,0.986 L10,6.9949989 C10,7.2770004 9.906002,7.5160007 9.7190018,7.7110004 9.5300026,7.9069996 9.2960014,8.0049992 9.0140038,8.0049992 L3.0050011,8.0049992 C2.7070007,8.0049992 2.4650002,7.9069996 2.2770004,7.7110004 2.0890007,7.5160007 1.9950027,7.2770004 1.9950027,6.9949989 L1.9950027,0.986 C1.9950027,0.70399952 2.0890007,0.47000027 2.2770004,0.28199956 2.4650002,0.093999863 2.7070007,0 3.0050011,0 z",
                Visible = true,
                Offset = 1,
                Side = Side.Bottom,
                Margin = new DiagramMargin() { Left = 0, Right = 0, Top = 0, Bottom = 0 }
            });
            handle.Add(new DiagramUserHandle()
            {
                Name = "Delete",
                PathData = "M0.54700077,2.2130003 L7.2129992,2.2130003 7.2129992,8.8800011 C7.2129992,9.1920013 7.1049975,9.4570007 6.8879985,9.6739998 6.6709994,9.8910007 6.406,10 6.0939997,10 L1.6659999,10 C1.3539997,10 1.0890004,9.8910007 0.87200136,9.6739998 0.65500242,9.4570007 0.54700071,9.1920013 0.54700077,8.8800011 z M2.4999992,0 L5.2600006,0 5.8329986,0.54600048 7.7599996,0.54600048 7.7599996,1.6660004 0,1.6660004 0,0.54600048 1.9270014,0.54600048 z",
                Visible = true,
                Offset = 0,
                Side = Side.Bottom,
                Margin = new DiagramMargin() { Left = 0, Right = 0, Top = 0, Bottom = 0 }
            });
            handle.Add(new DiagramUserHandle()
            {
                Name = "Draw",
                PathData = "M3.9730001,0 L8.9730001,5.0000007 3.9730001,10.000001 3.9730001,7.0090005 0,7.0090005 0,2.9910006 3.9730001,2.9910006 z",
                Visible = true,
                Offset = 0.5,
                Side = Side.Right,
                Margin = new DiagramMargin() { Left = 0, Right = 0, Top = 0, Bottom = 0 }
            });

            DiagramSelector userHandle = new DiagramSelector();
            userHandle.Constraints = SelectorConstraints.UserHandle;
            userHandle.UserHandles = handle;
            ViewData["selectedItems"] = userHandle;

            List<ToolbarItem> items = new List<ToolbarItem>();
            {
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-group-1", TooltipText = "Group", Disabled = true });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-ungroup-1", TooltipText = "UnGroup", Disabled = true});
                items.Add(new ToolbarItem { Type = ItemType.Separator });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-bring-forward", TooltipText = "Bring Forward", Disabled = true });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-bring-to-front", TooltipText = "Bring To Front", Disabled = true });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-send-backward", TooltipText = "Send Backward", Disabled = true });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-send-to-back", TooltipText = "Send To Back", Disabled = true });
                items.Add(new ToolbarItem { Type = ItemType.Separator });
                items.Add(new ToolbarItem { Template = "#fontfamily", Type = ItemType.Input, TooltipText = "Font Family" });
                items.Add(new ToolbarItem { Type = ItemType.Separator });
                items.Add(new ToolbarItem { Template = "#fontSize", Type = ItemType.Input, TooltipText = "Font Size" });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-bold", TooltipText = "Bold", Disabled = true });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-italic", TooltipText = "Italic", Disabled = true });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-underline", TooltipText = "Underline", Disabled = true });
                items.Add(new ToolbarItem { Template = "#fontColors", Type = ItemType.Input, TooltipText = "Font Color" });

            }
            ViewData["tbItems"] = items;

            List<ContextMenuItem> fontFamilyItems = new List<ContextMenuItem>();
            {
                fontFamilyItems.Add(new ContextMenuItem { Text = "Arial"});
                fontFamilyItems.Add(new ContextMenuItem { Text = "Aharoni" });
                fontFamilyItems.Add(new ContextMenuItem { Text = "Bell MT" });
                fontFamilyItems.Add(new ContextMenuItem { Text = "Fantasy" });
                fontFamilyItems.Add(new ContextMenuItem { Text = "Segoe UI"});
                fontFamilyItems.Add(new ContextMenuItem { Text = "Times New Roman"});
                fontFamilyItems.Add(new ContextMenuItem { Text = "Verdana"});

            }
            ViewData["fontFamilyItems"] = fontFamilyItems;
            return View();
        }
        public class Node2 : DiagramNode
        {
            public string text;
        }
    }
}