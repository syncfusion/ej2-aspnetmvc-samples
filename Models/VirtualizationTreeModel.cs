using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Models
{
    public class VirtualizationTreeModel
    {
        public int Id { get; set; }

        public int? PId { get; set; }

        public string Name { get; set; }

        public bool HasChild { get; set; }

        public bool IsChecked { get; set; }

        public bool IsExpanded { get; set; }
    }
}