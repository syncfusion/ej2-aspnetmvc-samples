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
    public class ChildItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public bool Expanded { get; set; }

        public List<SubChildItem> SubChild;

    }
    public class SubChildItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public bool Expanded { get; set; }
    }
    public class DropDownTreeDefaultData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string ParentValue { get; set; }
        public bool Expanded { get; set; }
        public List<ChildItem> SubChild;

        public List<DropDownTreeDefaultData> getDropDownTreeDefaultData()
        {
            List<DropDownTreeDefaultData> DropDownTreeDefaultData = new List<DropDownTreeDefaultData>();
            List<ChildItem> childitem1 = new List<ChildItem>();
            List<SubChildItem> subchilditem1 = new List<SubChildItem>();
            DropDownTreeDefaultData.Add(new DropDownTreeDefaultData
            {
                Id = "01",
                Name = "Local Disk (C:)",
                Expanded = true,
                SubChild = childitem1,
            });
            childitem1.Add(new ChildItem
            {
                Id = "01-01",
                Name = "Program Files",
                SubChild = subchilditem1
            });
            subchilditem1.Add(new SubChildItem { Id = "01-01-01", Name = "Windows NT" });
            subchilditem1.Add(new SubChildItem { Id = "01-01-02", Name = "Windows Mail" });
            subchilditem1.Add(new SubChildItem { Id = "01-01-03", Name = "Windows Photo Viewer" });
            List<SubChildItem> subchilditem2 = new List<SubChildItem>();
            childitem1.Add(new ChildItem { Id = "01-02", Name = "Users", Expanded = true, SubChild = subchilditem2 });
            subchilditem2.Add(new SubChildItem { Id = "01-02-01", Name = "Smith" });
            subchilditem2.Add(new SubChildItem { Id = "01-02-02", Name = "Public" });
            subchilditem2.Add(new SubChildItem { Id = "01-02-03", Name = "Admin" });
            List<SubChildItem> subchilditem3 = new List<SubChildItem>();
            childitem1.Add(new ChildItem { Id = "01-03", Name = "Windows", SubChild = subchilditem3 });
            subchilditem3.Add(new SubChildItem { Id = "01-03-01", Name = "Boot" });
            subchilditem3.Add(new SubChildItem { Id = "01-03-02", Name = "FileManager" });
            subchilditem3.Add(new SubChildItem { Id = "01-03-03", Name = "System32" });
            List<ChildItem> childitem2 = new List<ChildItem>();
            DropDownTreeDefaultData.Add(new DropDownTreeDefaultData
            {
                Id = "02",
                Name = "Local Disk (D:)",
                SubChild = childitem2,
            });
            List<SubChildItem> subchilditem4 = new List<SubChildItem>();
            childitem2.Add(new ChildItem { Id = "02-01", Name = "Personals", SubChild = subchilditem4 });
            subchilditem4.Add(new SubChildItem { Id = "02-01-01", Name = "My photo.png" });
            subchilditem4.Add(new SubChildItem { Id = "02-01-02", Name = "Rental document.docx" });
            subchilditem4.Add(new SubChildItem { Id = "02-01-03", Name = "Pay slip.pdf" });
            List<SubChildItem> subchilditem5 = new List<SubChildItem>();
            childitem2.Add(new ChildItem { Id = "02-02", Name = "Projects", SubChild = subchilditem5 });
            subchilditem5.Add(new SubChildItem { Id = "02-02-01", Name = "ASP Application " });
            subchilditem5.Add(new SubChildItem { Id = "02-02-02", Name = "TypeScript Application" });
            subchilditem5.Add(new SubChildItem { Id = "02-02-03", Name = "React Application" });

            List<SubChildItem> subchilditem6 = new List<SubChildItem>();
            childitem2.Add(new ChildItem { Id = "02-02", Name = "Office", SubChild = subchilditem6 });
            subchilditem6.Add(new SubChildItem { Id = "02-03-01", Name = "Work details.docx " });
            subchilditem6.Add(new SubChildItem { Id = "02-03-02", Name = "Weekly report.docx" });
            subchilditem6.Add(new SubChildItem { Id = "02-03-03", Name = "Wish list.csv" });
            List<ChildItem> childitem3 = new List<ChildItem>();
            DropDownTreeDefaultData.Add(new DropDownTreeDefaultData
            {
                Id = "03",
                Name = "Local Disk (E:)",
                SubChild = childitem3,
            });

            List<SubChildItem> subchilditem7 = new List<SubChildItem>();
            childitem3.Add(new ChildItem { Id = "03-01", Name = "Pictures", SubChild = subchilditem7 });
            subchilditem7.Add(new SubChildItem { Id = "03-01-01", Name = "Wind.jpg " });
            subchilditem7.Add(new SubChildItem { Id = "03-01-02", Name = "Stone.jpg" });
            subchilditem7.Add(new SubChildItem { Id = "03-01-03", Name = "Home.jpg" });

            List<SubChildItem> subchilditem8 = new List<SubChildItem>();
            childitem3.Add(new ChildItem { Id = "03-02", Name = "Documents", Icon = "docx", SubChild = subchilditem8 });
            subchilditem8.Add(new SubChildItem { Id = "03-02-01", Name = "Environment Pollution.docx " });
            subchilditem8.Add(new SubChildItem { Id = "03-02-02", Name = "Global Warming.ppt" });
            subchilditem8.Add(new SubChildItem { Id = "03-02-03", Name = "Social Network.pdf" });

            List<SubChildItem> subchilditem9 = new List<SubChildItem>();
            childitem3.Add(new ChildItem { Id = "03-03", Name = "Study Materials", SubChild = subchilditem9 });
            subchilditem9.Add(new SubChildItem { Id = "03-03-01", Name = "UI-Guide.pdf" });
            subchilditem9.Add(new SubChildItem { Id = "03-03-02", Name = "Tutorials.zip" });
            subchilditem9.Add(new SubChildItem { Id = "03-03-03", Name = "TypeScript.7z" });

            return DropDownTreeDefaultData;
        }
    }
}