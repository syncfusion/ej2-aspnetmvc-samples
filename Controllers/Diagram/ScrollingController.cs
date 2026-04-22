#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Diagrams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: Scrolling
        public ActionResult Scrolling()
        {
            List<Syncfusion.EJ2.Diagrams.DiagramNode> basicShapes = new List<Syncfusion.EJ2.Diagrams.DiagramNode>();
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Rectangle", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Rectangle } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Ellipse", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Ellipse } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Triangle", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Triangle } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Plus", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Plus } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Star", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Star } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Pentagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Pentagon } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Heptagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Heptagon } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Octagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Octagon } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Trapezoid", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Trapezoid } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Decagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Decagon } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "RightTriangle", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.RightTriangle } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Parallelogram", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Parallelogram } });
            ViewData["BasicShapes"] = basicShapes;

            List<Syncfusion.EJ2.Diagrams.DiagramNode> flowShapes = new List<Syncfusion.EJ2.Diagrams.DiagramNode>();
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

            List<DiagramConnector> SymbolPaletteConnectors = new List<DiagramConnector>();
            SymbolPaletteConnectors.Add(new DiagramConnector()
            {
                Id = "Link1",
                Type = Segments.Orthogonal,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.Arrow, Style = new DiagramShapeStyle() { StrokeColor = "#757575", Fill = "#757575" } },
                Style = new DiagramStrokeStyle() { StrokeWidth = 2, StrokeColor = "#757575" }
            });
            SymbolPaletteConnectors.Add(new DiagramConnector()
            {
                Id = "Link2",
                Type = Segments.Orthogonal,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None },
                Style = new DiagramStrokeStyle() { StrokeWidth = 2, StrokeColor = "#757575" }
            });
            SymbolPaletteConnectors.Add(new DiagramConnector()
            {
                Id = "Link3",
                Type = Segments.Straight,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.Arrow, Style = new DiagramShapeStyle() { StrokeColor = "#757575", Fill = "#757575" } },
                Style = new DiagramStrokeStyle() { StrokeWidth = 2, StrokeColor = "#757575" }
            });
            SymbolPaletteConnectors.Add(new DiagramConnector()
            {
                Id = "Link4",
                Type = Segments.Straight,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None },
                Style = new DiagramStrokeStyle() { StrokeWidth = 2, StrokeColor = "#757575" }
            });
            SymbolPaletteConnectors.Add(new DiagramConnector()
            {
                Id = "Link5",
                Type = Segments.Bezier,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None },
                Style = new DiagramStrokeStyle() { StrokeWidth = 2, StrokeColor = "#757575" }
            });


            List<SymbolPalettePalette> palettes = new List<SymbolPalettePalette>();
            palettes.Add(new SymbolPalettePalette() { Id = "basic", Expanded = true, Symbols = basicShapes, IconCss = "shapes", Title = "Basic Shapes" });
            palettes.Add(new SymbolPalettePalette() { Id = "flow", Expanded = false, Symbols = flowShapes, IconCss = "shapes", Title = "Flow Shapes" });
            palettes.Add(new SymbolPalettePalette() { Id = "connectors", Expanded = false, Symbols = SymbolPaletteConnectors, IconCss = "shapes", Title = "Connectors" });
            ViewData["palettes"] = palettes;
            Models.DropDownModel dropDownModel = new Models.DropDownModel();
            ViewData["data"] = dropDownModel.scrollFormats();
            return View();
        }
    }
}