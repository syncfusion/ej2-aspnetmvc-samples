#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
        // GET: SequenceDiagram
        public ActionResult SequenceDiagram()
        {
            List<DiagramPort> ports1 = new List<DiagramPort>();
            ports1.Add(new DiagramPort() { Id = "port1", Offset = new DiagramPoint() { X = 1, Y = 0.05 }, Visibility = PortVisibility.Hidden });
            ports1.Add(new DiagramPort() { Id = "port2", Offset = new DiagramPoint() { X = 1, Y = 0.97 }, Visibility = PortVisibility.Hidden });
            List<DiagramPort> ports2 = new List<DiagramPort>();
            ports2.Add(new DiagramPort() { Id = "port1", Offset = new DiagramPoint() { X = 0, Y = 0.07 }, Visibility = PortVisibility.Hidden });
            ports2.Add(new DiagramPort() { Id = "port2", Offset = new DiagramPoint() { X = 1, Y = 0.92 }, Visibility = PortVisibility.Hidden });
            ports2.Add(new DiagramPort() { Id = "port3", Offset = new DiagramPoint() { X = 1, Y = 0.5 }, Visibility = PortVisibility.Hidden });
            List<DiagramPort> ports3 = new List<DiagramPort>();
            ports3.Add(new DiagramPort() { Id = "port1", Offset = new DiagramPoint() { X = 0, Y = 0.5 }, Visibility = PortVisibility.Hidden });
            List<DiagramPort> ports4 = new List<DiagramPort>();
            ports4.Add(new DiagramPort() { Id = "port1", Offset = new DiagramPoint() { X = 0, Y = 0.1 }, Visibility = PortVisibility.Hidden });
            ports4.Add(new DiagramPort() { Id = "port2", Offset = new DiagramPoint() { X = 0, Y = 0.9 }, Visibility = PortVisibility.Hidden });
            List<DiagramNode> nodes = new List<DiagramNode>();
            nodes.Add(new DiagramNode()
            {
                Id = "employee",
                Width = 100,
                Height = 60,
                Style = new DiagramTextStyle()
                {
                    Fill = "transparent",
                    Bold = true
                },
                OffsetX = 100,
                OffsetY = 100,
                Shape = new { type = "Text", content = "Employee" },
            });
            nodes.Add(new DiagramNode()
            {
                Id = "teamLead",
                Width = 100,
                Height = 60,
                Style = new DiagramTextStyle()
                {
                    Fill = "transparent",
                    Bold = true
                },
                OffsetX = 350,
                OffsetY = 100,
                Shape = new { type = "Text", content = "Team Lead" },
            });
            nodes.Add(new DiagramNode()
            {
                Id = "dashboard",
                Width = 100,
                Height = 60,
                Style = new DiagramTextStyle()
                {
                    Fill = "transparent",
                    Bold = true
                },
                OffsetX = 600,
                OffsetY = 100,
                Shape = new { type = "Text", content = "Dashboard" },
            });
            nodes.Add(new DiagramNode()
            {
                Id = "manager",
                Width = 100,
                Height = 60,
                Style = new DiagramTextStyle()
                {
                    Fill = "transparent",
                    Bold = true
                },
                OffsetX = 850,
                OffsetY = 100,
                Shape = new { type = "Text", content = "Manager" },
            });
            nodes.Add(new DiagramNode()
            {
                Id = "leaveRequest",
                Width = 100,
                Height = 60,
                Style = new DiagramTextStyle()
                {
                    Fill = "transparent",
                },
                OffsetX = 225,
                OffsetY = 250,
                Shape = new { type = "Text", content = "Leave Request" },
            });
            nodes.Add(new DiagramNode()
            {
                Id = "leaveApproval",
                Width = 100,
                Height = 60,
                Style = new DiagramTextStyle()
                {
                    Fill = "transparent",
                },
                OffsetX = 225,
                OffsetY = 484,
                Shape = new { type = "Text", content = "Leave Approval" },
            });
            nodes.Add(new DiagramNode()
            {
                Id = "checkEmplyeeAvail",
                Width = 175,
                Height = 30,
                Style = new DiagramTextStyle()
                {
                    Fill = "transparent",
                },
                OffsetX = 470,
                OffsetY = 345,
                Shape = new { type = "Text", content = "Check Employee availability and task status" },
            });
            nodes.Add(new DiagramNode()
            {
                Id = "forwardLeaveMssg",
                Width = 150,
                Height = 30,
                Style = new DiagramTextStyle()
                {
                    Fill = "transparent",
                },
                OffsetX = 600,
                OffsetY = 420,
                Shape = new { type = "Text", content = "Forward Leave Request" },
            });
            nodes.Add(new DiagramNode()
            {
                Id = "noObjection",
                Width = 150,
                Height = 30,
                Style = new DiagramTextStyle()
                {
                    Fill = "transparent",
                },
                OffsetX = 600,
                OffsetY = 460,
                Shape = new { type = "Text", content = "No Objection" },
            });
            nodes.Add(new DiagramNode()
            {
                Id = "employeeNode",
                Width = 10,
                Height = 250,
                Style = new DiagramTextStyle()
                {
                    Fill = "orange",
                    StrokeColor = "orange"
                },
                OffsetX = 100,
                OffsetY = 350,
                Ports = ports1,
                Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Rectangle },
            });
            nodes.Add(new DiagramNode()
            {
                Id = "teamLeadNode",
                Width = 10,
                Height = 190,
                Style = new DiagramTextStyle()
                {
                    Fill = "orange",
                    StrokeColor = "orange"
                },
                OffsetX = 350,
                OffsetY = 320,
                Ports = ports2,
                Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Rectangle },
            });
            nodes.Add(new DiagramNode()
            {
                Id = "dashboardNode",
                Width = 10,
                Height = 25,
                Style = new DiagramTextStyle()
                {
                    Fill = "orange",
                    StrokeColor = "orange"
                },
                OffsetX = 600,
                OffsetY = 320,
                Ports = ports3,
                Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Rectangle },
            });
            nodes.Add(new DiagramNode()
            {
                Id = "managerNode",
                Width = 10,
                Height = 50,
                Style = new DiagramTextStyle()
                {
                    Fill = "orange",
                    StrokeColor = "orange"
                },
                OffsetX = 850,
                OffsetY = 420,
                Ports = ports4,
                Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Rectangle },
            });
            List<DiagramConnector> Connectors = new List<DiagramConnector>();
            Connectors.Add(new DiagramConnector()
            {
                Id = "employeeCon1",
                SourcePoint = new DiagramPoint() { X = 100, Y = 120 },
                TargetPoint = new DiagramPoint() { X = 100, Y = 225 },
                Type = Segments.Straight,
                TargetDecorator = new DiagramDecorator()
                {
                    Shape = DecoratorShapes.None,
                },
                Style = new DiagramStrokeStyle() { StrokeColor = "#A5A6A7" }

            });
            Connectors.Add(new DiagramConnector()
            {
                Id = "employeeCon2",
                SourcePoint = new DiagramPoint() { X = 100, Y = 475 },
                TargetPoint = new DiagramPoint() { X = 100, Y = 600 },
                Type = Segments.Straight,
                TargetDecorator = new DiagramDecorator()
                {
                    Shape = DecoratorShapes.None,

                },
                Style = new DiagramStrokeStyle() { StrokeColor = "#A5A6A7" }

            });
            Connectors.Add(new DiagramConnector()
            {
                Id = "teamLeanCon1",
                SourcePoint = new DiagramPoint() { X = 350, Y = 120 },
                TargetPoint = new DiagramPoint() { X = 350, Y = 225 },
                Type = Segments.Straight,
                TargetDecorator = new DiagramDecorator()
                {
                    Shape = DecoratorShapes.None,

                },
                Style = new DiagramStrokeStyle() { StrokeColor = "#A5A6A7" }

            });
            Connectors.Add(new DiagramConnector()
            {
                Id = "teamLeanCon2",
                SourcePoint = new DiagramPoint() { X = 350, Y = 415 },
                TargetPoint = new DiagramPoint() { X = 350, Y = 600 },
                Type = Segments.Straight,
                TargetDecorator = new DiagramDecorator()
                {
                    Shape = DecoratorShapes.None,

                },
                Style = new DiagramStrokeStyle() { StrokeColor = "#A5A6A7" }

            });
            Connectors.Add(new DiagramConnector()
            {
                Id = "dashboardCon1",
                SourcePoint = new DiagramPoint() { X = 600, Y = 120 },
                TargetPoint = new DiagramPoint() { X = 600, Y = 307 },
                Type = Segments.Straight,
                TargetDecorator = new DiagramDecorator()
                {
                    Shape = DecoratorShapes.None,

                },
                Style = new DiagramStrokeStyle() { StrokeColor = "#A5A6A7" }

            });
            Connectors.Add(new DiagramConnector()
            {
                Id = "dashboardCon2",
                SourcePoint = new DiagramPoint() { X = 600, Y = 333 },
                TargetPoint = new DiagramPoint() { X = 600, Y = 600 },
                Type = Segments.Straight,
                TargetDecorator = new DiagramDecorator()
                {
                    Shape = DecoratorShapes.None,

                },
                Style = new DiagramStrokeStyle() { StrokeColor = "#A5A6A7" }

            });
            Connectors.Add(new DiagramConnector()
            {
                Id = "managerCon1",
                SourcePoint = new DiagramPoint() { X = 850, Y = 120 },
                TargetPoint = new DiagramPoint() { X = 850, Y = 395 },
                Type = Segments.Straight,
                TargetDecorator = new DiagramDecorator()
                {
                    Shape = DecoratorShapes.None,

                },
                Style = new DiagramStrokeStyle() { StrokeColor = "#A5A6A7" }

            });
            Connectors.Add(new DiagramConnector()
            {
                Id = "managerCon2",
                SourcePoint = new DiagramPoint() { X = 850, Y = 445 },
                TargetPoint = new DiagramPoint() { X = 850, Y = 600 },
                Type = Segments.Straight,
                TargetDecorator = new DiagramDecorator()
                {
                    Shape = DecoratorShapes.None,

                },
                Style = new DiagramStrokeStyle() { StrokeColor = "#A5A6A7" }

            });
            Connectors.Add(new DiagramConnector()
            {
                Id = "empToTeamLead",
                Type = Segments.Straight,
                SourceID = "employeeNode",
                TargetID = "teamLeadNode",
                SourcePortID = "port1",
                TargetPortID = "port1"

            });
            Connectors.Add(new DiagramConnector()
            {
                Id = "teamLeadToEmp",
                Type = Segments.Straight,
                SourcePoint = new DiagramPoint() { X = 350, Y = 465 },
                TargetID = "employeeNode",
                TargetPortID = "port2",
                Style = new DiagramStrokeStyle() { StrokeDashArray = "4 4" }
            });
            Connectors.Add(new DiagramConnector()
            {
                Id = "teamLeadToDash",
                Type = Segments.Straight,
                SourceID = "teamLeadNode",
                TargetID = "dashboardNode",
                SourcePortID = "port3",
                TargetPortID = "port1"

            });
            Connectors.Add(new DiagramConnector()
            {
                Id = "teamLeadToManager",
                Type = Segments.Straight,
                SourceID = "teamLeadNode",
                TargetID = "managerNode",
                SourcePortID = "port2",
                TargetPortID = "port1"

            });
            Connectors.Add(new DiagramConnector()
            {
                Id = "managerToTeamLead",
                Type = Segments.Straight,
                SourceID = "managerNode",
                SourcePortID = "port2",
                TargetPoint = new DiagramPoint() { X = 350, Y = 440 },
                Style = new DiagramStrokeStyle() { StrokeDashArray = "4 4" }

            });
            ViewBag.connectors = Connectors;
            ViewBag.nodes = nodes;
            ViewBag.getConnectorDefaults = "ConnectorDefaults";
            return View();
        }

    }
    public class Node1 : DiagramNode
    {
        public string text;
    }
    public class CustomPort1 : DiagramPort
    {

        public string text;

    }

}