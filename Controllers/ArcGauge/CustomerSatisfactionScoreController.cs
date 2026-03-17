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
using Syncfusion.EJ2.CircularGauge;

namespace EJ2MVCSampleBrowser.Controllers.ArcGauge
{
    public partial class ArcGaugeController : Controller
    {
        // GET: CustomerSatisfactionScore
        public ActionResult CustomerSatisfactionScore()
        {
            List<CircularGaugePointer> pointerCollections = new List<CircularGaugePointer>();
            CircularGaugePointer pointerNeedle = new CircularGaugePointer();
            pointerNeedle.Value = 7.5;
            pointerNeedle.Radius = "80%";
            pointerNeedle.PointerWidth = 5;
            pointerNeedle.NeedleEndWidth = 2;
            pointerNeedle.Cap = new CircularGaugeCap
            {
                Radius = 8,
                Border = new CircularGaugeBorder
                {
                    Width = 2
                }
            };
            pointerCollections.Add(pointerNeedle);

            CircularGaugePointer pointerLineOne = new CircularGaugePointer();
            pointerLineOne.Value = 6.5;
            pointerLineOne.Radius = "78%";
            pointerLineOne.Type = PointerType.Marker;
            pointerLineOne.MarkerShape = GaugeShape.Rectangle;
            pointerLineOne.MarkerWidth = 40;
            pointerLineOne.MarkerHeight = 0.5;
            pointerLineOne.Color = "#0477c2";
            pointerLineOne.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            pointerCollections.Add(pointerLineOne);

            CircularGaugePointer pointerLineTwo = new CircularGaugePointer();
            pointerLineTwo.Value = 9.5;
            pointerLineTwo.Radius = "78%";
            pointerLineTwo.Type = PointerType.Marker;
            pointerLineTwo.MarkerShape = GaugeShape.Rectangle;
            pointerLineTwo.MarkerWidth = 40;
            pointerLineTwo.MarkerHeight = 0.5;
            pointerLineTwo.Color = "#0477c2";
            pointerLineTwo.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            pointerCollections.Add(pointerLineTwo);

            ViewData["Pointers"] = pointerCollections;

            List<CircularGaugeRange> rangeCollections = new List<CircularGaugeRange>();
            CircularGaugeRange poorRange = new CircularGaugeRange();
            poorRange.Start = 0;
            poorRange.End = 2;
            poorRange.Color = "#F03E3E";
            poorRange.Radius = "90%";
            poorRange.StartWidth = "40";
            poorRange.EndWidth = "40";
            poorRange.LegendText = "Poor";
            rangeCollections.Add(poorRange);

            CircularGaugeRange averageScoreRange = new CircularGaugeRange();
            averageScoreRange.Start = 6.5;
            averageScoreRange.End = 9.5;
            averageScoreRange.Color = "#0477c2";
            averageScoreRange.Radius = "120%";
            averageScoreRange.StartWidth = "120";
            averageScoreRange.EndWidth = "120";
            averageScoreRange.LegendText = "Average Score";
            rangeCollections.Add(averageScoreRange);

            CircularGaugeRange satisfiedRange = new CircularGaugeRange();
            satisfiedRange.Start = 2;
            satisfiedRange.End = 5;
            satisfiedRange.Color = "#f6961e";
            satisfiedRange.Radius = "90%";
            satisfiedRange.StartWidth = "40";
            satisfiedRange.EndWidth = "40";
            satisfiedRange.LegendText = "Satisfied";
            rangeCollections.Add(satisfiedRange);

            CircularGaugeRange goodRange = new CircularGaugeRange();
            goodRange.Start = 5;
            goodRange.End = 8;
            goodRange.Color = "#FFDD00";
            goodRange.Radius = "90%";
            goodRange.StartWidth = "40";
            goodRange.EndWidth = "40";
            goodRange.LegendText = "Good";
            rangeCollections.Add(goodRange);

            CircularGaugeRange excellentRange = new CircularGaugeRange();
            excellentRange.Start = 8;
            excellentRange.End = 10;
            excellentRange.Color = "#30B32D";
            excellentRange.Radius = "90%";
            excellentRange.StartWidth = "40";
            excellentRange.EndWidth = "40";
            excellentRange.LegendText = "Excellent";
            rangeCollections.Add(excellentRange);

            ViewData["Ranges"] = rangeCollections;

            List<CircularGaugeAnnotation> annotations = new List<CircularGaugeAnnotation>();
            CircularGaugeAnnotation pointerAnnotationValue = new CircularGaugeAnnotation();
            pointerAnnotationValue.Content = "<div style='font-size:16px;margin-top: 15px;font-family:inherit'>7.5</div>";
            pointerAnnotationValue.Angle = 0;
            pointerAnnotationValue.Radius = "-10%";
            pointerAnnotationValue.ZIndex = "1";
            annotations.Add(pointerAnnotationValue);

            ViewData["Annotations"] = annotations;

            ViewData["labelFont"] = new CircularGaugeFont
            {
                Size = "12px",
                Opacity = 1,
                FontFamily= "inherit"
            };
            return View();
        }
    }
}