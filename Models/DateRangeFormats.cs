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
    public class DateRangeFormats
    {
        public string Id { get; set; }
        public string Text { get; set; }

        public List<DateRangeFormats> GetDateFormatsWithId()
        {
            return new List<DateRangeFormats>
            {
                new DateRangeFormats { Id = "format1", Text = "dd/MMM/yy hh:mm a" },
                new DateRangeFormats { Id = "format2", Text = "yyyy-MM-dd" },
                new DateRangeFormats { Id = "format3", Text = "dd-MMMM-yyyy" },
                new DateRangeFormats { Id = "format4", Text = "yyyy/MM/dd HH:mm" }
            };
        }

        public string[] GetInputFormats()
        {
            return new string[]
            {
                "dd/MM/yyyy", "ddMMMyy", "yyyyMMdd", "dd.MM.yy", "MM/dd/yyyy", "yyyy/MMM/dd", "dd-MM-yyyy"
            };
        }
    }
}