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

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: Annotations
        public ActionResult Annotations()
        {
            List<Syncfusion.EJ2.Diagrams.DiagramNode> nodes = new List<Syncfusion.EJ2.Diagrams.DiagramNode>();
            List<DiagramNodeAnnotation> Node1 = new List<DiagramNodeAnnotation>();
            Node1.Add(new DiagramNodeAnnotation() { Content = "Industry Competitors" });
            List<DiagramNodeAnnotation> Node2 = new List<DiagramNodeAnnotation>();
            Node2.Add(new DiagramNodeAnnotation() { Content = "Potential Entrants" });
            List<DiagramNodeAnnotation> Node3 = new List<DiagramNodeAnnotation>();
            Node3.Add(new DiagramNodeAnnotation() { Content = "Suppliers" });
            List<DiagramNodeAnnotation> Node4 = new List<DiagramNodeAnnotation>();
            Node4.Add(new DiagramNodeAnnotation() { Content = "Substitutes" });
            List<DiagramNodeAnnotation> Node5 = new List<DiagramNodeAnnotation>();
            Node5.Add(new DiagramNodeAnnotation() { Content = "Buyers" });

            nodes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "industry",  OffsetX = 280, OffsetY = 250 , Annotations = Node1 });
            nodes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "potential", OffsetX = 280, OffsetY = 110, Annotations = Node2 });
            nodes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "suplier", OffsetX = 90, OffsetY = 250 , Annotations = Node3 });
            nodes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "substitutes", OffsetX = 280, OffsetY = 390, Annotations = Node4 });
            nodes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode() { Id = "buyers", OffsetX = 470, OffsetY = 250, Annotations = Node5 });
            ViewData["nodes"] = nodes;

            List<DiagramConnector> connectors = new List<DiagramConnector>();
            connectors.Add(new DiagramConnector() { Id = "connector1", SourceID = "potential", TargetID = "industry", Type = Segments.Orthogonal});
            connectors.Add(new DiagramConnector() { Id = "connector2", SourceID = "suplier", TargetID = "industry", Type = Segments.Orthogonal });
            connectors.Add(new DiagramConnector() { Id = "connector3", SourceID = "substitutes", TargetID = "industry", Type = Segments.Orthogonal });
            connectors.Add(new DiagramConnector() { Id = "connector4", SourceID = "buyers", TargetID = "industry", Type = Segments.Orthogonal });
            connectors.Add(new DiagramConnector() { Id = "connector5", SourceID = "potential", TargetID = "buyers", Type = Segments.Orthogonal, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None} });
            connectors.Add(new DiagramConnector() { Id = "connector6", SourceID = "buyers", TargetID = "substitutes", Type = Segments.Orthogonal, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None } });
            connectors.Add(new DiagramConnector() { Id = "connector7", TargetID = "suplier", SourceID = "substitutes", Type = Segments.Orthogonal, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None } });
            connectors.Add(new DiagramConnector() { Id = "connector8", SourceID = "suplier", TargetID = "potential", Type = Segments.Orthogonal, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None } });

            List<FontFamily> font = new List<FontFamily>();
            font.Add(new FontFamily() { Name = "Arial" });
            font.Add(new FontFamily() { Name = "Aharoni" });
            font.Add(new FontFamily() { Name = "Bell MT" });
            font.Add(new FontFamily() { Name = "Fantasy" });
            font.Add(new FontFamily() { Name = "Times New Roman" });
            font.Add(new FontFamily() { Name = "Segoe UI" });
            font.Add(new FontFamily() { Name = "Verdana" });

            ViewData["font"] = font;

            List<TemplateList> templateList = new List<TemplateList>();
            templateList.Add(new TemplateList() { Value = "none", Text = "None" });
            templateList.Add(new TemplateList() { Value = "industry", Text = "Industry Competitors" });
            templateList.Add(new TemplateList() { Value = "suppliers", Text = "Suppliers" });
            templateList.Add(new TemplateList() { Value = "potential", Text = "Potential Entrants" });
            templateList.Add(new TemplateList() { Value = "buyers", Text = "Buyers" });
            templateList.Add(new TemplateList() { Value = "substitutes", Text = "Substitutes" });

            ViewData["templateList"] = templateList;

            ViewData["connectors"] = connectors;
            return View();
        }
    }

    public class FontFamily
    {
        public string Name;
    }

    public class TemplateList
    {
        public string Value;
        public string Text;
    }
}