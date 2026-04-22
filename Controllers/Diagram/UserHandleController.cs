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
        // GET: UserHandle
        public ActionResult UserHandle()
        {
            List<Syncfusion.EJ2.Diagrams.DiagramNode> nodes = new List<Syncfusion.EJ2.Diagrams.DiagramNode>();
            List<DiagramNodeAnnotation> Node1 = new List<DiagramNodeAnnotation>();
            Node1.Add(new DiagramNodeAnnotation() { Content = "New idea identified", Style = new DiagramTextStyle() { Color = "White" } });
            List<DiagramNodeAnnotation> Node2 = new List<DiagramNodeAnnotation>();
            Node2.Add(new DiagramNodeAnnotation() { Content = "Meeting with board", Style = new DiagramTextStyle() { Color = "White" } });
            List<DiagramNodeAnnotation> Node3 = new List<DiagramNodeAnnotation>();
            Node3.Add(new DiagramNodeAnnotation() { Content = "Board decides \n whether to proceed", Style = new DiagramTextStyle() { Color = "White" } });
            List<DiagramNodeAnnotation> Node4 = new List<DiagramNodeAnnotation>();
            Node4.Add(new DiagramNodeAnnotation() { Content = "Find Project manager", Style = new DiagramTextStyle() { Color = "White" } });
            List<DiagramNodeAnnotation> Node5 = new List<DiagramNodeAnnotation>();
            Node5.Add(new DiagramNodeAnnotation() { Content = "Implement and Deliver", Style = new DiagramTextStyle() { Color = "White" } });
            List<DiagramNodeAnnotation> Node6 = new List<DiagramNodeAnnotation>();
            Node6.Add(new DiagramNodeAnnotation() { Content = "Decision process for new software ideas", Style = new DiagramTextStyle() { Color = "White" } });
            List<DiagramNodeAnnotation> Node7 = new List<DiagramNodeAnnotation>();
            Node7.Add(new DiagramNodeAnnotation() { Content = "Reject", Style = new DiagramTextStyle() { Color = "White" } });
            List<DiagramNodeAnnotation> Node8 = new List<DiagramNodeAnnotation>();
            Node8.Add(new DiagramNodeAnnotation() { Content = "Hire new resources", Style = new DiagramTextStyle() { Color = "White" } });

            nodes.Add(new UserHandleNode()
            {
                Id = "NewIdea",
                OffsetX = 200,
                OffsetY = 60,
                Annotations = Node1,
                Shape = new { type = "Flow", shape = "Terminator" }
            });
            nodes.Add(new UserHandleNode()
            {
                Id = "Meeting",
                OffsetX = 200,
                OffsetY = 155,
                Annotations = Node2,
                Shape = new { type = "Flow", shape = "Process" }
            });
            nodes.Add(new UserHandleNode()
            {
                Id = "BoardDecision",
                OffsetX = 200,
                OffsetY = 280,
                Annotations = Node3,
                Height = 110,
                MaxHeight = 110,
                Shape = new { type = "Flow", shape = "Decision" }
            });
            nodes.Add(new UserHandleNode()
            {
                Id = "Project",
                OffsetX = 200,
                OffsetY = 430,
                Annotations = Node4,
                Height = 100,
                MaxHeight = 100,
                Shape = new { type = "Flow", shape = "Decision" }
            });
            nodes.Add(new UserHandleNode()
            {
                Id = "End",
                OffsetX = 200,
                OffsetY = 555,
                Annotations = Node5,
                Shape = new { type = "Flow", shape = "Process" }
            });
            nodes.Add(new UserHandleNode()
            {
                Id = "Decision",
                Width = 250,
                OffsetX = 450,
                OffsetY = 60,
                Annotations = Node6,
                Shape = new { type = "Flow", shape = "Card" }
            });
            nodes.Add(new UserHandleNode()
            {
                Id = "Reject",
                OffsetX = 450,
                OffsetY = 280,
                Annotations = Node7,
                Shape = new { type = "Flow", shape = "Process" }
            });
            nodes.Add(new UserHandleNode()
            {
                Id = "Resources",
                OffsetX = 450,
                OffsetY = 430,
                Annotations = Node8,
                Shape = new { type = "Flow", shape = "Process" }
            });

            List<DiagramConnector> Connectors = new List<DiagramConnector>();
            Connectors.Add(new DiagramConnector() { Id = "connector1", SourceID = "NewIdea", TargetID = "Meeting", Type = Segments.Straight });
            Connectors.Add(new DiagramConnector() { Id = "connector2", SourceID = "Meeting", TargetID = "BoardDecision", Type = Segments.Straight });
            Connectors.Add(new DiagramConnector() { Id = "connector3", SourceID = "BoardDecision", TargetID = "Project", Type = Segments.Straight });
            Connectors.Add(new DiagramConnector() { Id = "connector4", SourceID = "Project", TargetID = "End", Type = Segments.Straight });
            Connectors.Add(new DiagramConnector() { Id = "connector5", SourceID = "BoardDecision", TargetID = "Reject", Type = Segments.Straight });
            Connectors.Add(new DiagramConnector() { Id = "connector6", SourceID = "Project", TargetID = "Resources", Type = Segments.Straight });


            List<DiagramUserHandle> Userhandle = new List<DiagramUserHandle>();
            Userhandle.Add(new DiagramUserHandle()
            {
                Name = "clone",
                PathData = "M60.3,18H27.5c-3,0-5.5,2.4-5.5,5.5v38.2h5.5V23.5h32.7V18z M68.5,28.9h-30c-3," +
        "0-5.5,2.4-5.5,5.5v38.2c0,3,2.4,5.5,5.5,5.5h30c3,0,5.5-2.4,5.5-5.5V34.4C73.9,31.4,71.5,28.9,68.5,28.9z " +
        "M68.5,72.5h-30V34.4h30V72.5z",
                Visible = true,
                Offset = 0,
                Side = Side.Bottom,
                Margin = new DiagramMargin() { Left = 0, Right = 0, Top = 0, Bottom = 0 }
            });

            DiagramSelector selector = new DiagramSelector();
            selector.Constraints = SelectorConstraints.UserHandle;
            selector.UserHandles = Userhandle;
            ViewData["selector"] = selector;

            ViewData["connectors"] = Connectors;
            ViewData["userhandle"] = Userhandle;

            ViewData["nodes"] = nodes;
            return View();
        }
    }
    public class UserHandleNode : Syncfusion.EJ2.Diagrams.DiagramNode
    {
        public UserHandleNode()
        {
            this.Width = 150;
            this.Height = 60;

        }
    }

}