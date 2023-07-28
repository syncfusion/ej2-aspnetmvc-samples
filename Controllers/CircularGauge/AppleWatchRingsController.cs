#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
using Syncfusion.EJ2.CircularGauge;


namespace EJ2MVCSampleBrowser.Controllers.CircularGauge
{
    public partial class CircularGaugeController : Controller
    {
        // GET: AppleWatchRings
        public ActionResult AppleWatchRings()
        {
            ViewBag.Font = new CircularGaugeFont
            {
                FontFamily = "Roboto",
                Size = "0px",
                Color= "white",
                FontStyle= "Regular"
            };

            // Ranges //
            List<CircularGaugeRange> ranges = new List<CircularGaugeRange>();
            CircularGaugeRange range1 = new CircularGaugeRange();
            range1.Start = 0;
            range1.End = 100;
            range1.Radius = "90%";
            range1.StartWidth = "40";
            range1.EndWidth = "40";
            range1.Color = "#fa114f";
            range1.Opacity = 0.2;
            ranges.Add(range1);

            CircularGaugeRange range2 = new CircularGaugeRange();
            range2.Start = 0;
            range2.End = 100;
            range2.Radius = "68%";
            range2.StartWidth = "40";
            range2.EndWidth = "40";
            range2.Color = "#99ff01";
            range2.Opacity = 0.2;
            ranges.Add(range2);

            CircularGaugeRange range3 = new CircularGaugeRange();
            range3.Start = 0;
            range3.End = 100;
            range3.Radius = "46%";
            range3.StartWidth = "40";
            range3.EndWidth = "40";
            range3.Color = "#00d8fe";
            range3.Opacity = 0.2;
            ranges.Add(range3);
            ViewBag.Ranges = ranges;

            List <CircularGaugePointer> pointers = new List<CircularGaugePointer>();
            CircularGaugePointer pointer1 = new CircularGaugePointer();
            pointer1.RoundedCornerRadius = 25;
            pointer1.Value = 65;
            pointer1.Type = PointerType.RangeBar;
            pointer1.Radius = "90%";
            pointer1.Color = "#fa114f";
            pointer1.Animation = new CircularGaugeAnimation { Enable = true };
            pointer1.PointerWidth = 40;
            pointers.Add(pointer1);

            CircularGaugePointer pointer2 = new CircularGaugePointer();
            pointer2.RoundedCornerRadius = 25;
            pointer2.Value = 43;
            pointer2.Type = PointerType.RangeBar;
            pointer2.Radius = "68%";
            pointer2.Color = "#99ff01";
            pointer2.Animation = new CircularGaugeAnimation { Enable = true };
            pointer2.PointerWidth = 40;
            pointers.Add(pointer2);

            CircularGaugePointer pointer3 = new CircularGaugePointer();
            pointer3.RoundedCornerRadius = 25;
            pointer3.Value = 58;
            pointer3.Type = PointerType.RangeBar;
            pointer3.Radius = "46%";
            pointer3.Color = "#00d8fe";
            pointer3.Animation = new CircularGaugeAnimation { Enable = true };
            pointer3.PointerWidth = 40;
            pointers.Add(pointer3);
            ViewBag.Pointers = pointers;

            return View();
        }
    }
}