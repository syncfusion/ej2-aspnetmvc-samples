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
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Models
{
    public class ImageIcons
    {
        public string NodeText { get; set; }
        public string Icon { get; set; }
        public string NodeId { get; set; }
       
    }

    public class TreeviewImageIcons
    {
        public string NodeText { get; set; }
        public string Icon { get; set; }
        public string NodeId { get; set; }
        public bool Expanded { get; set; }
        public List<ImageIcons> NodeChild;

        public List<TreeviewImageIcons> getTreeviewImageIconsModel()
        {
            List<TreeviewImageIcons> TreeviewImageIcons = new List<TreeviewImageIcons>();
            List<ImageIcons> ImageIcons = new List<ImageIcons>();

            TreeviewImageIcons.Add(new TreeviewImageIcons
            {
                NodeId = "01",
                NodeText = "Music",
                Icon = "folder",
                NodeChild = ImageIcons,
            });
            ImageIcons.Add(new ImageIcons { NodeId = "01-01", NodeText = "Gouttes.mp3",Icon= "audio" });
            List<ImageIcons> ImageIcons2 = new List<ImageIcons>();
            TreeviewImageIcons.Add(new TreeviewImageIcons
            {
                NodeId = "02",
                NodeText = "Videos",
                Icon = "folder",
                NodeChild = ImageIcons2,
            });
            ImageIcons2.Add(new ImageIcons { NodeId = "02-01", NodeText = "Naturals.mp4", Icon = "video" });
            ImageIcons2.Add(new ImageIcons { NodeId = "02-02", NodeText = "Wild.mpeg", Icon = "video" });

            List<ImageIcons> ImageIcons3 = new List<ImageIcons>();
            TreeviewImageIcons.Add(new TreeviewImageIcons
            {
                NodeId = "03",
                NodeText = "Documents",
                Icon = "folder",
                Expanded = true,
                NodeChild = ImageIcons3,
            });
            ImageIcons3.Add(new ImageIcons { NodeId = "03-01", NodeText = "Environment Pollution.docx", Icon = "docx" });
            ImageIcons3.Add(new ImageIcons { NodeId = "03-02", NodeText = "Global Water, Sanitation, & Hygiene.docx", Icon = "docx" });
            ImageIcons3.Add(new ImageIcons { NodeId = "03-03", NodeText = "Global Warming.ppt", Icon = "ppt" });
            ImageIcons3.Add(new ImageIcons { NodeId = "03-04", NodeText = "Social Network.pdf", Icon = "pdf" });
            ImageIcons3.Add(new ImageIcons { NodeId = "03-05", NodeText = "Youth Empowerment.pdf", Icon = "pdf" });

            List<ImageIcons> ImageIcons4 = new List<ImageIcons>();
            TreeviewImageIcons.Add(new TreeviewImageIcons
            {
                NodeId = "04",
                NodeText = "Pictures",
                Icon = "folder",
                NodeChild = ImageIcons4,
            });
            ImageIcons4.Add(new ImageIcons { NodeId = "04-01", NodeText = "Camera Roll", Icon = "folder" });
            ImageIcons4.Add(new ImageIcons { NodeId = "04-02", NodeText = "Wind.jpg", Icon = "images" });
            ImageIcons4.Add(new ImageIcons { NodeId = "04-03", NodeText = "Stone.jpg", Icon = "images" });

            List<ImageIcons> ImageIcons5 = new List<ImageIcons>();
            TreeviewImageIcons.Add(new TreeviewImageIcons
            {
                NodeId = "05",
                NodeText = "Downloads",
                Icon = "folder",
                NodeChild = ImageIcons5,

            });
            ImageIcons5.Add(new ImageIcons { NodeId = "05-01", NodeText = "UI-Guide.pdf", Icon = "pdf" });
            ImageIcons5.Add(new ImageIcons { NodeId = "05-02", NodeText = "Tutorials.zip", Icon = "zip" });
            ImageIcons5.Add(new ImageIcons { NodeId = "05-03", NodeText = "Game.exe", Icon = "exe" });
            ImageIcons5.Add(new ImageIcons { NodeId = "05-04", NodeText = "TypeScript.7z", Icon = "zip" });
            return TreeviewImageIcons;
        }
    }
}