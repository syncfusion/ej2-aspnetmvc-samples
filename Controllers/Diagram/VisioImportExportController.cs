#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: VisioImportExport
        public ActionResult VisioImportExport()
        {
            // Define the nodes using helper method
            var nodes = new List<DiagramNode>
            {
                CreateNode("start", "Start", 80, FlowShapes.Terminator),
                CreateNode("draft", "Draft", 180, FlowShapes.Process, 400, 100, 50, new List<DiagramPort>
                {
                    new DiagramPort { Id = "rightport", Offset = new DiagramPoint { X = 1, Y = 0.5 } }
                }),
                CreateNode("approvedDecision", "Approved?", 280, FlowShapes.Decision, 400, 120, 60),
                CreateNode("revise", "Revise", 280, FlowShapes.Process, 600, 100, 50, new List<DiagramPort>
                {
                    new DiagramPort { Id = "rightport", Offset = new DiagramPoint { X = 1, Y = 0.5 } }
                }),
                CreateNode("copyedit", "Copyedit", 400),
                CreateNode("proof", "Proof", 500),
                CreateNode("finalrevise", "Revise", 600),
                CreateNode("finalize", "Finalize", 700),
                CreateNode("publish", "Publish", 800, FlowShapes.Terminator)
            };

            // Define the connectors using helper method
            var connectors = new List<DiagramConnector>
            {
                CreateConnector("connector1", "start", "draft"),
                CreateConnector("connector2", "draft", "approvedDecision"),
                CreateConnector("connector3", "approvedDecision", "copyedit", "Yes"),
                CreateConnector("connector4", "approvedDecision", "revise", "No"),
                CreateConnector("connector5", "revise", "draft", null, "rightport", "rightport"),
                CreateConnector("connector6", "copyedit", "proof"),
                CreateConnector("connector7", "proof", "finalrevise"),
                CreateConnector("connector8", "finalrevise", "finalize"),
                CreateConnector("connector9", "finalize", "publish"),
            };

            ViewData["nodes"] = nodes;
            ViewData["connectors"] = connectors;

            List<DiagramNode> flowShapes = new List<DiagramNode>
            {
                new DiagramNode() { Id = "Process", Shape = new DiagramFlowShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Flow, Shape = FlowShapes.Process } },
                new DiagramNode() { Id = "Decision", Shape = new DiagramFlowShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Flow, Shape = FlowShapes.Decision } },
                new DiagramNode() { Id = "Document", Shape = new DiagramFlowShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Flow, Shape = FlowShapes.Document } },
                new DiagramNode() { Id = "Terminator", Shape = new DiagramFlowShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Flow, Shape = FlowShapes.Terminator } },
                new DiagramNode() { Id = "PredefinedProcess", Shape = new DiagramFlowShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Flow, Shape = FlowShapes.PreDefinedProcess } },
                new DiagramNode() { Id = "Data", Shape = new DiagramFlowShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Flow, Shape = FlowShapes.Data } },
                new DiagramNode() { Id = "DirectData", Shape = new DiagramFlowShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Flow, Shape = FlowShapes.DirectData } },
                new DiagramNode() { Id = "InternalStorage", Shape = new DiagramFlowShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Flow, Shape = FlowShapes.InternalStorage } },
                new DiagramNode() { Id = "ManualInput", Shape = new DiagramFlowShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Flow, Shape = FlowShapes.ManualInput } },
                new DiagramNode() { Id = "ManualOperation", Shape = new DiagramFlowShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Flow, Shape = FlowShapes.ManualOperation } }
            };

            List<DiagramNode> basicShapes = new List<DiagramNode>
            {
                new DiagramNode() { Id = "Rectangle", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Rectangle } },
                new DiagramNode() { Id = "Ellipse", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Ellipse } },
                new DiagramNode() { Id = "Hexagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Hexagon } },
                new DiagramNode() { Id = "Parallelogram", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Parallelogram } },
                new DiagramNode() { Id = "Pentagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Pentagon } },
                new DiagramNode() { Id = "Heptagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Heptagon } },
                new DiagramNode() { Id = "Triangle", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Triangle } },
                new DiagramNode() { Id = "Star", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Star } },
                new DiagramNode() { Id = "Plus", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Plus } },
            };

            List<DiagramConnector> connectorsSymbols = new List<DiagramConnector>
            {
                new DiagramConnector() { Id = "link1", Type = Segments.Orthogonal, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new DiagramDecorator() { Shape = DecoratorShapes.Arrow, Style = new DiagramShapeStyle() { StrokeColor = "#757575", Fill = "#757575" } } },
                new DiagramConnector() { Id = "link2", Type = Segments.Orthogonal, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new DiagramDecorator() { Shape = DecoratorShapes.None } },
                new DiagramConnector() { Id = "link3", Type = Segments.Straight, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new DiagramDecorator() { Shape = DecoratorShapes.Arrow, Style = new DiagramShapeStyle() { StrokeColor = "#757575", Fill = "#757575" } } },
                new DiagramConnector() { Id = "link4", Type = Segments.Straight, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new DiagramDecorator() { Shape = DecoratorShapes.None } },
                new DiagramConnector() { Id = "link5", Type = Segments.Bezier, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new DiagramDecorator() { Shape = DecoratorShapes.None } }
            };

            List<SymbolPalettePalette> palettes = new List<SymbolPalettePalette>
            {
                new SymbolPalettePalette() { Id = "flow", Expanded = true, Symbols = flowShapes, IconCss = "e-ddb-icons e-flow", Title = "Flow Shapes" },
                new SymbolPalettePalette() { Id = "basic", Expanded = false, Symbols = basicShapes, IconCss = "e-ddb-icons e-basic", Title = "Basic Shapes" },
                new SymbolPalettePalette() { Id = "connectors", Expanded = false, Symbols = connectorsSymbols, IconCss = "e-ddb-icons e-connector", Title = "Connectors" }
            };

            ViewData["palettes"] = palettes;

            List<ToolbarItem> items = new List<ToolbarItem>();
            {
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-circle-add", TooltipText = "New Diagram", Id = "New_Diagram" });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-import", TooltipText = "Import Visio (.vsdx)", Id = "Import" });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-export", TooltipText = "Export as Visio (.vsdx)", Id = "Export" });
                items.Add(new ToolbarItem { Type = ItemType.Separator });
                items.Add(new ToolbarItem { Template = "#conTypeBtn", Type = ItemType.Input, TooltipText = "Draw Connectors", CssClass = "tb-item-middle", Id = "Draw_connectors" });
                items.Add(new ToolbarItem { Template = "#shapesBtn", Type = ItemType.Input, TooltipText = "Draw Shapes", CssClass = "tb-item-middle", Id = "Draw_shapes" });
                items.Add(new ToolbarItem { Type = ItemType.Separator });
                items.Add(new ToolbarItem { PrefixIcon = "e-cut e-icons", TooltipText = "Cut", Disabled = true, Id = "Cut" });
                items.Add(new ToolbarItem { PrefixIcon = "e-copy e-icons", TooltipText = "Copy", Disabled = true, Id = "Copy" });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-paste", TooltipText = "Paste", Disabled = true, Id = "Paste" });
                items.Add(new ToolbarItem { Type = ItemType.Separator });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-undo", TooltipText = "Undo", Disabled = true, Id = "Undo" });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-redo", TooltipText = "Redo", Disabled = true, Id = "Redo" });
                items.Add(new ToolbarItem { Type = ItemType.Separator });
                items.Add(new ToolbarItem { PrefixIcon = "e-trash e-icons", TooltipText = "Delete", Disabled = true, CssClass = "tb-item-middle tb-item-lock-category", Id = "Delete" });
            }
            ViewData["tbItems"] = items;
            List<ContextMenuItem> conTypeItems = new List<ContextMenuItem>();
            {
                conTypeItems.Add(new ContextMenuItem { Text = "Straight", IconCss = "e-icons e-line" });
                conTypeItems.Add(new ContextMenuItem { Text = "Orthogonal", IconCss = "sf-icon-orthogonal" });
                conTypeItems.Add(new ContextMenuItem { Text = "Bezier", IconCss = "sf-icon-bezier" });
            }
            ViewData["conTypeItems"] = conTypeItems;
            List<ContextMenuItem> shapesItems = new List<ContextMenuItem>();
            {
                shapesItems.Add(new ContextMenuItem { Text = "Rectangle", IconCss = "e-rectangle e-icons" });
                shapesItems.Add(new ContextMenuItem { Text = "Ellipse", IconCss = " e-circle e-icons" });
            }
            ViewData["shapesItems"] = shapesItems;

            return View();
        }

        // Helper method to create a process node
        public static DiagramNode CreateNode(
            string id,
            string content,
            double offsetY,
            FlowShapes shape = FlowShapes.Process,
            double offsetX = 400,
            double width = 100,
            double height = 50,
            List<DiagramPort> ports = null)
        {
            var node = new DiagramNode
            {
                Id = id,
                Shape = new DiagramFlowShape
                {
                    Type = Syncfusion.EJ2.Diagrams.Shapes.Flow,
                    Shape = shape
                },
                Style = new DiagramShapeStyle
                {
                    Fill = "#357BD2",
                    StrokeColor = "white"
                },
                Annotations = new List<DiagramNodeAnnotation>
                {
                    new DiagramNodeAnnotation
                    {
                        Content = content,
                        Style = new DiagramTextStyle
                        {
                            Color = "white"
                        }
                    }
                },
                OffsetX = offsetX,
                OffsetY = offsetY,
                Width = width,
                Height = height,
            };
            if (ports != null)
            {
                node.Ports = ports;
            }
            return node;
        }

        // Helper method to create a connector
        public static DiagramConnector CreateConnector(
            string id,
            string sourceID,
            string targetID,
            string annotation = "",
            string sourcePortID = "",
            string targetPortID = "")
        {
            var connector = new DiagramConnector
            {
                Id = id,
                SourceID = sourceID,
                TargetID = targetID,
                Type = Segments.Orthogonal
            };

            if (!string.IsNullOrEmpty(annotation))
            {
                connector.Annotations = new List<DiagramConnectorAnnotation>
                {
                    new DiagramConnectorAnnotation
                    {
                        Content = annotation,
                        Alignment = annotation == "Yes" ? AnnotationAlignment.After : AnnotationAlignment.Before,
                        Displacement = annotation == "Yes"
                            ? new DiagramPoint { X = 5, Y = 0 }
                            : new DiagramPoint { X = 5, Y = 5 }
                    }
                };
            }

            if (!string.IsNullOrEmpty(sourcePortID))
                connector.SourcePortID = sourcePortID;

            if (!string.IsNullOrEmpty(targetPortID))
                connector.TargetPortID = targetPortID;

            return connector;
        }
    }
}
