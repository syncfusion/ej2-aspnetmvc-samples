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
    public class TreeviewDrag
    {
        public string Id { get; set; }
        public string PId { get; set; }
        public string Name { get; set; }
        public bool HasChild { get; set; }
        public bool Expanded { get; set; }

        public List<TreeviewDrag> getTreeviewDrag()
        {
            List<TreeviewDrag> localData1 = new List<TreeviewDrag>();
            localData1.Add(new TreeviewDrag { Id = "01", Name = "Web Team", HasChild = true, Expanded = true });
            localData1.Add(new TreeviewDrag { Id = "02", PId = "01", Name = "Joshua" });
            localData1.Add(new TreeviewDrag { Id = "03", PId = "01", Name = "Matthew" });
            localData1.Add(new TreeviewDrag { Id = "04", PId = "01", Name = "David" });
            localData1.Add(new TreeviewDrag { Id = "05", HasChild = true, Name = "Build Team", Expanded = true });
            localData1.Add(new TreeviewDrag { Id = "06", PId = "05", Name = "Ryan" });
            localData1.Add(new TreeviewDrag { Id = "07", PId = "05", Name = "Justin" });
            localData1.Add(new TreeviewDrag { Id = "08", PId = "05", Name = "Robert" });
            return localData1;
        }
    }
}
            