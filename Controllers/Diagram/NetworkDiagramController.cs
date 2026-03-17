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
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: NetworkShapes
        public ActionResult NetworkDiagram()
        {
            List<DiagramPort> port = new List<DiagramPort>();
            port.Add(new DiagramPort()
            {
                Id = "port1",
                Offset = new DiagramPoint() { X = 0, Y = 0.5 }
            });
            port.Add(new DiagramPort()
            {
                Id = "port2",
                Offset = new DiagramPoint() { X = 1, Y = 0.5 }
            });
            port.Add(new DiagramPort()
            {
                Id = "port3",
                Offset = new DiagramPoint() { X = 0.5, Y = 0.1 }
            });
            port.Add(new DiagramPort()
            {
                Id = "port4",
                Offset = new DiagramPoint() { X = 0.5, Y = 0.92 }
            });

            List<DiagramPort> portrc = new List<DiagramPort>();
            portrc.Add(new DiagramPort()
            {
                Id = "port1",
                Offset = new DiagramPoint() { X = 0.05, Y = 0.5 }
            });
            portrc.Add(new DiagramPort()
            {
                Id = "port2",
                Offset = new DiagramPoint() { X = 1, Y = 0.5 }
            });
            portrc.Add(new DiagramPort()
            {
                Id = "port3",
                Offset = new DiagramPoint() { X = 0.85, Y = 0.1 }
            });
            portrc.Add(new DiagramPort()
            {
                Id = "port4",
                Offset = new DiagramPoint() { X = 0.6, Y = 0.97 }
            });

            List<DiagramPort> porthmi = new List<DiagramPort>();
            porthmi.Add(new DiagramPort()
            {
                Id = "port1",
                Offset = new DiagramPoint() { X = 0.34, Y = 0.5 }
            });
            porthmi.Add(new DiagramPort()
            {
                Id = "port2",
                Offset = new DiagramPoint() { X = 0.75, Y = 0.5 }
            });
            porthmi.Add(new DiagramPort()
            {
                Id = "port3",
                Offset = new DiagramPoint() { X = 0.5, Y = 0.05 }
            });
            porthmi.Add(new DiagramPort()
            {
                Id = "port4",
                Offset = new DiagramPoint() { X = 0.6, Y = 0.9 }
            });

            List<DiagramPort> port2 = new List<DiagramPort>();
            port2.Add(new DiagramPort()
            {
                Id = "port1",
                Offset = new DiagramPoint() { X = 0.45, Y = 0.5 }
            });
            port2.Add(new DiagramPort()
            {
                Id = "port2",
                Offset = new DiagramPoint() { X = 0.97, Y = 0.5 }
            });
            port2.Add(new DiagramPort()
            {
                Id = "port3",
                Offset = new DiagramPoint() { X = 0.5, Y = 0.97 }
            });

            List<DiagramPort> portmo = new List<DiagramPort>();
            portmo.Add(new DiagramPort()
            {
                Id = "port1",
                Offset = new DiagramPoint() { X = 0.02, Y = 0.6 }
            });
            portmo.Add(new DiagramPort()
            {
                Id = "port2",
                Offset = new DiagramPoint() { X = 0.98, Y = 0.625 }
            });
            portmo.Add(new DiagramPort()
            {
                Id = "port3",
                Offset = new DiagramPoint() { X = 0.5, Y = 0.3 }
            });
            portmo.Add(new DiagramPort()
            {
                Id = "port4",
                Offset = new DiagramPoint() { X = 0.5, Y = 0.97 }
            });

            List<DiagramNode> nodes = new List<DiagramNode>();
            nodes.Add(new DiagramNode()
            {
                Id = "Server",
                OffsetX = 80,
                OffsetY = 75,
                Shape = new
                {
                    type = "Native",
                    content = new NetworkTemplate().template1
                },
                Annotations = new List<DiagramNodeAnnotation>() {
                    new DiagramNodeAnnotation() {
                        Content = "Server",
                        Offset = new DiagramPoint() { X = 0, Y = 0 },
                        Margin= new DiagramMargin() { Bottom=10 }
                    }
                },
                Ports = port
            });
            nodes.Add(new DiagramNode()
            {
                Id = "WorkStation1",
                OffsetX = 250,
                OffsetY = 75,
                Shape = new
                {
                    type = "Native",
                    content = new NetworkTemplate().template2
                },
                Annotations = new List<DiagramNodeAnnotation>() {
                    new DiagramNodeAnnotation() {
                        Content = "Work Station",
                        Offset = new DiagramPoint() { X = 1.4, Y = 0.2 },
                        Margin= new DiagramMargin() { Bottom=25 }
                    }
                },
                Ports = port2
            });
            nodes.Add(new DiagramNode()
            {
                Id = "WorkStation2",
                OffsetX = 350,
                OffsetY = 75,
                Shape = new
                {
                    type = "Native",
                    content = new NetworkTemplate().template2
                },
                Ports = port2
            });
            nodes.Add(new DiagramNode()
            {
                Id = "modem1",
                OffsetX = 450,
                OffsetY = 125,
                Shape = new
                {
                    type = "Native",
                    content = new NetworkTemplate().template3
                },
                Annotations = new List<DiagramNodeAnnotation>() {
                    new DiagramNodeAnnotation() {
                        Content = "Modem1",
                        Offset = new DiagramPoint() { X = 0, Y = 0.5 },
                        Margin= new DiagramMargin() { Right=25 }
                    }
                },
                Ports = portmo
            });
            nodes.Add(new DiagramNode()
            {
                Id = "modem2",
                OffsetX = 525,
                OffsetY = 175,
                Shape = new
                {
                    type = "Native",
                    content = new NetworkTemplate().template3
                },
                Annotations = new List<DiagramNodeAnnotation>() {
                    new DiagramNodeAnnotation() {
                        Content = "Modem2",
                        Offset = new DiagramPoint() { X = 0.5, Y = 0 },
                        Margin= new DiagramMargin() { Bottom=10 }
                    }
                },
                Ports = portmo
            });
            nodes.Add(new DiagramNode()
            {
                Id = "RemoteController1",
                OffsetX = 600,
                OffsetY = 125,
                Shape = new
                {
                    type = "Native",
                    content = new NetworkTemplate().template4
                },
                Annotations = new List<DiagramNodeAnnotation>() {
                    new DiagramNodeAnnotation() {
                        Content = "Remote Controller",
                        Offset = new DiagramPoint() { X = 0.5, Y = 0 },
                        Margin= new DiagramMargin() { Bottom=10 }
                    }
                },
                Ports = portrc
            });
            nodes.Add(new DiagramNode()
            {
                Id = "modem3",
                OffsetX = 350,
                OffsetY = 205,
                Shape = new
                {
                    type = "Native",
                    content = new NetworkTemplate().template3
                },
                Annotations = new List<DiagramNodeAnnotation>() {
                    new DiagramNodeAnnotation() {
                        Content = "Modem5",
                        Offset = new DiagramPoint() { X = 1, Y = 0.5 },
                        Margin= new DiagramMargin() { Left=35 }
                    }
                },
                Ports = portmo
            });
            nodes.Add(new DiagramNode()
            {
                Id = "modem4",
                OffsetX = 450,
                OffsetY = 245,
                Shape = new
                {
                    type = "Native",
                    content = new NetworkTemplate().template3
                },
                Annotations = new List<DiagramNodeAnnotation>() {
                    new DiagramNodeAnnotation() {
                        Content = "Modem3",
                        Offset = new DiagramPoint() { X = 0.5, Y = 1.3 }
                    }
                },
                Ports = portmo
            });
            nodes.Add(new DiagramNode()
            {
                Id = "modem5",
                OffsetX = 350,
                OffsetY = 330,
                Shape = new
                {
                    type = "Native",
                    content = new NetworkTemplate().template3
                },
                Annotations = new List<DiagramNodeAnnotation>() {
                    new DiagramNodeAnnotation() {
                        Content = "Modem4",
                        Offset = new DiagramPoint() { X = 0, Y = 0.5 },
                        Margin= new DiagramMargin() { Right=25 }
                    }
                },
                Ports = portmo
            });
            nodes.Add(new DiagramNode()
            {
                Id = "WorkStation3",
                OffsetX = 600,
                OffsetY = 250,
                Shape = new
                {
                    type = "Native",
                    content = new NetworkTemplate().template2
                },
                Annotations = new List<DiagramNodeAnnotation>() {
                    new DiagramNodeAnnotation() {
                        Content = "Remote Work Staions",
                        Offset = new DiagramPoint() { X = 0.5, Y = 1 },
                        Margin= new DiagramMargin() { Top=12 }
                    }
                },
                Ports = port2
            });
            nodes.Add(new DiagramNode()
            {
                Id = "WorkStation4",
                OffsetX = 600,
                OffsetY = 335,
                Shape = new
                {
                    type = "Native",
                    content = new NetworkTemplate().template2
                },
                Annotations = new List<DiagramNodeAnnotation>() {
                    new DiagramNodeAnnotation() {
                        Content = "Portable Work Staions",
                        Offset = new DiagramPoint() { X = 0.5, Y = 1 },
                        Margin= new DiagramMargin() { Top=12 }
                    }
                },
                Ports = port2
            });
            nodes.Add(new DiagramNode()
            {
                Id = "RemoteController2",
                OffsetX = 80,
                OffsetY = 400,
                Shape = new
                {
                    type = "Native",
                    content = new NetworkTemplate().template4
                },
                Annotations = new List<DiagramNodeAnnotation>() {
                    new DiagramNodeAnnotation() {
                        Content = "Control Logic",
                        Offset = new DiagramPoint() { X = 0.5, Y = 1 },
                        Margin= new DiagramMargin() { Top=8 }
                    }
                },
                Ports = portrc
            });
            nodes.Add(new DiagramNode()
            {
                Id = "RemoteController3",
                OffsetX = 500,
                OffsetY = 400,
                Shape = new
                {
                    type = "Native",
                    content = new NetworkTemplate().template4
                },
                Annotations = new List<DiagramNodeAnnotation>() {
                    new DiagramNodeAnnotation() {
                        Content = "Control Logic",
                        Offset = new DiagramPoint() { X = 0.5, Y = 1 },
                        Margin= new DiagramMargin() { Top=8 }
                    }
                },
                Ports = portrc
            });
            nodes.Add(new DiagramNode()
            {
                Id = "AnalogIO",
                OffsetX = 160,
                OffsetY = 500,
                Shape = new
                {
                    type = "Native",
                    content = new NetworkTemplate().template5
                },
                Annotations = new List<DiagramNodeAnnotation>() {
                    new DiagramNodeAnnotation() {
                        Content = "Analog IO",
                        Offset = new DiagramPoint() { X = 0.5, Y = 1 },
                        Margin= new DiagramMargin() { Top=13 }
                    }
                },
                Ports = porthmi
            });
            nodes.Add(new DiagramNode()
            {
                Id = "sensor",
                OffsetX = 260,
                OffsetY = 500,
                Shape = new
                {
                    type = "Native",
                    content = new NetworkTemplate().template6
                },
                Annotations = new List<DiagramNodeAnnotation>() {
                    new DiagramNodeAnnotation() {
                        Content = "Sensor",
                        Offset = new DiagramPoint() { X = 0.5, Y = 1 },
                        Margin= new DiagramMargin() { Top=10 }
                    }
                },
                Ports = port
            });
            nodes.Add(new DiagramNode()
            {
                Id = "DeviceDriver1",
                OffsetX = 360,
                OffsetY = 500,
                Shape = new
                {
                    type = "Native",
                    content = new NetworkTemplate().template7
                },
                Annotations = new List<DiagramNodeAnnotation>() {
                    new DiagramNodeAnnotation() {
                        Content = "DriverA",
                        Offset = new DiagramPoint() { X = 0.5, Y = 1.3 }
                    }
                },
                Ports = porthmi
            });
            nodes.Add(new DiagramNode()
            {
                Id = "DeviceDriver2",
                OffsetX = 460,
                OffsetY = 500,
                Shape = new
                {
                    type = "Native",
                    content = new NetworkTemplate().template7
                },
                Annotations = new List<DiagramNodeAnnotation>() {
                    new DiagramNodeAnnotation() {
                        Content = "DriverB",
                        Offset = new DiagramPoint() { X = 0.5, Y = 1.3 }
                    }
                },
                Ports = porthmi
            });
            nodes.Add(new DiagramNode()
            {
                Id = "DeviceDriver3",
                OffsetX = 550,
                OffsetY = 500,
                Shape = new
                {
                    type = "Native",
                    content = new NetworkTemplate().template7
                },
                Annotations = new List<DiagramNodeAnnotation>() {
                    new DiagramNodeAnnotation() {
                        Content = "DriverC",
                        Offset = new DiagramPoint() { X = 0.5, Y = 1.3 }
                    }
                },
                Ports = porthmi
            });
            nodes.Add(new DiagramNode()
            {
                Id = "HMI",
                OffsetX = 625,
                OffsetY = 450,
                Shape = new
                {
                    type = "Native",
                    content = new NetworkTemplate().template8
                },
                Annotations = new List<DiagramNodeAnnotation>() {
                    new DiagramNodeAnnotation() {
                        Content = "HMI",
                        Offset = new DiagramPoint() { X = 0.5, Y = 1.3 }
                    }
                },
                Ports = port
            });
            nodes.Add(new DiagramNode()
            {
                Id = "controlNet",
                OffsetX = 218.5,
                OffsetY = 380,
                Shape = new
                {
                    type = "Text",
                    content = "Control Net"
                }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "etherNet",
                OffsetX = 218.5,
                OffsetY = 190,
                Shape = new
                {
                    type = "Text",
                    content = "Ethernet"
                }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "deviceNet",
                Width = 127,
                Height = 40,
                OffsetX = 345.5,
                OffsetY = 555,
                Shape = new
                {
                    type = "Text",
                    content = "Device Net"
                }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "connector1",
                OffsetX = 99,
                OffsetY = 175,
                Shape = new
                {
                    type = "Path",
                    data = new NetworkTemplate().arrow
                }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "connector2",
                OffsetX = 250,
                OffsetY = 125,
                Shape = new
                {
                    type = "Path",
                    data = new NetworkTemplate().arrow
                }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "connector3",
                OffsetX = 99,
                OffsetY = 300,
                Shape = new
                {
                    type = "Path",
                    data = new NetworkTemplate().arrow
                }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "connector4",
                OffsetX = 178,
                OffsetY = 435,
                Shape = new
                {
                    type = "Path",
                    data = new NetworkTemplate().arrow
                }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "connector5",
                OffsetX = 378,
                OffsetY = 435,
                Shape = new
                {
                    type = "Path",
                    data = new NetworkTemplate().arrow
                }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "connector6",
                OffsetX = 370,
                OffsetY = 380,
                Shape = new
                {
                    type = "Path",
                    data = new NetworkTemplate().arrow
                }
            });

            List<DiagramConnector> connectors = new List<DiagramConnector>();
            connectors.Add(new DiagramConnector()
            {
                Id = "connectora",
                SourceID = "Server",
                TargetID = "WorkStation1",
                TargetPortID = "port1"
            });
            connectors.Add(new DiagramConnector()
            {
                Id = "connectorawork",
                SourceID = "WorkStation1",
                TargetID = "WorkStation2",
                SourcePortID = "port2",
                TargetPortID = "port1"
            });
            connectors.Add(new DiagramConnector()
            {
                Id = "connectoraworkm",
                SourceID = "WorkStation1",
                TargetID = "modem1",
                SourcePortID = "port2",
                TargetPortID = "port3",
                Type = Segments.Orthogonal,
                Segments = new List<DiagramSegment>() { new DiagramSegment() { Type = "Orthogonal", Length = 25 } }
            });
            connectors.Add(new DiagramConnector()
            {
                Id = "connectorm1m2",
                SourceID = "modem2",
                TargetID = "modem1",
                SourcePortID = "port1",
                TargetPortID = "port4",
                Type = Segments.Orthogonal,
                Segments = new List<DiagramSegment>() { new DiagramSegment() { Type = "Orthogonal", Length = 25 } }
            });
            connectors.Add(new DiagramConnector()
            {
                Id = "connectorm2m3",
                SourceID = "modem2",
                TargetID = "RemoteController1",
                SourcePortID = "port2",
                TargetPortID = "port4",
                Type = Segments.Orthogonal,
                Segments = new List<DiagramSegment>() { new DiagramSegment() { Type = "Orthogonal", Length = 25 } }
            });
            connectors.Add(new DiagramConnector()
            {
                Id = "connectorws2m3",
                SourceID = "WorkStation2",
                TargetID = "modem3",
                SourcePortID = "port3",
                TargetPortID = "port3"
            });
            connectors.Add(new DiagramConnector()
            {
                Id = "connectorws2m4",
                SourceID = "modem4",
                TargetID = "modem3",
                SourcePortID = "port1",
                TargetPortID = "port4",
                Type = Segments.Orthogonal,
                Segments = new List<DiagramSegment>() { new DiagramSegment() { Type = "Orthogonal", Length = 25 } }
            });
            connectors.Add(new DiagramConnector()
            {
                Id = "connectorm3m4",
                SourceID = "modem5",
                TargetID = "modem3",
                SourcePortID = "port3",
                TargetPortID = "port4"
            });
            connectors.Add(new DiagramConnector()
            {
                Id = "connectorm4ws3",
                SourceID = "modem5",
                TargetID = "WorkStation4",
                SourcePortID = "port2",
                TargetPortID = "port1"
            });
            connectors.Add(new DiagramConnector()
            {
                Id = "connectorm4m5",
                SourceID = "modem4",
                TargetID = "WorkStation3",
                SourcePortID = "port2",
                TargetPortID = "port1"
            });
            connectors.Add(new DiagramConnector()
            {
                Id = "connectorr2r3",
                SourceID = "RemoteController2",
                TargetID = "RemoteController3",
                TargetPortID = "port1"
            });
            connectors.Add(new DiagramConnector()
            {
                Id = "connectorr2r3qq",
                SourceID = "Server",
                TargetID = "RemoteController2",
                SourcePortID = "port4",
            });
            connectors.Add(new DiagramConnector()
            {
                Id = "connectorm3se1",
                SourceID = "modem3",
                TargetID = "Server",
                SourcePortID = "port1",
                TargetPortID = "port4",
                Type = Segments.Orthogonal,
                Segments = new List<DiagramSegment>() { new DiagramSegment() { Type = "Orthogonal", Length = 25 } }
            });
            connectors.Add(new DiagramConnector()
            {
                Id = "connectorws2aio1",
                SourceID = "RemoteController2",
                TargetID = "AnalogIO",
                SourcePortID = "port2",
                TargetPortID = "port3",
                Type = Segments.Orthogonal,
            });
            connectors.Add(new DiagramConnector()
            {
                Id = "connectorb",
                SourceID = "RemoteController2",
                TargetID = "sensor",
                SourcePortID = "port2",
                TargetPortID = "port3",
                Type = Segments.Orthogonal,
                Segments = new List<DiagramSegment>() { new DiagramSegment() { Type = "Orthogonal", Length = 25 } }
            });
            connectors.Add(new DiagramConnector()
            {
                Id = "connectord1",
                SourceID = "RemoteController2",
                TargetID = "DeviceDriver1",
                SourcePortID = "port2",
                TargetPortID = "port3",
                Type = Segments.Orthogonal,
                Segments = new List<DiagramSegment>() { new DiagramSegment() { Type = "Orthogonal", Length = 25 } }
            });
            connectors.Add(new DiagramConnector()
            {
                Id = "connectord2",
                SourceID = "RemoteController2",
                TargetID = "DeviceDriver2",
                SourcePortID = "port2",
                TargetPortID = "port3",
                Type = Segments.Orthogonal,
                Segments = new List<DiagramSegment>() { new DiagramSegment() { Type = "Orthogonal", Length = 25 } }
            });
            connectors.Add(new DiagramConnector()
            {
                Id = "connectordh1d3",
                SourceID = "HMI",
                TargetID = "DeviceDriver3",
                SourcePortID = "port1",
                TargetPortID = "port3",
                Type = Segments.Orthogonal,
            });
            connectors.Add(new DiagramConnector()
            {
                Id = "connectordh1d2",
                SourceID = "HMI",
                TargetID = "DeviceDriver2",
                SourcePortID = "port1",
                TargetPortID = "port3",
                Type = Segments.Orthogonal,
            });

            ViewData["nodes"] = nodes;
            ViewData["connectors"] = connectors;

            List<DiagramNode> symbols = new List<DiagramNode>();
            symbols.Add(new DiagramNode()
            {
                Id = "server",
                Shape = new { type = "Native", content = new NetworkTemplate().template1 }
            });
            symbols.Add(new DiagramNode()
            {
                Id = "workStation",
                Shape = new { type = "Native", content = new NetworkTemplate().template2 }
            });
            symbols.Add(new DiagramNode()
            {
                Id = "modem",
                Shape = new { type = "Native", content = new NetworkTemplate().template3 }
            });
            symbols.Add(new DiagramNode()
            {
                Id = "remoteController",
                Shape = new { type = "Native", content = new NetworkTemplate().template4 }
            });
            symbols.Add(new DiagramNode()
            {
                Id = "hmi",
                Shape = new { type = "Native", content = new NetworkTemplate().template8 }
            });
            symbols.Add(new DiagramNode()
            {
                Id = "analogIO",
                Shape = new { type = "Native", content = new NetworkTemplate().template5 }
            });
            symbols.Add(new DiagramNode()
            {
                Id = "sensor",
                Shape = new { type = "Native", content = new NetworkTemplate().template6 }
            });
            symbols.Add(new DiagramNode()
            {
                Id = "deviceDriver",
                Shape = new { type = "Native", content = new NetworkTemplate().template7 }
            });
            symbols.Add(new DiagramNode()
            {
                Id = "Virtual-Server-Copy",
                Shape = new { type = "Native", content = new NetworkTemplate().template10 }
            });
            symbols.Add(new DiagramNode()
            {
                Id = "user",
                Shape = new { type = "Native", content = new NetworkTemplate().template11 }
            });
            symbols.Add(new DiagramNode()
            {
                Id = "User-group",
                Shape = new { type = "Native", content = new NetworkTemplate().template12 }
            });
            symbols.Add(new DiagramNode()
            {
                Id = "UPS",
                Shape = new { type = "Native", content = new NetworkTemplate().template13 }
            });
            symbols.Add(new DiagramNode()
            {
                Id = "Tablet",
                Shape = new { type = "Native", content = new NetworkTemplate().template14 }
            });
            symbols.Add(new DiagramNode()
            {
                Id = "Switch",
                Shape = new { type = "Native", content = new NetworkTemplate().template15 }
            });
            symbols.Add(new DiagramNode()
            {
                Id = "Subwoofer",
                Shape = new { type = "Native", content = new NetworkTemplate().template16 }
            });
            symbols.Add(new DiagramNode()
            {
                Id = "Speaker",
                Shape = new { type = "Native", content = new NetworkTemplate().template17 }
            });
            symbols.Add(new DiagramNode()
            {
                Id = "Security-camera",
                Shape = new { type = "Native", content = new NetworkTemplate().template18 }
            });
            symbols.Add(new DiagramNode()
            {
                Id = "arrow",
                Shape = new { type = "Path", data = new NetworkTemplate().arrow }
            });

            List<DiagramConnector> connectorSymbols = new List<DiagramConnector>();
            connectorSymbols.Add(new DiagramConnector()
            {
                Id = "link1",
                Type = Segments.Straight,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new DiagramDecorator() { Shape = DecoratorShapes.Arrow, Style = new DiagramShapeStyle() { Fill = "#757575", StrokeColor = "#757575" } },
                Style = new DiagramStrokeStyle() { StrokeWidth = 2, StrokeColor = "#757575" }
            });
            connectorSymbols.Add(new DiagramConnector()
            {
                Id = "link2",
                Type = Segments.Orthogonal,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new DiagramDecorator() { Shape = DecoratorShapes.Arrow, Style = new DiagramShapeStyle() { Fill = "#757575", StrokeColor = "#757575" } },
                Style = new DiagramStrokeStyle() { StrokeWidth = 2, StrokeColor = "#757575" }
            });

            List<SymbolPalettePalette> palettes = new List<SymbolPalettePalette>();
            palettes.Add(new SymbolPalettePalette()
            {
                Id = "network",
                Expanded = true,
                Symbols = symbols,
                Title = "Network Shapes"
            });
            palettes.Add(new SymbolPalettePalette()
            {
                Id = "connectors",
                Expanded = true,
                Symbols = connectorSymbols,
                Title = "Connectors"
            });

            ViewData["Palette"] = palettes;
            return View();
        }
    }
}