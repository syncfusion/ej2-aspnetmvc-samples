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
    public class TreeviewTemplate
    {
        public string name { get; set; }
        public string count { get; set; }
        public int id { get; set; }

        public int pid { get; set; }
        public bool HasChild { get; set; }
        public bool Expanded { get; set; }

        public bool Selected { get; set; }
        public List<TreeviewTemplate> getTreeviewTemplate()
        {
            List<TreeviewTemplate> localData = new List<TreeviewTemplate>();
            localData.Add(new TreeviewTemplate { id = 1, name = "Favorites", HasChild = true});
            localData.Add(new TreeviewTemplate { id = 2, pid = 1, name = "Sales Reports", count = "4" });
            localData.Add(new TreeviewTemplate { id = 3, pid = 1, name = "Sent Items"});
            localData.Add(new TreeviewTemplate { id = 4, pid = 1, name = "Marketing Reports ", count = "6" });
            localData.Add(new TreeviewTemplate { id = 5, name = "My Folder", HasChild = true, Expanded = true });
            localData.Add(new TreeviewTemplate { id = 6, pid = 5, name = "Inbox", Selected = true, count = "20" });
            localData.Add(new TreeviewTemplate { id = 7, pid = 5, name = "Drafts", count = "5" });
            localData.Add(new TreeviewTemplate { id = 8, pid = 5, name = "Deleted Items" });
            localData.Add(new TreeviewTemplate { id = 9, pid = 5, name = "Sent Items" });
            localData.Add(new TreeviewTemplate { id = 10, pid = 5, name = "Sales Reports", count = "4" });
            localData.Add(new TreeviewTemplate { id = 11, pid = 5, name = "Marketing Reports", count = "6" });
            localData.Add(new TreeviewTemplate { id = 12, pid = 5, name = "Outbox" });
            return localData;
           
   
        }
    }
}