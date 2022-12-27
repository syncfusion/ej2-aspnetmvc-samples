#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.EJ2.CircularGauge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.CircularGauge
{
    public partial class CircularGaugeController : Controller
    {
        // GET: Campass
        public ActionResult GradientColor()
        {

            // Pointers //
            List<CircularGaugePointer> pointers = new List<CircularGaugePointer>();
            CircularGaugePointer pointer1 = new CircularGaugePointer();
            pointer1.Value = 65;
            pointer1.Radius = "85%";
            pointer1.Color = "#E63B86";
            pointer1.PointerWidth = 12;
            pointer1.NeedleStartWidth = 2;
            pointer1.Cap = new CircularGaugeCap { Radius= 12, Border = new CircularGaugeBorder { Width = 2.5, Color= "#E63B86" }, Color= "white"  };
            pointer1.NeedleStartWidth = 2;
            pointer1.NeedleTail = new CircularGaugeNeedleTail { Length = "0%" };
            pointer1.Animation = new CircularGaugeAnimation{ Enable = false };
            pointers.Add(pointer1);            
            ViewBag.Pointers = pointers;

            // Ranges //
            List<CircularGaugeRange> ranges = new List<CircularGaugeRange>();
            CircularGaugeRange range1 = new CircularGaugeRange();
            range1.Start = 0;
            range1.End = 120 ;
            range1.StartWidth = "18";
            range1.EndWidth = "18";
            range1.Color = "#E63B86";
            range1.RoundedCornerRadius = 10;
            ranges.Add(range1);
            ViewBag.Ranges = ranges;
            return View();
        }
    }
}