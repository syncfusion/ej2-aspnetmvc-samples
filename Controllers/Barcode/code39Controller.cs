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
        
        public ActionResult Code39()
        {
            List<ExpandOptionsCode39> position = new List<ExpandOptionsCode39>();
            position.Add(new ExpandOptionsCode39() { text = "Bottom", value = "bottom" });
            position.Add(new ExpandOptionsCode39() { text = "Top", value = "top" });

            ViewData["position"] = position;

            List<ExpandOptionsCode39> alignment = new List<ExpandOptionsCode39>();
            alignment.Add(new ExpandOptionsCode39() { text = "Center", value = "Center" });
            alignment.Add(new ExpandOptionsCode39() { text = "Left", value = "Left" });
            alignment.Add(new ExpandOptionsCode39() { text = "Right", value = "Right" });

            ViewData["alignment"] = alignment;
            ViewData["expandValue"] = "Bottom";
           
            
            return View();
        }
    }

    public class ExpandOptionsCode39
    {
        public string text;
        public string value;
    }
    
}