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
    public class DropDownModel
    {
        public object scrollFormats()
        {

            List<object> scrollFormats = new List<object>();

            scrollFormats.Add(new

            {

                text = "Infinity",

                value = "Infinity"

            });

            scrollFormats.Add(new

            {

                text = "Diagram",

                value = "Diagram"

            });

            scrollFormats.Add(new

            {

                text = "Limited",

                value = "Limited"

            });

            return scrollFormats;

        }
    }
}