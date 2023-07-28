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
        // GET: MultipleAxis
        public ActionResult MultipleAxis()
        {
            List<CircularGaugeAxis> axes = new List<CircularGaugeAxis>();
            CircularGaugeAxis axis1 = new CircularGaugeAxis();
            axis1.LineStyle = new CircularGaugeLine{ Width = 1.5};
            axis1.Radius = "95%";
            axis1.LabelStyle = new CircularGaugeLabel
            {
                Position = Position.Inside,
                AutoAngle = true,
                HiddenLabel =HiddenLabel.None
            };
            axis1.MajorTicks = new CircularGaugeTick
            {
                Position = Position.Inside,
                Width = 2,
                Height = 10
            };
            axis1.MinorTicks = new CircularGaugeTick
            {
                Position = Position.Inside,
                Width =2,
                Height=5
            };
            axis1.Minimum = 0;
            axis1.Maximum = 160;
            axis1.StartAngle = 220;
            axis1.EndAngle = 140;
            List<CircularGaugePointer> pointers = new List<CircularGaugePointer>();
            CircularGaugePointer pointer1 = new CircularGaugePointer();
            pointer1.Value = 80;
            pointer1.Radius = "100%";
            pointer1.MarkerHeight = 15;
            pointer1.MarkerWidth = 15;
            pointer1.Type = PointerType.Marker;
            pointer1.MarkerShape = GaugeShape.Triangle;
            pointers.Add(pointer1);
            axis1.Pointers = pointers;

            axes.Add(axis1);

            CircularGaugeAxis axis2 = new CircularGaugeAxis();
            axis2.LineStyle = new CircularGaugeLine{ Width = 1.5, Color = "#E84011" };
            axis2.Radius = "95%";
            axis2.LabelStyle = new CircularGaugeLabel
            {
                Position = Position.Outside,
                AutoAngle = true,
                HiddenLabel = HiddenLabel.None,
                Font = new CircularGaugeFont { Color = "#E84011" }
            };
            axis2.MajorTicks = new CircularGaugeTick
            {
                Position = Position.Outside,
                Width = 2,
                Height = 10,
                Color = "#E84011"
            };
            axis2.MinorTicks = new CircularGaugeTick
            {
                Position = Position.Outside,
                Width = 2,
                Height = 5,
                Color = "#E84011"
            };
            axis2.Minimum = 0;
            axis2.Maximum = 240;
            axis2.StartAngle = 220;
            axis2.EndAngle = 140;
            List<CircularGaugePointer> pointers2 = new List<CircularGaugePointer>();
            CircularGaugePointer pointer2 = new CircularGaugePointer();
            pointer2.Value = 120;
            pointer2.Radius = "100%";
            pointer2.Color = "#C62E0A";
            pointer2.MarkerHeight = 15;
            pointer2.MarkerWidth = 15;
            pointer2.Type = PointerType.Marker;
            pointer2.MarkerShape = GaugeShape.InvertedTriangle;
            pointers2.Add(pointer2);
            axis2.Pointers = pointers2;

            axes.Add(axis2);

            ViewBag.Axes = axes;
            return View();
        }
    }
}