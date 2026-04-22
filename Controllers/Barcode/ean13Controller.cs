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
        
        public ActionResult Ean13()
        {
            List<ExpandOptionsEan13> position = new List<ExpandOptionsEan13>();
            position.Add(new ExpandOptionsEan13() { text = "Bottom", value = "bottom" });
            position.Add(new ExpandOptionsEan13() { text = "Top", value = "top" });

            ViewData["position"] = position;

            List<ExpandOptionsEan13> alignment = new List<ExpandOptionsEan13>();
            alignment.Add(new ExpandOptionsEan13() { text = "Center", value = "Center" });
            alignment.Add(new ExpandOptionsEan13() { text = "Left", value = "Left" });
            alignment.Add(new ExpandOptionsEan13() { text = "Right", value = "Right" });

            ViewData["alignment"] = alignment;
            ViewData["expandValue"] = "Bottom";
           
            
            return View();
        }
    }

    public class ExpandOptionsEan13
    {
        public string text;
        public string value;
    }
    
}