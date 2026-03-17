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
        // GET: KeyPerformanceIndicator
        public ActionResult KeyPerformanceIndicator()
        {
            List<CircularGaugePointer> pointerCollections = new List<CircularGaugePointer>();

            CircularGaugePointer circlePointerOne = new CircularGaugePointer();
            circlePointerOne.Type = PointerType.Marker;
            circlePointerOne.MarkerShape = GaugeShape.Circle;
            circlePointerOne.MarkerWidth = 30;
            circlePointerOne.MarkerHeight = 30;
            circlePointerOne.Radius = "82%";
            circlePointerOne.Color = "#bdbdbf";
            circlePointerOne.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            circlePointerOne.Value = 30;
            pointerCollections.Add(circlePointerOne);

            CircularGaugePointer circlePointerTwo = new CircularGaugePointer();
            circlePointerTwo.Type = PointerType.Marker;
            circlePointerTwo.MarkerShape = GaugeShape.Circle;
            circlePointerTwo.MarkerWidth = 30;
            circlePointerTwo.MarkerHeight = 30;
            circlePointerTwo.Radius = "82%";
            circlePointerTwo.Color = "#626866";
            circlePointerTwo.Value = 50;
            circlePointerTwo.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            pointerCollections.Add(circlePointerTwo);

            CircularGaugePointer invertedTrianglePointer = new CircularGaugePointer();
            invertedTrianglePointer.Type = PointerType.Marker;
            invertedTrianglePointer.MarkerShape = GaugeShape.InvertedTriangle;
            invertedTrianglePointer.MarkerWidth = 30;
            invertedTrianglePointer.MarkerHeight = 30;
            invertedTrianglePointer.Radius = "92%";
            invertedTrianglePointer.Color = "#b6b6b6";
            invertedTrianglePointer.Value = 76.6;
            pointerCollections.Add(invertedTrianglePointer);

            ViewData["Pointers"] = pointerCollections;

            List<CircularGaugeRange> rangeCollections = new List<CircularGaugeRange>();
            CircularGaugeRange fullRange = new CircularGaugeRange();
            fullRange.Start = 0;
            fullRange.End = 100;
            fullRange.Color = "#e3e3e3";
            fullRange.Radius = "90%";
            fullRange.RoundedCornerRadius = 20;
            fullRange.StartWidth = "30";
            fullRange.EndWidth = "30";
            rangeCollections.Add(fullRange);

            CircularGaugeRange halfRange = new CircularGaugeRange();
            halfRange.Start = 30;
            halfRange.End = 50;
            halfRange.LinearGradient = new CircularGaugeLinearGradient
            {
                StartValue = "0%",
                EndValue = "60%",
                ColorStop = new List<CircularGaugeColorStop>()
                {
                    new CircularGaugeColorStop()
                    {
                        Color = "white",
                        Offset="10%",
                        Opacity=0.9
                    },
                    new CircularGaugeColorStop()
                    {
                        Color = "#84cbb5",
                        Offset="90%",
                        Opacity=0.9
                    }
                }
            };
            halfRange.Radius = "90%";
            halfRange.StartWidth = "30";
            halfRange.EndWidth = "30";
            rangeCollections.Add(halfRange);

            ViewData["Ranges"] = rangeCollections;

            List<CircularGaugeAnnotation> annotationCollections = new List<CircularGaugeAnnotation>();
            CircularGaugeAnnotation triangleAnnotation = new CircularGaugeAnnotation();
            triangleAnnotation.Angle = 259;
            triangleAnnotation.ZIndex = "1";
            triangleAnnotation.Radius = "36%";
            triangleAnnotation.Content = "<div class='triangle-up'></div>";
            annotationCollections.Add(triangleAnnotation);

            CircularGaugeAnnotation annotationText = new CircularGaugeAnnotation();
            annotationText.Angle = 0;
            annotationText.ZIndex = "1";
            annotationText.Radius = "25%";
            annotationText.Content = "<div class='titleText' style='color:#84cbb5'>Current</div>";
            annotationCollections.Add(annotationText);

            CircularGaugeAnnotation annotationPointerValue = new CircularGaugeAnnotation();
            annotationPointerValue.Angle = 125;
            annotationPointerValue.ZIndex = "1";
            annotationPointerValue.Radius = "12%";
            annotationPointerValue.Content = "<div class='annotationText' style='color:#84cbb5'>76.6%</div>";
            annotationCollections.Add(annotationPointerValue);

            CircularGaugeAnnotation annotationStartValue = new CircularGaugeAnnotation();
            annotationStartValue.Angle = 213;
            annotationStartValue.ZIndex = "1";
            annotationStartValue.Radius = "83%";
            annotationStartValue.Content = "<div style='font-size:22px;'>0</div>";
            annotationCollections.Add(annotationStartValue);

            CircularGaugeAnnotation annotationEndValue = new CircularGaugeAnnotation();
            annotationEndValue.Angle = 150;
            annotationEndValue.ZIndex = "1";
            annotationEndValue.Radius = "83%";
            annotationEndValue.Content = "<div style='font-size:22px;'>100</div>";
            annotationCollections.Add(annotationEndValue);

            ViewData["Annotations"] = annotationCollections;

            ViewData["labelFont"] = new CircularGaugeFont
            {
                Size = "0px",
            };
            return View();
        }
    }
}