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
    public class DropDownTreeLocalData
    {
        public int Id { get; set; }
        public int? PId { get; set; }
        public string Name { get; set; }
        public bool HasChild { get; set; }
        public bool Expanded { get; set; }

        public List<DropDownTreeLocalData> getDropDownTreeLocalData()
        {
            List<DropDownTreeLocalData> localData = new List<DropDownTreeLocalData>();
            localData.Add(new DropDownTreeLocalData { Id = 1, Name = "Discover Music", HasChild = true, Expanded = true });
            localData.Add(new DropDownTreeLocalData { Id = 2, PId = 1, Name = "Hot Singles" });
            localData.Add(new DropDownTreeLocalData { Id = 3, PId = 1, Name = "Rising Artists" });
            localData.Add(new DropDownTreeLocalData { Id = 4, PId = 1, Name = "Live Music" });
            localData.Add(new DropDownTreeLocalData { Id = 7, Name = "Sales and Events", HasChild = true });
            localData.Add(new DropDownTreeLocalData { Id = 8, PId = 7, Name = "100 Albums - $5 Each" });
            localData.Add(new DropDownTreeLocalData { Id = 9, PId = 7, Name = "Hip-Hop and R&B Sale" });
            localData.Add(new DropDownTreeLocalData { Id = 10, PId = 7, Name = "CD Deals" });
            localData.Add(new DropDownTreeLocalData { Id = 11, Name = "Categories", HasChild = true });
            localData.Add(new DropDownTreeLocalData { Id = 12, PId = 11, Name = "Songs" });
            localData.Add(new DropDownTreeLocalData { Id = 13, PId = 11, Name = "Bestselling Albums" });
            localData.Add(new DropDownTreeLocalData { Id = 14, PId = 11, Name = "New Releases" });
            localData.Add(new DropDownTreeLocalData { Id = 15, PId = 11, Name = "Bestselling Songs" });
            localData.Add(new DropDownTreeLocalData { Id = 16, Name = "MP3 Albums", HasChild= true });
            localData.Add(new DropDownTreeLocalData { Id = 17,PId = 16, Name = "Rock"});
            localData.Add(new DropDownTreeLocalData { Id = 18, PId = 16, Name = "Gospel" });
            localData.Add(new DropDownTreeLocalData { Id = 19, PId = 16, Name = "Latin Music" });
            localData.Add(new DropDownTreeLocalData { Id = 20, PId = 16, Name = "Jazz" });
            localData.Add(new DropDownTreeLocalData { Id = 21, Name = "More in Music", HasChild = true });
            localData.Add(new DropDownTreeLocalData { Id = 22, PId = 21, Name = "Music Trade-In" });
            localData.Add(new DropDownTreeLocalData { Id = 23, PId = 21, Name = "Redeem a Gift Card" });
            localData.Add(new DropDownTreeLocalData { Id = 24, PId = 21, Name = "Band T-Shirts" });
            localData.Add(new DropDownTreeLocalData { Id = 25, Name = "Fiction Book Lists", HasChild = true });
            localData.Add(new DropDownTreeLocalData { Id = 26, PId = 25, Name = "To Kill a Mockingbird" });
            localData.Add(new DropDownTreeLocalData { Id = 27, PId = 25, Name = "Pride and Prejudice" });
            localData.Add(new DropDownTreeLocalData { Id = 28, PId = 25, Name = "Harry Potter" });
            localData.Add(new DropDownTreeLocalData { Id = 29, PId = 25, Name = "The Hobbit" });
            return localData;
        }

    }
}