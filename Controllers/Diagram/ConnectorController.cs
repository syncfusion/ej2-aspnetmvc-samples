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
        // GET: Connector
        public ActionResult Connector()
        {
            List<Syncfusion.EJ2.Diagrams.DiagramNode> nodes = new List<Syncfusion.EJ2.Diagrams.DiagramNode>();
            List<DiagramNodeAnnotation> Node1 = new List<DiagramNodeAnnotation>();
            Node1.Add(new DiagramNodeAnnotation() { Content = "Promotion" });
            List<DiagramNodeAnnotation> Node2 = new List<DiagramNodeAnnotation>();
            Node2.Add(new DiagramNodeAnnotation() { Content = "Lead" });
            List<DiagramNodeAnnotation> Node3 = new List<DiagramNodeAnnotation>();
            Node3.Add(new DiagramNodeAnnotation() { Content = "Account" });
            List<DiagramNodeAnnotation> Node4 = new List<DiagramNodeAnnotation>();
            Node4.Add(new DiagramNodeAnnotation() { Content = "Information" });
            List<DiagramNodeAnnotation> Node5 = new List<DiagramNodeAnnotation>();
            Node5.Add(new DiagramNodeAnnotation() { Content = "Security" });

            nodes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode()
            {
                Id = "node1",
                Annotations = Node1,
                Style = new DiagramStrokeStyle() { StrokeColor = "#6f409f", StrokeWidth = 2 },
                Height = 35,
                Width = 80
            });
            nodes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode()
            {
                Id = "node2",
                Annotations = Node2,
                Style = new DiagramStrokeStyle() { StrokeColor = "#6f409f", StrokeWidth = 2 },
                Height = 35,
                Width = 80
            });
            nodes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode()
            {
                Id = "node3",
                Annotations = Node3,
                Style = new DiagramStrokeStyle() { StrokeColor = "#6f409f", StrokeWidth = 2 },
                Height = 35,
                Width = 80
            });
            nodes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode()
            {
                Id = "node4",
                Annotations = Node4,
                Style = new DiagramStrokeStyle() { StrokeColor = "#6f409f", StrokeWidth = 2 },
                Height = 35,
                Width = 80
            });
            nodes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode()
            {
                Id = "node5",
                Annotations = Node5,
                Style = new DiagramStrokeStyle() { StrokeColor = "#6f409f", StrokeWidth = 2 },
                Height = 35,
                Width = 80
            });
            nodes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode()
            {
                Id = "node6",
                ExcludeFromLayout = true
            });
            List<DiagramConnector> connectors = new List<DiagramConnector>();
            connectors.Add(new DiagramConnector() { Id = "connector", SourceID = "node1", TargetID = "node2", });
            connectors.Add(new DiagramConnector() { Id = "connector1", SourceID = "node2", TargetID = "node3", SourcePortID = "port1", TargetPortID = "portin" });
            connectors.Add(new DiagramConnector() { Id = "connector2", SourceID = "node2", TargetID = "node4", SourcePortID = "port2", TargetPortID = "portin" });
            connectors.Add(new DiagramConnector() { Id = "connector3", SourceID = "node2", TargetID = "node5", SourcePortID = "port3", TargetPortID = "portin" });
            connectors.Add(new DiagramConnector() { Id = "connector4", SourceID = "node6", TargetID = "node3", SourcePortID = "port4", TargetPortID = "portOut" });
            connectors.Add(new DiagramConnector() { Id = "connector5", SourceID = "node6", TargetID = "node4", SourcePortID = "port5", TargetPortID = "portOut" });
            connectors.Add(new DiagramConnector() { Id = "connector6", SourceID = "node6", TargetID = "node5", SourcePortID = "port6", TargetPortID = "portOut" });
            ViewData["nodes"] = nodes;
            ViewData["connectors"] = connectors;
            Models.ConnectorDecoratorShape dropDownModel = new Models.ConnectorDecoratorShape();
            ViewData["shapes"] = dropDownModel.decoratorShape();
            return View();
        }
    }

}