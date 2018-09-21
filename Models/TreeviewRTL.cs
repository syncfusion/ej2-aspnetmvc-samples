using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Models
{
    public class TreeviewRTL
    {
        public int Id { get; set; }
        public int PId { get; set; }
        public string Name { get; set; }
        public bool HasChild { get; set; }
        public bool Expanded { get; set; }


        public List<TreeviewRTL> getTreeviewRTL()
        {
            List<TreeviewRTL> localData = new List<TreeviewRTL>();
            localData.Add(new TreeviewRTL { Id = 1, Name = "Discover Music", HasChild = true, Expanded = true });
            localData.Add(new TreeviewRTL { Id = 2, PId = 1, Name = "Hot Singles"});
            localData.Add(new TreeviewRTL { Id = 3, PId = 1, Name = "Rising Artists"});
            localData.Add(new TreeviewRTL { Id = 4, PId = 1, Name = "Live Music"});
            localData.Add(new TreeviewRTL { Id = 5, PId = 1, Name = "Best of 2013 So Far" });
            localData.Add(new TreeviewRTL { Id = 7, Name = "Sales and Events", HasChild = true, Expanded = true });
            localData.Add(new TreeviewRTL { Id = 8, PId = 7, Name = "100 Albums - $5 Each" });
            localData.Add(new TreeviewRTL { Id = 9, PId = 7, Name = "Hip-Hop and R&B Sale" });
            localData.Add(new TreeviewRTL { Id = 10, PId = 7, Name = "CD Deals" });
            localData.Add(new TreeviewRTL { Id = 11, Name = "Categories", HasChild = true });
            localData.Add(new TreeviewRTL { Id = 12, PId = 11, Name = "Songs" });
            localData.Add(new TreeviewRTL { Id = 13, PId = 11, Name = "Bestselling Albums" });
            localData.Add(new TreeviewRTL { Id = 13, PId = 11, Name = "Bestselling Albums" });
            localData.Add(new TreeviewRTL { Id = 14, PId = 11, Name = "New Releases" });
            localData.Add(new TreeviewRTL { Id = 15, PId = 11, Name = "Bestselling Songs" });
            return localData;
        }
    }
}