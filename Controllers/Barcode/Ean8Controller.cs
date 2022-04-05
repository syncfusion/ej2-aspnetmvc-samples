#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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
        
        public ActionResult Ean8()
        {
            List<ExpandOptions> position = new List<ExpandOptions>();
            position.Add(new ExpandOptions() { text = "Bottom", value = "bottom" });
            position.Add(new ExpandOptions() { text = "Top", value = "top" });

            ViewBag.position = position;

            List<ExpandOptions> alignment = new List<ExpandOptions>();
            alignment.Add(new ExpandOptions() { text = "Center", value = "Center" });
            alignment.Add(new ExpandOptions() { text = "Left", value = "Left" });
            alignment.Add(new ExpandOptions() { text = "Right", value = "Right" });

            ViewBag.alignment = alignment;
            ViewBag.expandValue = "Bottom";
            return View();
        }
    }

    public class ExpandOptions
    {
        public string text;
        public string value;
    }
   
}