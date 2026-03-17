#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
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
        // GET: MindMap
        public ActionResult MindMap()
        {
            ViewData["Nodes"] = MindMapDetails.GetAllRecords();

            List<DiagramUserHandle> handle = new List<DiagramUserHandle>();
            handle.Add(new DiagramUserHandle()
            {
                Name = "leftHandle",
                PathData = "M11.924,6.202 L4.633,6.202 L4.633,9.266 L0,4.633 L4.632,0 L4.632,3.551 L11.923,3.551 L11.923,6.202Z",
                Visible = true,
                BackgroundColor = "black",
                Offset = 1,
                Side = Side.Left,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new DiagramMargin() { Left = 0, Right = 10, Top = 0, Bottom = 0 },
                PathColor = "white"
            });
            handle.Add(new DiagramUserHandle()
            {
                Name = "delete",
                Visible = true,
                PathData = "M 7.04 22.13 L 92.95 22.13 L 92.95 88.8 C 92.95 91.92 91.55 94.58 88.76" +
                    "96.74 C 85.97 98.91 82.55 100 78.52 100 L 21.48 100 C 17.45 100 14.03 98.91 11.24 96.74 C 8.45 94.58 7.04" +
                    "91.92 7.04 88.8 z M 32.22 0 L 67.78 0 L 75.17 5.47 L 100 5.47 L 100 16.67 L 0 16.67 L 0 5.47 L 24.83 5.47 z",
                BackgroundColor = "black",
                Offset = 0.5,
                Side = Side.Top,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new DiagramMargin() { Left = 0, Right = 0, Top = 0, Bottom = 10 },
                PathColor = "white"
            });
            handle.Add(new DiagramUserHandle()
            {
                Name = "rightHandle",
                Visible = true,
                PathData = "M0,3.063 L7.292,3.063 L7.292,0 L11.924,4.633 L7.292,9.266 L7.292,5.714 L0.001,5.714 L0.001,3.063Z",
                BackgroundColor = "black",
                Offset = 1,
                Side = Side.Right,
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new DiagramMargin() { Left = 10, Right = 0, Top = 0, Bottom = 0 },
                PathColor = "white"
            });

            DiagramSelector userHandle = new DiagramSelector();
            userHandle.Constraints = SelectorConstraints.UserHandle;
            userHandle.UserHandles = handle;
            ViewData["selectedItems"] = userHandle;


            return View();
        }
    }
}