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
    public class TreeviewMultiSelect
    {
        public int Id { get; set; }
        public int PId { get; set; }
        public string Name { get; set; }
        public bool HasChild { get; set; }
        public bool Expanded { get; set; }

        public bool Selected { get; set; }

        public List<TreeviewMultiSelect> getTreeviewMultiSelect()
        {
            List<TreeviewMultiSelect> localData = new List<TreeviewMultiSelect>();
            localData.Add(new TreeviewMultiSelect { Id = 1, Name = "Australia", HasChild = true, Expanded = true });
            localData.Add(new TreeviewMultiSelect { Id = 2, PId = 1, Name = "New South Wales" });
            localData.Add(new TreeviewMultiSelect { Id = 3, PId = 1, Name = "Victoria",Selected = true });
            localData.Add(new TreeviewMultiSelect { Id = 4, PId = 1, Name = "South Australia", Selected = true });
            localData.Add(new TreeviewMultiSelect { Id = 6, PId = 1, Name = "Western Australia" });
            localData.Add(new TreeviewMultiSelect { Id = 7, Name = "Brazil", HasChild = true });
            localData.Add(new TreeviewMultiSelect { Id = 8, PId = 7, Name = "Paraná" });
            localData.Add(new TreeviewMultiSelect { Id = 9, PId = 7, Name = "Ceará" });
            localData.Add(new TreeviewMultiSelect { Id = 10, PId = 7, Name = "Acre" });
            localData.Add(new TreeviewMultiSelect { Id = 11, Name = "China", HasChild = true });
            localData.Add(new TreeviewMultiSelect { Id = 12, PId = 11, Name = "Guangzhou" });
            localData.Add(new TreeviewMultiSelect { Id = 13, PId = 11, Name = "Shanghai" });
            localData.Add(new TreeviewMultiSelect { Id = 14, PId = 11, Name = "Beijing" });
            localData.Add(new TreeviewMultiSelect { Id = 15, PId = 11, Name = "Shantou" });
            localData.Add(new TreeviewMultiSelect { Id = 16, Name = "France", HasChild = true });
            localData.Add(new TreeviewMultiSelect { Id = 17, PId = 16, Name = "Pays de la Loire" });
            localData.Add(new TreeviewMultiSelect { Id = 18, PId = 16, Name = "Aquitaine" });
            localData.Add(new TreeviewMultiSelect { Id = 19, PId = 16, Name = "Brittany" });
            localData.Add(new TreeviewMultiSelect { Id = 20, PId = 16, Name = "Lorraine" });
            localData.Add(new TreeviewMultiSelect { Id = 21, Name = "India", HasChild = true });
            localData.Add(new TreeviewMultiSelect { Id = 22, PId = 21, Name = "Assam" });
            localData.Add(new TreeviewMultiSelect { Id = 23, PId = 21, Name = "Bihar" });
            localData.Add(new TreeviewMultiSelect { Id = 24, PId = 21, Name = "Tamil Nadu" });
            localData.Add(new TreeviewMultiSelect { Id = 25, PId = 21, Name = "Punjab" });  
            return localData;
        }
    }
}