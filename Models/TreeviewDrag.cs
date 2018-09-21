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
            localData1.Add(new TreeviewDrag { Id = "t1", Name = "Web Team", HasChild = true, Expanded = true });
            localData1.Add(new TreeviewDrag { Id = "t2", PId = "t1", Name = "Joshua" });
            localData1.Add(new TreeviewDrag { Id = "t3", PId = "t1", Name = "Matthew" });
            localData1.Add(new TreeviewDrag { Id = "t4", PId = "t1", Name = "David" });
            localData1.Add(new TreeviewDrag { Id = "t5", HasChild = true, Name = "Build Team", Expanded = true });
            localData1.Add(new TreeviewDrag { Id = "t6", PId = "t5", Name = "Ryan" });
            localData1.Add(new TreeviewDrag { Id = "t7", PId = "t5", Name = "Justin" });
            localData1.Add(new TreeviewDrag { Id = "t8", PId = "t5", Name = "Robert" });
            return localData1;
        }
    }
}
            