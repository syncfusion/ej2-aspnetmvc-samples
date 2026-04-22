#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
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
        public int spaceBetweenParticipants { get; set; }
        public List<object> participants { get; set; }
        public List<object> messages { get; set; }
        public List<object> fragments { get; set; }
        // GET: SequenceDiagram
        public ActionResult SequenceDiagram()
        {

            object SequenceModel = new 
            {
                spaceBetweenParticipants = 250,
                participants = new List<object>
                {
                    new {
                        id = "User",
                        content = "User",
                        isActor = true
                    },
                    new {
                        id = "Transaction",
                        content = "Transaction",
                        activationBoxes = new List<object>
                        {
                            new { id = "act1", startMessageID = "msg1", endMessageID = "msg4" }
                        }
                    },
                    new {
                        id = "FraudDetectionSystem",
                        content = "Fraud Detection System",
                        activationBoxes = new List<object>
                        {
                            new { id = "act2", startMessageID = "msg2", endMessageID = "msg3" },
                            new { id = "act3", startMessageID = "msg5", endMessageID = "msg6" }
                        }
                    }
                },
                messages = new List<object>
                {
                    new { id = "msg1", content = "Initiate Transaction", fromParticipantID = "User", toParticipantID = "Transaction", type = "Synchronous" },
                    new { id = "msg2", content = "Send Transaction Data", fromParticipantID = "Transaction", toParticipantID = "FraudDetectionSystem", type = "Synchronous" },
                    new { id = "msg3", content = "Validate Transaction", fromParticipantID = "FraudDetectionSystem", toParticipantID = "Transaction", type = "Reply" },
                    new { id = "msg4", content = "Transaction Approved", fromParticipantID = "Transaction", toParticipantID = "User", type = "Asynchronous" },
                    new { id = "msg5", content = "Flag Transaction", fromParticipantID = "Transaction", toParticipantID = "FraudDetectionSystem", type = "Synchronous" },
                    new { id = "msg6", content = "Fraud Detected", fromParticipantID = "FraudDetectionSystem", toParticipantID = "User", type = "Reply" },
                    new { id = "msg7", content = "Cancel Transaction", fromParticipantID = "User", toParticipantID = "Transaction", type = "Synchronous" },
                    new { id = "msg8", content = "Complete Transaction", fromParticipantID = "User", toParticipantID = "Transaction", type = "Synchronous" }
                },
                fragments = new List<object>
                {
                    new {
                        id = "1",
                        type = "Alternative",
                        conditions = new List<object>
                        {
                            new { content = "Fraud Detected", messageIds = new List<string> { "msg5", "msg6", "msg7" } },
                            new { content = "No Fraud Detected", messageIds = new List<string> { "msg8" } }
                        }
                    }
                }
            };

            ViewData["SequenceModel"] = SequenceModel;
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