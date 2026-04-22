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
        
        public ActionResult Code32()
        {
            List<ExpandOptionsCode32> position = new List<ExpandOptionsCode32>();
            position.Add(new ExpandOptionsCode32() { text = "Bottom", value = "bottom" });
            position.Add(new ExpandOptionsCode32() { text = "Top", value = "top" });

            ViewData["position"] = position;

            List<ExpandOptionsCode32> alignment = new List<ExpandOptionsCode32>();
            alignment.Add(new ExpandOptionsCode32() { text = "Center", value = "Center" });
            alignment.Add(new ExpandOptionsCode32() { text = "Left", value = "Left" });
            alignment.Add(new ExpandOptionsCode32() { text = "Right", value = "Right" });

            ViewData["alignment"] = alignment;
            ViewData["expandValue"] = "Bottom";
           
            
            return View();
        }
    }

    public class ExpandOptionsCode32
    {
        public string text;
        public string value;
    }
    
}