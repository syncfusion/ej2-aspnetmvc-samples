using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EJ2MVCSampleBrowser.Models
{
    public class colorMapping
    {
        public colorMapping(string value, string color, string label)
        {
            this.color = color;
            this.value = value;
            this.label = label;
        }

        public colorMapping(int from, int to, string color, string label)
        {
            this.from = from;
            this.to = to;
            this.color = color;
            this.label = label;
        }

        public int from { get; set; }

        public int to { get; set; }

        public string value { get; set; }

        public string color { get; set; }

        public string label { get; set; }
    }
}