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
        
        public ActionResult UpcE()
        {
            List<ExpandOptionsUpcE> position = new List<ExpandOptionsUpcE>();
            position.Add(new ExpandOptionsUpcE() { text = "Bottom", value = "bottom" });
            position.Add(new ExpandOptionsUpcE() { text = "Top", value = "top" });

            ViewData["position"] = position;

            List<ExpandOptionsUpcE> alignment = new List<ExpandOptionsUpcE>();
            alignment.Add(new ExpandOptionsUpcE() { text = "Center", value = "Center" });
            alignment.Add(new ExpandOptionsUpcE() { text = "Left", value = "Left" });
            alignment.Add(new ExpandOptionsUpcE() { text = "Right", value = "Right" });

            ViewData["alignment"] = alignment;
            ViewData["expandValue"] = "Bottom";
           
            
            return View();
        }
    }

    public class ExpandOptionsUpcE
    {
        public string text;
        public string value;
    }
    
}