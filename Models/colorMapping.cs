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