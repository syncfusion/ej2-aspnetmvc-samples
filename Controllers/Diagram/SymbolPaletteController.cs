#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
        // GET: SymbolPalette
        public ActionResult SymbolPalette()
        {
            List<DiagramNode> flowShapes = new List<DiagramNode>();
            flowShapes.Add(new DiagramNode() { Id = "Terminator", Shape = new { type = "Flow", shape = "Terminator" } });
            flowShapes.Add(new DiagramNode() { Id = "Terminator", Shape = new { type = "Flow", shape = "Terminator" } });
            flowShapes.Add(new DiagramNode() { Id = "Process", Shape = new { type = "Flow", shape = "Process" } });
            flowShapes.Add(new DiagramNode() { Id = "Decision", Shape = new { type = "Flow", shape = "Decision" } });
            flowShapes.Add(new DiagramNode() { Id = "Document", Shape = new { type = "Flow", shape = "Document" } });
            flowShapes.Add(new DiagramNode() { Id = "PreDefinedProcess", Shape = new { type = "Flow", shape = "PreDefinedProcess" } });
            flowShapes.Add(new DiagramNode() { Id = "PaperTap", Shape = new { type = "Flow", shape = "PaperTap" } });
            flowShapes.Add(new DiagramNode() { Id = "DirectData", Shape = new { type = "Flow", shape = "DirectData" } });
            flowShapes.Add(new DiagramNode() { Id = "SequentialData", Shape = new { type = "Flow", shape = "SequentialData" } });


            List<Syncfusion.EJ2.Diagrams.DiagramNode> basicShapes = new List<Syncfusion.EJ2.Diagrams.DiagramNode>();
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Rectangle", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Rectangle } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Ellipse", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Ellipse } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Parallelogram", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Parallelogram } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Triangle", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Triangle } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Hexagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Hexagon } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Pentagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Pentagon } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Cylinder", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Cylinder } });
            basicShapes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "Star", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Star } });
            ViewBag.BasicShapes = basicShapes;

            List<DiagramConnector> connectors = new List<DiagramConnector>();
            connectors.Add(new DiagramConnector() { Id = "link1", Type = Segments.Orthogonal, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.Arrow, Style = new DiagramShapeStyle() { StrokeColor = "#757575", Fill = "#757575" } }, Style = new DiagramStrokeStyle() { StrokeWidth = 2, StrokeColor = "#757575" } });
            connectors.Add(new DiagramConnector() { Id = "link3", Type = Segments.Orthogonal, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None }, Style = new DiagramStrokeStyle() { StrokeWidth = 2, StrokeColor = "#757575" } });
            connectors.Add(new DiagramConnector() { Id = "Link21", Type = Segments.Straight, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.Arrow, Style = new DiagramShapeStyle() { StrokeColor = "#757575", Fill = "#757575" } }, Style = new DiagramStrokeStyle() { StrokeWidth = 2, StrokeColor = "#757575" } });
            connectors.Add(new DiagramConnector() { Id = "link23", Type = Segments.Straight, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None }, Style = new DiagramStrokeStyle() { StrokeWidth = 2, StrokeColor = "#757575" } });
            connectors.Add(new DiagramConnector() { Id = "link33", Type = Segments.Bezier, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None }, Style = new DiagramStrokeStyle() { StrokeWidth = 2, StrokeColor = "#757575" } });
            ViewBag.Connectors = connectors;

            List<SymbolPalettePalette> palettes = new List<SymbolPalettePalette>();
            palettes.Add(new SymbolPalettePalette() { Id = "flow", Expanded = true, Symbols = flowShapes, IconCss = "e-ddb-icons e-flow", Title = "Flow Shapes" });
            palettes.Add(new SymbolPalettePalette() { Id = "basic", Expanded = true, Symbols = basicShapes, IconCss = "e-ddb-icons e-basic", Title = "Basic Shapes" });
            palettes.Add(new SymbolPalettePalette() { Id = "connectors", Expanded = true, Symbols = connectors, IconCss = "e-ddb-icons e-connector", Title = "Connectors" });
            ViewBag.palettes = palettes;

            List<ExpandOptions> expand = new List<ExpandOptions>();
            expand.Add(new ExpandOptions() { text = "Single", value = "single"});
            expand.Add(new ExpandOptions() {text = "Multiple", value = "multiple" });

            ViewBag.expand = expand;

            DiagramMargin margin = new DiagramMargin() { Left = 15, Bottom = 15, Right = 15, Top = 15 };
            ViewBag.margin = margin;

            return View();
        }
    }

    public class ExpandOptions
    {
        public string text;
        public string value;
    }
}