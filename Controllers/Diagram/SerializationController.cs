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
using Syncfusion.EJ2.Diagrams;
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: Serialization
        public ActionResult Serialization()
        {
            List<DiagramNode> nodes = new List<DiagramNode>();
            nodes.Add(new DiagramNode()
            {
                Id = "Start",
                OffsetX = 150,
                OffsetY = 80,
                Width = 100,
                Height = 50,
                Style = new DiagramShapeStyle() { Fill = "#d0f0f1", StrokeColor = "#797979" },
                Annotations = new List<DiagramNodeAnnotation>() {
                new DiagramNodeAnnotation() { Content = "Start" }
                },
                Shape = new { type = "Flow", shape = "Terminator" }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "Alarm",
                OffsetX = 150,
                OffsetY = 160,
                Width = 100,
                Height = 50,
                Style = new DiagramShapeStyle() { Fill = "#fbfdc5", StrokeColor = "#797979" },
                Annotations = new List<DiagramNodeAnnotation>() {
                new DiagramNodeAnnotation() { Content = "Alarm Rings" }},
                Shape = new { type = "Flow", shape = "Process" }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "Ready",
                OffsetX = 150,
                OffsetY = 240,
                Width = 100,
                Height = 50,
                Style = new DiagramShapeStyle() { Fill = "#c5efaf", StrokeColor = "#797979" },
                Annotations = new List<DiagramNodeAnnotation>() {
                    new DiagramNodeAnnotation() { Content = "Ready to Get Up" }
                },
                Shape = new { type = "Flow", shape = "Decision" }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "Climb",
                OffsetX = 150,
                OffsetY = 330,
                Width = 100,
                Height = 50,
                Style = new DiagramShapeStyle() { Fill = "#fbfdc5", StrokeColor = "#797979" },
                Annotations = new List<DiagramNodeAnnotation>() {
                new DiagramNodeAnnotation() { Content = "Climb Out of Bed" }},
                Shape = new { type = "Flow", shape = "Process" }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "End",
                OffsetX = 150,
                OffsetY = 430,
                Width = 100,
                Height = 50,
                Style = new DiagramShapeStyle() { Fill = "#d0f0f1", StrokeColor = "#797979" },
                Annotations = new List<DiagramNodeAnnotation>() {
                new DiagramNodeAnnotation() { Content = "End" }},
                Shape = new { type = "Flow", shape = "Terminator" }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "Relay",
                OffsetX = 350,
                OffsetY = 160,
                Width = 100,
                Height = 50,
                Style = new DiagramShapeStyle() { Fill = "#f8eee5", StrokeColor = "#797979" },
                Annotations = new List<DiagramNodeAnnotation>() {
                new DiagramNodeAnnotation() { Content = "Relay" }},
                Shape = new { type = "Flow", shape = "Delay" }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "Hit",
                OffsetX = 350,
                OffsetY = 240,
                Width = 100,
                Height = 50,
                Style = new DiagramShapeStyle() { Fill = "#fbfdc5", StrokeColor = "#797979" },
                Annotations = new List<DiagramNodeAnnotation>() {
                new DiagramNodeAnnotation() { Content = "Hit Snooze Button", Margin = new DiagramMargin() { Left = 10, Right = 10, Bottom = 10, Top = 10 } }},
                Shape = new { type = "Flow", shape = "Process" }
            });

            List<DiagramConnector> connectors = new List<DiagramConnector>();
            connectors.Add(new DiagramConnector() { Id = "connector1", SourceID = "Start", TargetID = "Alarm" });
            connectors.Add(new DiagramConnector() { Id = "connector2", SourceID = "Alarm", TargetID = "Ready" });
            connectors.Add(new DiagramConnector() { Id = "connector3", SourceID = "Ready", TargetID = "Climb" });
            connectors.Add(new DiagramConnector() { Id = "connector4", SourceID = "Climb", TargetID = "End" });
            connectors.Add(new DiagramConnector() { Id = "connector5", SourceID = "Ready", TargetID = "Hit" });
            connectors.Add(new DiagramConnector() { Id = "connector6", SourceID = "Hit", TargetID = "Relay" });
            connectors.Add(new DiagramConnector() { Id = "connector7", SourceID = "Relay", TargetID = "Alarm" });

            ViewData["nodes"] = nodes;
            ViewData["connectors"] = connectors;

            List<DiagramNode> flowShapes = new List<DiagramNode>();
            flowShapes.Add(new DiagramNode() { Id = "Terminator", Shape = new { type = "Flow", shape = "Terminator" } });
            flowShapes.Add(new DiagramNode() { Id = "Process", Shape = new { type = "Flow", shape = "Process" } });
            flowShapes.Add(new DiagramNode() { Id = "Decision", Shape = new { type = "Flow", shape = "Decision" } });
            flowShapes.Add(new DiagramNode() { Id = "Document", Shape = new { type = "Flow", shape = "Document" } });
            flowShapes.Add(new DiagramNode() { Id = "PreDefinedProcess", Shape = new { type = "Flow", shape = "PreDefinedProcess" } });
            flowShapes.Add(new DiagramNode() { Id = "PaperTap", Shape = new { type = "Flow", shape = "PaperTap" } });
            flowShapes.Add(new DiagramNode() { Id = "DirectData", Shape = new { type = "Flow", shape = "DirectData" } });
            flowShapes.Add(new DiagramNode() { Id = "SequentialData", Shape = new { type = "Flow", shape = "SequentialData" } });
            flowShapes.Add(new DiagramNode() { Id = "Sort", Shape = new { type = "Flow", shape = "Sort" } });
            flowShapes.Add(new DiagramNode() { Id = "MultiDocument", Shape = new { type = "Flow", shape = "MultiDocument" } });
            flowShapes.Add(new DiagramNode() { Id = "Collate", Shape = new { type = "Flow", shape = "Collate" } });
            flowShapes.Add(new DiagramNode() { Id = "SummingJunction", Shape = new { type = "Flow", shape = "SummingJunction" } });
            flowShapes.Add(new DiagramNode() { Id = "Or", Shape = new { type = "Flow", shape = "Or" } });
            flowShapes.Add(new DiagramNode() { Id = "InternalStorage", Shape = new { type = "Flow", shape = "InternalStorage" } });
            flowShapes.Add(new DiagramNode() { Id = "Extract", Shape = new { type = "Flow", shape = "Extract" } });
            flowShapes.Add(new DiagramNode() { Id = "ManualOperation", Shape = new { type = "Flow", shape = "ManualOperation" } });
            flowShapes.Add(new DiagramNode() { Id = "Merge", Shape = new { type = "Flow", shape = "Merge" } });
            flowShapes.Add(new DiagramNode() { Id = "OffPageReference", Shape = new { type = "Flow", shape = "OffPageReference" } });
            flowShapes.Add(new DiagramNode() { Id = "SequentialAccessStorage", Shape = new { type = "Flow", shape = "SequentialAccessStorage" } });
            flowShapes.Add(new DiagramNode() { Id = "Annotation", Shape = new { type = "Flow", shape = "Annotation" } });
            flowShapes.Add(new DiagramNode() { Id = "Annotation2", Shape = new { type = "Flow", shape = "Annotation2" } });
            flowShapes.Add(new DiagramNode() { Id = "Data", Shape = new { type = "Flow", shape = "Data" } });
            flowShapes.Add(new DiagramNode() { Id = "Card", Shape = new { type = "Flow", shape = "Card" } });
            flowShapes.Add(new DiagramNode() { Id = "Delay", Shape = new { type = "Flow", shape = "Delay" } });


            List<DiagramConnector> paletteConnectors = new List<DiagramConnector>();
            paletteConnectors.Add(new DiagramConnector()
            {
                Id = "Link1",
                Type = Segments.Orthogonal,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.Arrow, Style = new DiagramShapeStyle() { StrokeColor = "#757575", Fill = "#757575" } },
                Style = new DiagramStrokeStyle() { StrokeWidth = 2, StrokeColor = "#757575" }
            });
            paletteConnectors.Add(new DiagramConnector()
            {
                Id = "Link2",
                Type = Segments.Orthogonal,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None },
                Style = new DiagramStrokeStyle() { StrokeWidth = 2, StrokeColor = "#757575" }
            });
            paletteConnectors.Add(new DiagramConnector()
            {
                Id = "Link3",
                Type = Segments.Straight,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.Arrow, Style = new DiagramShapeStyle() { StrokeColor = "#757575", Fill = "#757575" } },
                Style = new DiagramStrokeStyle() { StrokeWidth = 2, StrokeColor = "#757575" }
            });
            paletteConnectors.Add(new DiagramConnector()
            {
                Id = "Link4",
                Type = Segments.Straight,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None },
                Style = new DiagramStrokeStyle() { StrokeWidth = 2, StrokeColor = "#757575" }
            });
            paletteConnectors.Add(new DiagramConnector()
            {
                Id = "Link5",
                Type = Segments.Bezier,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None },
                Style = new DiagramStrokeStyle() { StrokeWidth = 2, StrokeColor = "#757575" }
            });

            List<SymbolPalettePalette> palettes = new List<SymbolPalettePalette>();
            palettes.Add(new SymbolPalettePalette() { Id = "flow", Expanded = true, Symbols = flowShapes, IconCss = "shapes", Title = "Flow Shapes" });
            palettes.Add(new SymbolPalettePalette() { Id = "connectors", Expanded = true, Symbols = paletteConnectors, IconCss = "shapes", Title = "Connectors" });

            ViewData["Palette"] = palettes;

            ViewData["Spconnectors"] = paletteConnectors;

            double[] intervals = { 1, 9, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75 };
            DiagramGridlines grIdLines = new DiagramGridlines()
            { LineColor = "#e0e0e0", LineIntervals = intervals };
            ViewData["gridLines"] = grIdLines;

            DiagramMargin margin = new DiagramMargin() { Left = 15, Right = 15, Bottom = 15, Top = 15 };
            ViewData["margin"] = margin;

            List<ToolbarItem> items = new List<ToolbarItem>();
            {
                items.Add(new ToolbarItem { PrefixIcon = "e-ddb-icons e-new",Text = "New", TooltipText = "New"});
                items.Add(new ToolbarItem { Type = ItemType.Separator });
                items.Add(new ToolbarItem { PrefixIcon = "e-diagram-icons e-diagram-save", Text = "Save", TooltipText = "Save"});
                items.Add(new ToolbarItem { Type = ItemType.Separator });
                items.Add(new ToolbarItem { PrefixIcon = "e-ddb-icons e-open", Text = "Load", TooltipText = "Load"});
            }
            ViewData["tbItems"] = items;
            return View();
        }
    }
}