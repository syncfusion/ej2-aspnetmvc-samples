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
    public class DropDownTreeMultiSelection
        {
        public List<Object> MultipleSelection()
        {
            List<object> parentitem = new List<object>();
            parentitem.Add(new { id = 1, name = "Australia", hasChild = true, expanded = true });
            parentitem.Add(new { id = 2, pid = 1, name = "New South Wales" });
            parentitem.Add(new { id = 3, pid = 1, name = "Victoria" });
            parentitem.Add(new { id = 4, pid = 1, name = "South Australia" });
            parentitem.Add(new { id = 6, pid = 1, name = "Western Australia" });
            parentitem.Add(new { id = 7, name = "Brazil", hasChild = true });
            parentitem.Add(new { id = 8, pid = 7, name = "Paraná" });
            parentitem.Add(new { id = 9, pid = 7, name = "Ceará" });
            parentitem.Add(new { id = 10, pid = 7, name = "Acre" });
            parentitem.Add(new { id = 11, name = "China", hasChild = true });
            parentitem.Add(new { id = 12, pid = 11, name = "Guangzhou" });
            parentitem.Add(new { id = 13, pid = 11, name = "Shanghai" });
            parentitem.Add(new { id = 14, pid = 11, name = "Beijing" });
            parentitem.Add(new { id = 15, pid = 11, name = "Shantou" });
            parentitem.Add(new { id = 16, name = "France", hasChild = true });
            parentitem.Add(new { id = 17, pid = 16, name = "Pays de la Loire" });
            parentitem.Add(new { id = 18, pid = 16, name = "Aquitaine" });
            parentitem.Add(new { id = 19, pid = 16, name = "Brittany" });
            parentitem.Add(new { id = 20, pid = 16, name = "Lorraine" });
            parentitem.Add(new { id = 21, name = "India", hasChild = true });
            parentitem.Add(new { id = 22, pid = 21, name = "Assam" });
            parentitem.Add(new { id = 23, pid = 21, name = "Bihar" });
            parentitem.Add(new { id = 24, pid = 21, name = "Tamil Nadu" });
            parentitem.Add(new { id = 25, pid = 21, name = "Punjab" });
            return parentitem;
        }
    }
}