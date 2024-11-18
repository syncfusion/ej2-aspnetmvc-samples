#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Newtonsoft.Json;
using Syncfusion.EJ2;
using Syncfusion.EJ2.Diagrams;
using Syncfusion.EJ2.Navigations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Web.Mvc;
using System.Web.UI;


namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        public ActionResult WorkFlowDiagram()
        {
            List<DiagramNode> nodes = new List<DiagramNode>();

            nodes.Add(new DiagramNode()
            {
                Id = "newTravelRequestRecieved",
                OffsetX = 100,
                OffsetY = 245,
                Width = 60,
                Height = 60,
                Shape = new  Bpmn_Shapes() { Type = "Bpmn" },
            });

            nodes.Add(new DiagramNode()
            {
                Id = "getTravelRequestDetails",
                OffsetX = 250,
                OffsetY = 245,
                Width = 100,
                Height = 80,

                Shape = new  Bpmn_Shapes()
                {
                    Shape = "Activity",
                    Type = "Bpmn",
                    Activity = new DiagramBpmnActivity()
                    {
                        Activity = BpmnActivities.Task,
                    }
                },
            });

            nodes.Add(new DiagramNode()
            {
                Id = "getRequesterProfile",
                OffsetX = 400,
                OffsetY = 245,
                Width = 100,
                Height = 80,
                Shape = new  Bpmn_Shapes()
                {
                    Shape = "Activity",
                    Type = "Bpmn",
                    Activity = new DiagramBpmnActivity()
                    {
                        Activity = BpmnActivities.Task,
                    }
                },
            });
            nodes.Add(new DiagramNode()
            {
                Id = "getManagerDetails",
                OffsetX = 550,
                OffsetY = 245,
                Width = 100,
                Height = 80,
                Shape = new  Bpmn_Shapes()
                {
                    Shape = "Activity",
                    Type = "Bpmn",
                    Activity = new DiagramBpmnActivity()
                    {
                        Activity = BpmnActivities.Task,
                    }
                },
            });
            nodes.Add(new DiagramNode()
            {
                Id = "setStatusAsRejected",
                OffsetX = 700,
                OffsetY = 245,
                Width = 100,
                Height = 80,
                Shape = new  Bpmn_Shapes()
                {
                    Shape = "Activity",
                    Type = "Bpmn",
                    Activity = new DiagramBpmnActivity()
                    {
                        Activity = BpmnActivities.Task,
                    }
                },
            });
            nodes.Add(new DiagramNode()
            {
                Id = "setStatusAsAccepted",
                OffsetX = 850,
                OffsetY = 245,
                Width = 100,
                Height = 80,
                Shape = new  Bpmn_Shapes()
                {
                    Shape = "Activity",
                    Type = "Bpmn",
                    Activity = new DiagramBpmnActivity()
                    {
                        Activity = BpmnActivities.Task,
                    }
                },
            });
            nodes.Add(new DiagramNode()
            {
                Id = "setNextApprovalStatusAsRejected",
                OffsetX = 1100,
                OffsetY = 245,
                Width = 100,
                Height = 80,
                Shape = new  Bpmn_Shapes()
                {
                    Shape = "Activity",
                    Type = "Bpmn",
                    Activity = new DiagramBpmnActivity()
                    {
                        Activity = BpmnActivities.Task,
                    }
                },
            });
            nodes.Add(new DiagramNode()
            {
                Id = "setNextApprovalStatusAsAccepted",
                OffsetX = 1250,
                OffsetY = 245,
                Width = 100,
                Height = 80,
                Shape = new  Bpmn_Shapes()
                {
                    Shape = "Activity",
                    Type = "Bpmn",
                    Activity = new DiagramBpmnActivity()
                    {
                        Activity = BpmnActivities.Task,
                    }
                },
            });
            nodes.Add(new DiagramNode()
            {
                Id = "initiateApprovalWithManager",
                OffsetX = 550,
                OffsetY = 445,
                Width = 100,
                Height = 80,
                Shape = new  Bpmn_Shapes()
                {
                    Shape = "Activity",
                    Type = "Bpmn",
                    Activity = new DiagramBpmnActivity()
                    {
                        Activity = BpmnActivities.Task,
                    }
                },
            });
            nodes.Add(new DiagramNode()
            {
                Id = "checkApprovalStatus",
                OffsetX = 700,
                OffsetY = 445,
                Width = 100,
                Height = 80,
                Shape = new  Bpmn_Shapes()
                {
                    Shape = "Gateway",
                    Type = "Bpmn",

                    gateWay = new DiagramBpmnGateway()
                    {
                        Type = BpmnGateways.Exclusive,
                    }
                },
            });
            nodes.Add(new DiagramNode()
            {
                Id = "checkIfItIsAnInternaltionalTravel",
                OffsetX = 850,
                OffsetY = 445,
                Width = 100,
                Height = 80,
                Shape = new  Bpmn_Shapes()
                {
                    Shape = "Gateway",
                    Type = "Bpmn",

                    gateWay = new DiagramBpmnGateway()
                    {
                        Type = BpmnGateways.Exclusive,
                    }
                },
            });

            nodes.Add(new DiagramNode()
            {
                Id = "initialteApprovalWithNextLevelManager",
                OffsetX = 1000,
                OffsetY = 445,
                Width = 100,
                Height = 80,
                Shape = new  Bpmn_Shapes()
                {
                    Shape = "Activity",
                    Type = "Bpmn",
                    Activity = new DiagramBpmnActivity()
                    {
                        Activity = BpmnActivities.Task,
                    }
                },
            });
            nodes.Add(new DiagramNode()
            {
                Id = "checkLevel2-ApprovalStatus",
                OffsetX = 1130,
                OffsetY = 445,
                Width = 100,
                Height = 80,
                Shape = new  Bpmn_Shapes()
                {
                    Type = "Bpmn",
                    Shape = "Gateway",

                    gateWay = new DiagramBpmnGateway()
                    {
                        Type = BpmnGateways.Parallel
                    }
                },
            });



            List<DiagramConnector> connectors = new List<DiagramConnector>();
            connectors.Add(new DiagramConnector() { Id = "newTravelRequestRecieved-getTravelRequestDetails", SourceID = "newTravelRequestRecieved", TargetID = "getTravelRequestDetails", });
            connectors.Add(new DiagramConnector() { Id = "getTravelRequestDetails-getRequesterProfile", SourceID = "getTravelRequestDetails", TargetID = "getRequesterProfile", });
            connectors.Add(new DiagramConnector() { Id = "getRequesterProfile-getManagerDetails", SourceID = "getRequesterProfile", TargetID = "getManagerDetails", });
            connectors.Add(new DiagramConnector() { Id = "getManagerDetails-initiateApprovalWithManager", SourceID = "getManagerDetails", TargetID = "initiateApprovalWithManager", });
            connectors.Add(new DiagramConnector() { Id = "initiateApprovalWithManager-checkApprovalStatus", SourceID = "initiateApprovalWithManager", TargetID = "checkApprovalStatus", });
            connectors.Add(new DiagramConnector() { Id = "checkApprovalStatus-setStatusAsRejected", SourceID = "checkApprovalStatus", TargetID = "setStatusAsRejected", Annotations = new List<DiagramConnectorAnnotation>() { new DiagramConnectorAnnotation() { Content = "Rejected", Offset = 0.4, Style = new DiagramTextStyle { Fill = "white" } } } });
            connectors.Add(new DiagramConnector() { Id = "checkApprovalStatus-checkIfItIsAnInternaltionalTravel", SourceID = "checkApprovalStatus", TargetID = "checkIfItIsAnInternaltionalTravel", Annotations = new List<DiagramConnectorAnnotation>() { new DiagramConnectorAnnotation() { Content = "Accepted", Offset = 0.4, Style = new DiagramTextStyle { Fill = "white" } } } });
            connectors.Add(new DiagramConnector() { Id = "checkIfItIsAnInternaltionalTravel-setStatusAsAccepted", SourceID = "checkIfItIsAnInternaltionalTravel", TargetID = "setStatusAsAccepted", Annotations = new List<DiagramConnectorAnnotation>() { new DiagramConnectorAnnotation() { Content = "No", Offset = 0.4, Style = new DiagramTextStyle { Fill = "white" } } } });
            connectors.Add(new DiagramConnector() { Id = "checkIfItIsAnInternaltionalTravel-initialteApprovalWithNextLevelManager", SourceID = "checkIfItIsAnInternaltionalTravel", TargetID = "initialteApprovalWithNextLevelManager", Annotations = new List<DiagramConnectorAnnotation>() { new DiagramConnectorAnnotation() { Content = "Yes", Offset = 0.4, Style = new DiagramTextStyle { Fill = "white" } } } });
            connectors.Add(new DiagramConnector() { Id = "initialteApprovalWithNextLevelManager-checkLevel2-ApprovalStatus", SourceID = "initialteApprovalWithNextLevelManager", TargetID = "checkLevel2-ApprovalStatus", });
            connectors.Add(new DiagramConnector() { Id = "checkLevel2-ApprovalStatus-setNextApprovalStatusAsRejected", SourceID = "checkLevel2-ApprovalStatus", TargetID = "setNextApprovalStatusAsRejected", Annotations = new List<DiagramConnectorAnnotation>() { new DiagramConnectorAnnotation() { Content = "Rejected", Offset = 0.4, Style = new DiagramTextStyle { Fill = "white" } } } });
            connectors.Add(new DiagramConnector() { Id = "checkLevel2-ApprovalStatus-setNextApprovalStatusAsAccepted", SourceID = "checkLevel2-ApprovalStatus", TargetID = "setNextApprovalStatusAsAccepted", Annotations = new List<DiagramConnectorAnnotation>() { new DiagramConnectorAnnotation() { Content = "Accepted", Offset = 0.4, Style = new DiagramTextStyle { Fill = "white" } } } });





            List<ToolbarItem> items = new List<ToolbarItem>();
            {
                items.Add(new ToolbarItem { PrefixIcon = "e-play", Text = "Execute", TooltipText = "Execute" });
                items.Add(new ToolbarItem { PrefixIcon = "e-diagram-icons e-diagram-reset", Disabled = true, Text = "Reset", TooltipText = "Reset" });
            }

            ViewBag.nodes = nodes;
            ViewBag.connectors = connectors;
            ViewBag.tbItems = items;

            return View();
        }
    }

    public class Bpmn_Shapes
    {
        [DefaultValue(null)]
        [HtmlAttributeName("type")]
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
        [DefaultValue(null)]
        [HtmlAttributeName("shape")]
        [JsonProperty("shape")]
        public string Shape
        {
            get;
            set;
        }
        [DefaultValue(null)]
        [HtmlAttributeName("activity")]
        [JsonProperty("activity")]
        public DiagramBpmnActivity Activity
        {
            get;
            set;
        }
        [DefaultValue(null)]
        [HtmlAttributeName("event")]
        [JsonProperty("event")]
        public DiagramBpmnEvent Event
        {
            get;
            set;
        }
        [DefaultValue(null)]
        [HtmlAttributeName("gateWay")]
        [JsonProperty("gateWay")]
        public DiagramBpmnGateway gateWay
        {
            get;
            set;
        }
        [DefaultValue(null)]
        [HtmlAttributeName("dataObject")]
        [JsonProperty("dataObject")]
        public DiagramBpmnDataObject dataObject
        {
            get;
            set;
        }
    }
}