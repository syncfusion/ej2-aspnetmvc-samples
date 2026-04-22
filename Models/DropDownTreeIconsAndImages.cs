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

namespace EJ2MVCSampleBrowser.Models
{
    public class ChildItems
    {
        public string nodeId { get; set; }
        public string nodeText { get; set; }
        public string icon { get; set; }
        public bool expanded { get; set; }
        public List<SubChildItems> child;
    }
    public class SubChildItems
    {
        public string nodeId { get; set; }
        public string nodeText { get; set; }
        public string icon { get; set; }
        public bool expanded { get; set; }
        public string image { get; set; }
    }
    public class DropDownTreeIcons
    {
        public string nodeId { get; set; }
        public string nodeText { get; set; }
        public string icon { get; set; }
        public bool expanded { get; set; }
        public List<ChildItems> child;
       
        public List<DropDownTreeIcons> getIconsData()
        {
            List<DropDownTreeIcons> Parent = new List<DropDownTreeIcons>();
            List<ChildItems> Child1 = new List<ChildItems>();
            Parent.Add(new DropDownTreeIcons { nodeId = "01", nodeText = "Music", icon = "folder", child = Child1, });
            Child1.Add(new ChildItems { nodeId = "01-01", nodeText = "Gouttes.mp3", icon = "audio" });
            List<ChildItems> Child2 = new List<ChildItems>();
            Parent.Add(new DropDownTreeIcons { nodeId = "02", nodeText = "Videos", icon = "folder", child = Child2, });
            Child2.Add(new ChildItems { nodeId = "02-01", nodeText = "Naturals.mp4", icon = "video" });
            Child2.Add(new ChildItems { nodeId = "02-02", nodeText = "Wild.mpeg", icon = "video" });
            List<ChildItems> Child3 = new List<ChildItems>();
            Parent.Add(new DropDownTreeIcons { nodeId = "03", nodeText = "Documents", icon = "folder", child = Child3, });
            Child3.Add(new ChildItems { nodeId = "03-01", nodeText = "Environment Pollution.docx", icon = "docx" });
            Child3.Add(new ChildItems { nodeId = "03-02", nodeText = "Global Water, Sanitation, & Hygiene.docx", icon = "docx" });
            Child3.Add(new ChildItems { nodeId = "03-03", nodeText = "Global Warming.ppt", icon = "ppt" });
            Child3.Add(new ChildItems { nodeId = "03-04", nodeText = "Social Network.pdf", icon = "pdf" });
            Child3.Add(new ChildItems { nodeId = "03-05", nodeText = "Youth Empowerment.pdf", icon = "pdf" });
            List<ChildItems> Child4 = new List<ChildItems>();
            List<SubChildItems> SubChildren = new List<SubChildItems>();
            Parent.Add(new DropDownTreeIcons { nodeId = "04", nodeText = "Pictures", icon = "folder", child = Child4, expanded = true, });
            Child4.Add(new ChildItems { nodeId = "04-01", nodeText = "Camera Roll", icon = "folder", child = SubChildren, expanded = true });
            SubChildren.Add(new SubChildItems { nodeId = "04-01-01", nodeText = "WIN_20160726_094117.JPG", image = "../Content/treeview/images/Employees/2.png" });
            SubChildren.Add(new SubChildItems { nodeId = "04-01-02", nodeText = "WIN_20160726_094118.JPG", image = "../Content/treeview/images/Employees/9.png" });
            Child4.Add(new ChildItems { nodeId = "04-02", nodeText = "Wind.jpg", icon = "images" });
            Child4.Add(new ChildItems { nodeId = "04-03", nodeText = "Stone.jpg", icon = "images" });

            List<ChildItems> Child5 = new List<ChildItems>();
            Parent.Add(new DropDownTreeIcons { nodeId = "04", nodeText = "Downloads", icon = "folder", child = Child5, });
            Child5.Add(new ChildItems { nodeId = "04-01", nodeText = "UI-Guide.pdf", icon = "pdf" });
            Child5.Add(new ChildItems { nodeId = "04-02", nodeText = "Tutorials.zip", icon = "zip" });
            Child5.Add(new ChildItems { nodeId = "04-03", nodeText = "Game.exe", icon = "exe" });
            Child5.Add(new ChildItems { nodeId = "04-04", nodeText = "TypeScript.7z", icon = "zip" });
            return Parent;
        }
    }
}