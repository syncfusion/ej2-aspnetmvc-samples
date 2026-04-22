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
using System.Web.Mvc;
using Syncfusion.EJ2.BarcodeGenerator;

namespace EJ2CoreSampleBrowser.Controllers.Barcode
{
    public partial class BarcodeController : Controller
    {
        
        public ActionResult Code128B()
        {
            List<ExpandOptionsCode128B> position = new List<ExpandOptionsCode128B>();
            position.Add(new ExpandOptionsCode128B() { text = "Bottom", value = "bottom" });
            position.Add(new ExpandOptionsCode128B() { text = "Top", value = "top" });

            ViewData["position"] = position;

            List<ExpandOptionsCode128B> alignment = new List<ExpandOptionsCode128B>();
            alignment.Add(new ExpandOptionsCode128B() { text = "Center", value = "Center" });
            alignment.Add(new ExpandOptionsCode128B() { text = "Left", value = "Left" });
            alignment.Add(new ExpandOptionsCode128B() { text = "Right", value = "Right" });

            ViewData["alignment"] = alignment;
            ViewData["expandValue"] = "Bottom";
            return View();
        }
    }

    public class ExpandOptionsCode128B
    {
        public string text;
        public string value;
    }
    
}