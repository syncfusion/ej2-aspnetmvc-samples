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
        
        public ActionResult qrcode()
        {
            List<ExpandOptionsqrcode> position = new List<ExpandOptionsqrcode>();
            position.Add(new ExpandOptionsqrcode() { text = "Low", value = "7" });
            position.Add(new ExpandOptionsqrcode() { text = "Medium", value = "15" });
            position.Add(new ExpandOptionsqrcode() { text = "Quartile", value = "25" });
            position.Add(new ExpandOptionsqrcode() { text = "High", value = "30" });

            ViewData["position"] = position;

         
           
            
            return View();
        }
    }

    public class ExpandOptionsqrcode
    {
        public string text;
        public string value;
    }
    
}