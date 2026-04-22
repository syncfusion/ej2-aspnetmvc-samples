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
    public class DropDownTreeFiltering
    {
        public List<Object> Filtering()
        {
            List<object> parentitem = new List<object>();
            parentitem.Add(new { id = 1, name = "Discover Music", hasChild = true, expanded = true });
            parentitem.Add(new { id = 2, pid = 1, name = "Hot Singles" });
            parentitem.Add(new { id = 3, pid = 1, name = "Rising Artists" });
            parentitem.Add(new { id = 4, pid = 1, name = "Live Music" });
            parentitem.Add(new { id = 7, name = "Sales and Events", hasChild = true });
            parentitem.Add(new { id = 8, pid = 7, name = "100 Albums - $5 Each" });
            parentitem.Add(new { id = 9, pid = 7, name = "Hip-Hop and R&B Sale" });
            parentitem.Add(new { id = 10, pid = 7, name = "CD Deals" });
            parentitem.Add(new { id = 11, name = "Categories", hasChild = true });
            parentitem.Add(new { id = 12, pid = 11, name = "Songs" });
            parentitem.Add(new { id = 13, pid = 11, name = "Bestselling Albums" });
            parentitem.Add(new { id = 14, pid = 11, name = "New Releases" });
            parentitem.Add(new { id = 15, pid = 11, name = "Bestselling Songs" });
            parentitem.Add(new { id = 16, name = "MP3 Albums", hasChild = true });
            parentitem.Add(new { id = 17, pid = 16, name = "Rock" });
            parentitem.Add(new { id = 18, pid = 16, name = "Gospel" });
            parentitem.Add(new { id = 19, pid = 16, name = "Latin Music" });
            parentitem.Add(new { id = 20, pid = 16, name = "Jazz" });
            parentitem.Add(new { id = 21, name = "More in Music", hasChild = true });
            parentitem.Add(new { id = 22, pid = 21, name = "Music Trade-In" });
            parentitem.Add(new { id = 23, pid = 21, name = "Redeem a Gift Card" });
            parentitem.Add(new { id = 24, pid = 21, name = "Band T-Shirts" });
            parentitem.Add(new { id = 25, name = "Fiction Book Lists", hasChild = true });
            parentitem.Add(new { id = 26, pid = 25, name = "To Kill a Mockingbird" });
            parentitem.Add(new { id = 27, pid = 25, name = "Pride and Prejudice" });
            parentitem.Add(new { id = 28, pid = 25, name = "Harry Potter" });
            parentitem.Add(new { id = 29, pid = 25, name = "The Hobbit" });
            return parentitem;
        }
    }
}