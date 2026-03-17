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
        // GET: Patterns
        public ActionResult Patterns()
        {
            // First gauge //
            List<CircularGaugePointer> gaugeOnePointerCollections = new List<CircularGaugePointer>();
            CircularGaugePointer gaugeOneRangeBarPointer = new CircularGaugePointer();
            gaugeOneRangeBarPointer.Radius = "120%";
            gaugeOneRangeBarPointer.Value = 38;
            gaugeOneRangeBarPointer.Type = PointerType.RangeBar;
            gaugeOneRangeBarPointer.Color = "#7edfb4";
            gaugeOneRangeBarPointer.PointerWidth = 28;
            gaugeOnePointerCollections.Add(gaugeOneRangeBarPointer);

            CircularGaugePointer gaugeOneMarkerPointer = new CircularGaugePointer();
            gaugeOneMarkerPointer.Radius = "98%";
            gaugeOneMarkerPointer.Value = 38;
            gaugeOneMarkerPointer.Type = PointerType.Marker;
            gaugeOneMarkerPointer.MarkerShape = GaugeShape.Rectangle;
            gaugeOneMarkerPointer.MarkerWidth = 28;
            gaugeOneMarkerPointer.MarkerHeight = 3;
            gaugeOneMarkerPointer.Color = "black";
            gaugeOneMarkerPointer.PointerWidth = 40;
            gaugeOnePointerCollections.Add(gaugeOneMarkerPointer);

            ViewData["FirstGaugePointers"] = gaugeOnePointerCollections;

            List<CircularGaugeRange> gaugeOneRangeCollections = new List<CircularGaugeRange>();
            CircularGaugeRange gaugeOneRangeOne = new CircularGaugeRange();
            gaugeOneRangeOne.Start = 0;
            gaugeOneRangeOne.End = 38;
            gaugeOneRangeOne.Color = "#7edfb4";
            gaugeOneRangeOne.Radius = "86%";
            gaugeOneRangeOne.StartWidth = "10";
            gaugeOneRangeOne.EndWidth = "10";
            gaugeOneRangeCollections.Add(gaugeOneRangeOne);

            CircularGaugeRange gaugeOneRangeTwo = new CircularGaugeRange();
            gaugeOneRangeTwo.Start = 38;
            gaugeOneRangeTwo.End = 50;
            gaugeOneRangeTwo.Color = "#7edfb4";
            gaugeOneRangeTwo.Radius = "87%";
            gaugeOneRangeTwo.StartWidth = "10";
            gaugeOneRangeTwo.EndWidth = "10";
            gaugeOneRangeCollections.Add(gaugeOneRangeTwo);

            CircularGaugeRange gaugeOneRangeThree = new CircularGaugeRange();
            gaugeOneRangeThree.Start = 50;
            gaugeOneRangeThree.End = 75;
            gaugeOneRangeThree.Color = "#f99d4c";
            gaugeOneRangeThree.Radius = "87%";
            gaugeOneRangeThree.StartWidth = "10";
            gaugeOneRangeThree.EndWidth = "10";
            gaugeOneRangeCollections.Add(gaugeOneRangeThree);

            CircularGaugeRange gaugeOneRangeFour = new CircularGaugeRange();
            gaugeOneRangeFour.Start = 75;
            gaugeOneRangeFour.End = 100;
            gaugeOneRangeFour.Color = "#e96920";
            gaugeOneRangeFour.Radius = "87%";
            gaugeOneRangeFour.StartWidth = "10";
            gaugeOneRangeFour.EndWidth = "10";
            gaugeOneRangeCollections.Add(gaugeOneRangeFour);

            ViewData["FirstGaugeRanges"] = gaugeOneRangeCollections;

            List<CircularGaugeAnnotation> gaugeOneAnnotations = new List<CircularGaugeAnnotation>();
            CircularGaugeAnnotation gaugeOneAnnotationValue = new CircularGaugeAnnotation();
            gaugeOneAnnotationValue.Angle = 188;
            gaugeOneAnnotationValue.ZIndex = "1";
            gaugeOneAnnotationValue.Radius = "15%";
            gaugeOneAnnotationValue.Content = "<div style='font-size:30px;'>38</div>";
            gaugeOneAnnotations.Add(gaugeOneAnnotationValue);

            ViewData["FirstGaugeAnnotations"] = gaugeOneAnnotations;

            // Second Gauge //

            List<CircularGaugePointer> secondGaugePointerCollections = new List<CircularGaugePointer>();
            CircularGaugePointer secondGaugeRangeBarPointerOne = new CircularGaugePointer();
            secondGaugeRangeBarPointerOne.Radius = "125%";
            secondGaugeRangeBarPointerOne.Value = 75;
            secondGaugeRangeBarPointerOne.Type = PointerType.RangeBar;
            secondGaugeRangeBarPointerOne.Color = "#d6f5e8";
            secondGaugeRangeBarPointerOne.PointerWidth = 40;
            secondGaugePointerCollections.Add(secondGaugeRangeBarPointerOne);

            CircularGaugePointer secondGaugeRangeBarPointerTwo = new CircularGaugePointer();
            secondGaugeRangeBarPointerTwo.Radius = "115%";
            secondGaugeRangeBarPointerTwo.Value = 75;
            secondGaugeRangeBarPointerTwo.Type = PointerType.RangeBar;
            secondGaugeRangeBarPointerTwo.Color = "#7edfb4";
            secondGaugeRangeBarPointerTwo.PointerWidth = 30;
            secondGaugePointerCollections.Add(secondGaugeRangeBarPointerTwo);


            ViewData["SecondGaugePointers"] = secondGaugePointerCollections;


            List<CircularGaugeAnnotation> secondGaugeAnnotations = new List<CircularGaugeAnnotation>();
            CircularGaugeAnnotation secondGaugeCenterAnnotationValue = new CircularGaugeAnnotation();
            secondGaugeCenterAnnotationValue.Angle = 1;
            secondGaugeCenterAnnotationValue.ZIndex = "1";
            secondGaugeCenterAnnotationValue.Radius = "0%";
            secondGaugeCenterAnnotationValue.Content = "<div style='font-size:25px;font-family:inherit;'>75%</div>";
            secondGaugeAnnotations.Add(secondGaugeCenterAnnotationValue);

            CircularGaugeAnnotation secondGaugeStartAnnotationValue = new CircularGaugeAnnotation();
            secondGaugeStartAnnotationValue.Angle = 255;
            secondGaugeStartAnnotationValue.ZIndex = "1";
            secondGaugeStartAnnotationValue.Radius = "102%";
            secondGaugeStartAnnotationValue.Content = "<div style='font-size:22px;font-family:inherit;'>0%</div>";
            secondGaugeAnnotations.Add(secondGaugeStartAnnotationValue);

            CircularGaugeAnnotation secondGaugeEndAnnotationValue = new CircularGaugeAnnotation();
            secondGaugeEndAnnotationValue.Angle = 105;
            secondGaugeEndAnnotationValue.ZIndex = "1";
            secondGaugeEndAnnotationValue.Radius = "105%";
            secondGaugeEndAnnotationValue.Content = "<div style='font-size:22px;font-family:inherit;'>100%</div>";
            secondGaugeAnnotations.Add(secondGaugeEndAnnotationValue);

            ViewData["SecondGaugeAnnotations"] = secondGaugeAnnotations;

            // Third Gauge //

            List<CircularGaugeRange> thirdGaugeRangeCollections = new List<CircularGaugeRange>();
            CircularGaugeRange thirdGaugeRangeOne = new CircularGaugeRange();
            thirdGaugeRangeOne.Start = 0;
            thirdGaugeRangeOne.End = 298;
            thirdGaugeRangeOne.Color = "#ff5353";
            thirdGaugeRangeOne.RoundedCornerRadius = 10;
            thirdGaugeRangeOne.StartWidth = "12";
            thirdGaugeRangeOne.EndWidth = "12";
            thirdGaugeRangeCollections.Add(thirdGaugeRangeOne);

            CircularGaugeRange thirdGaugeRangeTwo = new CircularGaugeRange();
            thirdGaugeRangeTwo.Start = 300;
            thirdGaugeRangeTwo.End = 397;
            thirdGaugeRangeTwo.Color = "#ffd223";
            thirdGaugeRangeTwo.RoundedCornerRadius = 10;
            thirdGaugeRangeTwo.StartWidth = "12";
            thirdGaugeRangeTwo.EndWidth = "12";
            thirdGaugeRangeCollections.Add(thirdGaugeRangeTwo);

            CircularGaugeRange thirdGaugeRangeThree = new CircularGaugeRange();
            thirdGaugeRangeThree.Start = 400;
            thirdGaugeRangeThree.End = 497;
            thirdGaugeRangeThree.Color = "#77e6b4";
            thirdGaugeRangeThree.RoundedCornerRadius = 10;
            thirdGaugeRangeThree.StartWidth = "12";
            thirdGaugeRangeThree.EndWidth = "12";
            thirdGaugeRangeCollections.Add(thirdGaugeRangeThree);

            CircularGaugeRange thirdGaugeRangeFour = new CircularGaugeRange();
            thirdGaugeRangeFour.Start = 500;
            thirdGaugeRangeFour.End = 600;
            thirdGaugeRangeFour.Color = "#21d683";
            thirdGaugeRangeFour.RoundedCornerRadius = 10;
            thirdGaugeRangeFour.StartWidth = "12";
            thirdGaugeRangeFour.EndWidth = "12";
            thirdGaugeRangeCollections.Add(thirdGaugeRangeFour);

            ViewData["ThirdGaugeRanges"] = thirdGaugeRangeCollections;

            List<CircularGaugeAnnotation> thirdGaugeAnnotationCollections = new List<CircularGaugeAnnotation>();
            CircularGaugeAnnotation thirdGaugeAnnotationValueOne = new CircularGaugeAnnotation();
            thirdGaugeAnnotationValueOne.Angle = 0;
            thirdGaugeAnnotationValueOne.ZIndex = "1";
            thirdGaugeAnnotationValueOne.Radius = "-10%";
            thirdGaugeAnnotationValueOne.Content = "<div style='font-size:30px;font-family:inherit;'> 450 </div>";
            thirdGaugeAnnotationCollections.Add(thirdGaugeAnnotationValueOne);

            CircularGaugeAnnotation thirdGaugeAnnotationValueTwo = new CircularGaugeAnnotation();
            thirdGaugeAnnotationValueTwo.Angle = 0;
            thirdGaugeAnnotationValueTwo.ZIndex = "1";
            thirdGaugeAnnotationValueTwo.Radius = "112%";
            thirdGaugeAnnotationValueTwo.Content = "<div style='font-size:12px;font-family:inherit;'> 300 </div>";
            thirdGaugeAnnotationCollections.Add(thirdGaugeAnnotationValueTwo);

            CircularGaugeAnnotation thirdGaugeAnnotationValueThree = new CircularGaugeAnnotation();
            thirdGaugeAnnotationValueThree.Angle = 48;
            thirdGaugeAnnotationValueThree.ZIndex = "1";
            thirdGaugeAnnotationValueThree.Radius = "112%";
            thirdGaugeAnnotationValueThree.Content = "<div style='font-size:12px;font-family:inherit;'> 400 </div>";
            thirdGaugeAnnotationCollections.Add(thirdGaugeAnnotationValueThree);

            CircularGaugeAnnotation thirdGaugeAnnotationValueFour = new CircularGaugeAnnotation();
            thirdGaugeAnnotationValueFour.Angle = 93;
            thirdGaugeAnnotationValueFour.ZIndex = "1";
            thirdGaugeAnnotationValueFour.Radius = "112%";
            thirdGaugeAnnotationValueFour.Content = "<div style='font-size:12px;font-family:inherit;'> 500 </div>";
            thirdGaugeAnnotationCollections.Add(thirdGaugeAnnotationValueFour);


            ViewData["ThirdGaugeAnnotations"] = thirdGaugeAnnotationCollections;



            List<CircularGaugePointer> thirdGaugePointerCollections = new List<CircularGaugePointer>();

            CircularGaugePointer thirdGaugeMarkerPointer = new CircularGaugePointer();
            thirdGaugeMarkerPointer.Color = "white";
            thirdGaugeMarkerPointer.Type = PointerType.Marker;
            thirdGaugeMarkerPointer.Value = 450;
            thirdGaugeMarkerPointer.MarkerShape = GaugeShape.Circle;
            thirdGaugeMarkerPointer.Radius = "94%";
            thirdGaugeMarkerPointer.MarkerWidth = 17;
            thirdGaugeMarkerPointer.MarkerHeight = 17;
            thirdGaugeMarkerPointer.Border = new CircularGaugeBorder { Width = 7, Color = "#77e6b4" };
            thirdGaugeMarkerPointer.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            thirdGaugePointerCollections.Add(thirdGaugeMarkerPointer);

            ViewData["ThirdGaugePointers"] = thirdGaugePointerCollections;


            // Fourth gauge //

            List<CircularGaugeAnnotation> fourthGaugeAnnotations = new List<CircularGaugeAnnotation>();
            CircularGaugeAnnotation fourthGaugeAnnotationValue = new CircularGaugeAnnotation();
            fourthGaugeAnnotationValue.Angle = 105;
            fourthGaugeAnnotationValue.ZIndex = "1";
            fourthGaugeAnnotationValue.Radius = "5%";
            fourthGaugeAnnotationValue.Content = "<div class='gaugeThirdText' style='font-size:30px;font-family:inherit;'>21%</div>";
            fourthGaugeAnnotations.Add(fourthGaugeAnnotationValue);

            ViewData["FourthGaugeAnnotations"] = fourthGaugeAnnotations;

            List<CircularGaugePointer> fourthGaugePointerCollections = new List<CircularGaugePointer>();

            CircularGaugePointer fourthGaugeRangeBarPointer = new CircularGaugePointer();
            fourthGaugeRangeBarPointer.Type = PointerType.RangeBar;
            fourthGaugeRangeBarPointer.Radius = "90%";
            fourthGaugeRangeBarPointer.Value = 21;
            fourthGaugeRangeBarPointer.PointerWidth = 25;
            fourthGaugeRangeBarPointer.RoundedCornerRadius = 10;
            fourthGaugeRangeBarPointer.Color = "#a8f789";
            fourthGaugeRangeBarPointer.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            fourthGaugePointerCollections.Add(fourthGaugeRangeBarPointer);

            CircularGaugePointer fourthGaugeCirclePointerInside = new CircularGaugePointer();
            fourthGaugeCirclePointerInside.Type = PointerType.Marker;
            fourthGaugeCirclePointerInside.MarkerShape = GaugeShape.Circle;
            fourthGaugeCirclePointerInside.Radius = "80%";
            fourthGaugeCirclePointerInside.Value = 22;
            fourthGaugeCirclePointerInside.MarkerWidth = 30;
            fourthGaugeCirclePointerInside.MarkerHeight = 30;
            fourthGaugeCirclePointerInside.Color = "white";
            fourthGaugeCirclePointerInside.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            fourthGaugePointerCollections.Add(fourthGaugeCirclePointerInside);

            CircularGaugePointer fourthGaugeCirclePointerOutside = new CircularGaugePointer();
            fourthGaugeCirclePointerOutside.Type = PointerType.Marker;
            fourthGaugeCirclePointerOutside.MarkerShape = GaugeShape.Circle;
            fourthGaugeCirclePointerOutside.Radius = "80%";
            fourthGaugeCirclePointerOutside.Value = 22;
            fourthGaugeCirclePointerOutside.MarkerWidth = 18;
            fourthGaugeCirclePointerOutside.MarkerHeight = 18;
            fourthGaugeCirclePointerOutside.Color = "#a8f789";
            fourthGaugeCirclePointerOutside.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            fourthGaugePointerCollections.Add(fourthGaugeCirclePointerOutside);

            ViewData["FourthGaugePointers"] = fourthGaugePointerCollections;


            List<CircularGaugeRange> fourthGaugeRangeCollections = new List<CircularGaugeRange>();
            CircularGaugeRange fourthGaugeRangeOne = new CircularGaugeRange();
            fourthGaugeRangeOne.Start = 0;
            fourthGaugeRangeOne.End = 100;
            fourthGaugeRangeOne.Color = "#E0E0E0";
            fourthGaugeRangeOne.RoundedCornerRadius = 20;
            fourthGaugeRangeOne.Radius = "90%";
            fourthGaugeRangeOne.StartWidth = "25";
            fourthGaugeRangeOne.EndWidth = "25";
            fourthGaugeRangeCollections.Add(fourthGaugeRangeOne);

            CircularGaugeRange fourthGaugeRangeTwo = new CircularGaugeRange();
            fourthGaugeRangeTwo.Start = 70;
            fourthGaugeRangeTwo.End = 100;
            fourthGaugeRangeTwo.Color = "#ed5e4b";
            fourthGaugeRangeTwo.Radius = "90%";
            fourthGaugeRangeTwo.StartWidth = "25";
            fourthGaugeRangeTwo.EndWidth = "25";
            fourthGaugeRangeTwo.RoundedCornerRadius = 20;
            fourthGaugeRangeCollections.Add(fourthGaugeRangeTwo);

            CircularGaugeRange fourthGaugeRangeThree = new CircularGaugeRange();
            fourthGaugeRangeThree.Start = 21;
            fourthGaugeRangeThree.End = 75;
            fourthGaugeRangeThree.Color = "#ffe852";
            fourthGaugeRangeThree.Radius = "90%";
            fourthGaugeRangeThree.StartWidth = "25";
            fourthGaugeRangeThree.EndWidth = "25";
            fourthGaugeRangeThree.LinearGradient = new CircularGaugeLinearGradient
            {
                StartValue = "65%",
                EndValue = "100%",
                ColorStop = new List<CircularGaugeColorStop>()
                {
                    new CircularGaugeColorStop()
                    {
                        Color = "#ffe852",
                        Offset="20%",
                        Opacity=0.9
                    },
                    new CircularGaugeColorStop()
                    {
                        Color = "#ed5e4b",
                        Offset="100%",
                        Opacity=0.9
                    }
                }
            };
            fourthGaugeRangeCollections.Add(fourthGaugeRangeThree);

            ViewData["FourthGaugeRanges"] = fourthGaugeRangeCollections;


            // Fifth Gauge //

            List<CircularGaugeRange> fifthGaugeRangeCollections = new List<CircularGaugeRange>();
            CircularGaugeRange fifthGaugeRangeOne = new CircularGaugeRange();
            fifthGaugeRangeOne.Start = 0;
            fifthGaugeRangeOne.End = 100;
            fifthGaugeRangeOne.Color = "#E0E0E0";
            fifthGaugeRangeOne.Radius = "90%";
            fifthGaugeRangeOne.RoundedCornerRadius = 20;
            fifthGaugeRangeOne.StartWidth = "30";
            fifthGaugeRangeOne.EndWidth = "30";
            fifthGaugeRangeCollections.Add(fifthGaugeRangeOne);

            CircularGaugeRange fifthGaugeRangeTwo = new CircularGaugeRange();
            fifthGaugeRangeTwo.Start = 3;
            fifthGaugeRangeTwo.End = 30;
            fifthGaugeRangeTwo.Color = "#a8f789";
            fifthGaugeRangeTwo.Radius = "105%";
            fifthGaugeRangeTwo.RoundedCornerRadius = 10;
            fifthGaugeRangeTwo.StartWidth = "10";
            fifthGaugeRangeTwo.EndWidth = "10";
            fifthGaugeRangeCollections.Add(fifthGaugeRangeTwo);

            CircularGaugeRange fifthGaugeRangeThree = new CircularGaugeRange();
            fifthGaugeRangeThree.Start = 31;
            fifthGaugeRangeThree.End = 70;
            fifthGaugeRangeThree.Radius = "105%";
            fifthGaugeRangeThree.Color = "#ffe852";
            fifthGaugeRangeThree.RoundedCornerRadius = 10;
            fifthGaugeRangeThree.StartWidth = "10";
            fifthGaugeRangeThree.EndWidth = "10";
            fifthGaugeRangeCollections.Add(fifthGaugeRangeThree);

            CircularGaugeRange fifthGaugeRangeFour = new CircularGaugeRange();
            fifthGaugeRangeFour.Start = 71;
            fifthGaugeRangeFour.End = 96;
            fifthGaugeRangeFour.Radius = "105%";
            fifthGaugeRangeFour.Color = "#ed5e4b";
            fifthGaugeRangeFour.RoundedCornerRadius = 10;
            fifthGaugeRangeFour.StartWidth = "10";
            fifthGaugeRangeFour.EndWidth = "10";
            fifthGaugeRangeCollections.Add(fifthGaugeRangeFour);

            ViewData["FifthGaugeRanges"] = fifthGaugeRangeCollections;


            List<CircularGaugePointer> fifthGaugeRangeBarPointers = new List<CircularGaugePointer>();
            CircularGaugePointer fifthGaugeRangeBarPointer = new CircularGaugePointer();
            fifthGaugeRangeBarPointer.Color = "#ffe852";
            fifthGaugeRangeBarPointer.Type = PointerType.RangeBar;
            fifthGaugeRangeBarPointer.RoundedCornerRadius = 20;
            fifthGaugeRangeBarPointer.PointerWidth = 30;
            fifthGaugeRangeBarPointer.Radius = "90%";
            fifthGaugeRangeBarPointer.Value = 54;
            fifthGaugeRangeBarPointer.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            fifthGaugeRangeBarPointers.Add(fifthGaugeRangeBarPointer);


            ViewData["FifthGaugePointers"] = fifthGaugeRangeBarPointers;

            List<CircularGaugeAnnotation> fifthGaugeAnnotations = new List<CircularGaugeAnnotation>();
            CircularGaugeAnnotation fifthGaugeAnnotationValue = new CircularGaugeAnnotation();
            fifthGaugeAnnotationValue.Angle = 154;
            fifthGaugeAnnotationValue.ZIndex = "1";
            fifthGaugeAnnotationValue.Radius = "10%";
            fifthGaugeAnnotationValue.Content = "<div style='font-size:30px;font-family:inherit;'>54%</div>";
            fifthGaugeAnnotations.Add(fifthGaugeAnnotationValue);


            ViewData["FifthGaugeAnnotations"] = fifthGaugeAnnotations;


            // Sixth Gauge //


            List<CircularGaugeRange> sixthGaugeRanges = new List<CircularGaugeRange>();
            CircularGaugeRange sixthGaugeFullRange = new CircularGaugeRange();
            sixthGaugeFullRange.Start = 0;
            sixthGaugeFullRange.End = 100;
            sixthGaugeFullRange.Color = "#f6f7f9";
            sixthGaugeFullRange.Radius = "104%";
            sixthGaugeFullRange.StartWidth = "38";
            sixthGaugeFullRange.EndWidth = "38";
            sixthGaugeRanges.Add(sixthGaugeFullRange);

            ViewData["SixthGaugeRanges"] = sixthGaugeRanges;

            List<CircularGaugePointer> sixthGaugePointerCollections = new List<CircularGaugePointer>();
            CircularGaugePointer sixthGaugeMarkerPointerOne = new CircularGaugePointer();
            sixthGaugeMarkerPointerOne.Color = "#7edfb4";
            sixthGaugeMarkerPointerOne.Type = PointerType.Marker;
            sixthGaugeMarkerPointerOne.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerOne.MarkerWidth = 38;
            sixthGaugeMarkerPointerOne.MarkerHeight = 3;
            sixthGaugeMarkerPointerOne.Value = 0;
            sixthGaugeMarkerPointerOne.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerOne);

            CircularGaugePointer sixthGaugeMarkerPointerTwo = new CircularGaugePointer();
            sixthGaugeMarkerPointerTwo.Color = "#7edfb4";
            sixthGaugeMarkerPointerTwo.Type = PointerType.Marker;
            sixthGaugeMarkerPointerTwo.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerTwo.MarkerWidth = 38;
            sixthGaugeMarkerPointerTwo.MarkerHeight = 3;
            sixthGaugeMarkerPointerTwo.Value = 1;
            sixthGaugeMarkerPointerTwo.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerTwo);

            CircularGaugePointer sixthGaugeMarkerPointerFour = new CircularGaugePointer();
            sixthGaugeMarkerPointerFour.Color = "#7edfb4";
            sixthGaugeMarkerPointerFour.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFour.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFour.MarkerWidth = 38;
            sixthGaugeMarkerPointerFour.MarkerHeight = 3;
            sixthGaugeMarkerPointerFour.Value = 2;
            sixthGaugeMarkerPointerFour.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFour);

            CircularGaugePointer sixthGaugeMarkerPointerFive = new CircularGaugePointer();
            sixthGaugeMarkerPointerFive.Color = "#7edfb4";
            sixthGaugeMarkerPointerFive.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFive.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFive.MarkerWidth = 38;
            sixthGaugeMarkerPointerFive.MarkerHeight = 3;
            sixthGaugeMarkerPointerFive.Value = 3;
            sixthGaugeMarkerPointerFive.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFive);

            CircularGaugePointer sixthGaugeMarkerPointerSix = new CircularGaugePointer();
            sixthGaugeMarkerPointerSix.Color = "#7edfb4";
            sixthGaugeMarkerPointerSix.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSix.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSix.MarkerWidth = 38;
            sixthGaugeMarkerPointerSix.MarkerHeight = 3;
            sixthGaugeMarkerPointerSix.Value = 4;
            sixthGaugeMarkerPointerSix.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSix);

            CircularGaugePointer sixthGaugeMarkerPointerSeven = new CircularGaugePointer();
            sixthGaugeMarkerPointerSeven.Color = "#7edfb4";
            sixthGaugeMarkerPointerSeven.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSeven.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSeven.MarkerWidth = 38;
            sixthGaugeMarkerPointerSeven.MarkerHeight = 3;
            sixthGaugeMarkerPointerSeven.Value = 5;
            sixthGaugeMarkerPointerSeven.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSeven);

            CircularGaugePointer sixthGaugeMarkerPointerEight = new CircularGaugePointer();
            sixthGaugeMarkerPointerEight.Color = "#7edfb4";
            sixthGaugeMarkerPointerEight.Type = PointerType.Marker;
            sixthGaugeMarkerPointerEight.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerEight.MarkerWidth = 38;
            sixthGaugeMarkerPointerEight.MarkerHeight = 3;
            sixthGaugeMarkerPointerEight.Value = 6;
            sixthGaugeMarkerPointerEight.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerEight);

            CircularGaugePointer sixthGaugeMarkerPointerNine = new CircularGaugePointer();
            sixthGaugeMarkerPointerNine.Color = "#7edfb4";
            sixthGaugeMarkerPointerNine.Type = PointerType.Marker;
            sixthGaugeMarkerPointerNine.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerNine.MarkerWidth = 38;
            sixthGaugeMarkerPointerNine.MarkerHeight = 3;
            sixthGaugeMarkerPointerNine.Value = 7;
            sixthGaugeMarkerPointerNine.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerNine);

            CircularGaugePointer sixthGaugeMarkerPointerTen = new CircularGaugePointer();
            sixthGaugeMarkerPointerTen.Color = "#7edfb4";
            sixthGaugeMarkerPointerTen.Type = PointerType.Marker;
            sixthGaugeMarkerPointerTen.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerTen.MarkerWidth = 38;
            sixthGaugeMarkerPointerTen.MarkerHeight = 3;
            sixthGaugeMarkerPointerTen.Value = 8;
            sixthGaugeMarkerPointerTen.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerTen);

            CircularGaugePointer sixthGaugeMarkerPointerEleven = new CircularGaugePointer();
            sixthGaugeMarkerPointerEleven.Color = "#7edfb4";
            sixthGaugeMarkerPointerEleven.Type = PointerType.Marker;
            sixthGaugeMarkerPointerEleven.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerEleven.MarkerWidth = 38;
            sixthGaugeMarkerPointerEleven.MarkerHeight = 3;
            sixthGaugeMarkerPointerEleven.Value = 9;
            sixthGaugeMarkerPointerEleven.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerEleven);

            CircularGaugePointer sixthGaugeMarkerPointerTwelve = new CircularGaugePointer();
            sixthGaugeMarkerPointerTwelve.Color = "#7edfb4";
            sixthGaugeMarkerPointerTwelve.Type = PointerType.Marker;
            sixthGaugeMarkerPointerTwelve.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerTwelve.MarkerWidth = 38;
            sixthGaugeMarkerPointerTwelve.MarkerHeight = 3;
            sixthGaugeMarkerPointerTwelve.Value = 10;
            sixthGaugeMarkerPointerTwelve.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerTwelve);

            CircularGaugePointer sixthGaugeMarkerPointerThirteen = new CircularGaugePointer();
            sixthGaugeMarkerPointerThirteen.Color = "#7edfb4";
            sixthGaugeMarkerPointerThirteen.Type = PointerType.Marker;
            sixthGaugeMarkerPointerThirteen.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerThirteen.MarkerWidth = 38;
            sixthGaugeMarkerPointerThirteen.MarkerHeight = 3;
            sixthGaugeMarkerPointerThirteen.Value = 11;
            sixthGaugeMarkerPointerThirteen.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerThirteen);

            CircularGaugePointer sixthGaugeMarkerPointerFourteen = new CircularGaugePointer();
            sixthGaugeMarkerPointerFourteen.Color = "#7edfb4";
            sixthGaugeMarkerPointerFourteen.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFourteen.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFourteen.MarkerWidth = 38;
            sixthGaugeMarkerPointerFourteen.MarkerHeight = 3;
            sixthGaugeMarkerPointerFourteen.Value = 12;
            sixthGaugeMarkerPointerFourteen.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFourteen);

            CircularGaugePointer sixthGaugeMarkerPointerFifteen = new CircularGaugePointer();
            sixthGaugeMarkerPointerFifteen.Color = "#7edfb4";
            sixthGaugeMarkerPointerFifteen.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFifteen.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFifteen.MarkerWidth = 38;
            sixthGaugeMarkerPointerFifteen.MarkerHeight = 3;
            sixthGaugeMarkerPointerFifteen.Value = 13;
            sixthGaugeMarkerPointerFifteen.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFifteen);

            CircularGaugePointer sixthGaugeMarkerPointerSixteen = new CircularGaugePointer();
            sixthGaugeMarkerPointerSixteen.Color = "#7edfb4";
            sixthGaugeMarkerPointerSixteen.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSixteen.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSixteen.MarkerWidth = 38;
            sixthGaugeMarkerPointerSixteen.MarkerHeight = 3;
            sixthGaugeMarkerPointerSixteen.Value = 14;
            sixthGaugeMarkerPointerSixteen.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSixteen);

            CircularGaugePointer sixthGaugeMarkerPointerSeventeen = new CircularGaugePointer();
            sixthGaugeMarkerPointerSeventeen.Color = "#7edfb4";
            sixthGaugeMarkerPointerSeventeen.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSeventeen.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSeventeen.MarkerWidth = 38;
            sixthGaugeMarkerPointerSeventeen.MarkerHeight = 3;
            sixthGaugeMarkerPointerSeventeen.Value = 15;
            sixthGaugeMarkerPointerSeventeen.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSeventeen);

            CircularGaugePointer sixthGaugeMarkerPointerEighteen = new CircularGaugePointer();
            sixthGaugeMarkerPointerEighteen.Color = "#7edfb4";
            sixthGaugeMarkerPointerEighteen.Type = PointerType.Marker;
            sixthGaugeMarkerPointerEighteen.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerEighteen.MarkerWidth = 38;
            sixthGaugeMarkerPointerEighteen.MarkerHeight = 3;
            sixthGaugeMarkerPointerEighteen.Value = 16;
            sixthGaugeMarkerPointerEighteen.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerEighteen);

            CircularGaugePointer sixthGaugeMarkerPointerNineteen = new CircularGaugePointer();
            sixthGaugeMarkerPointerNineteen.Color = "#7edfb4";
            sixthGaugeMarkerPointerNineteen.Type = PointerType.Marker;
            sixthGaugeMarkerPointerNineteen.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerNineteen.MarkerWidth = 38;
            sixthGaugeMarkerPointerNineteen.MarkerHeight = 3;
            sixthGaugeMarkerPointerNineteen.Value = 17;
            sixthGaugeMarkerPointerNineteen.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerNineteen);

            CircularGaugePointer sixthGaugeMarkerPointerTwenty = new CircularGaugePointer();
            sixthGaugeMarkerPointerTwenty.Color = "#7edfb4";
            sixthGaugeMarkerPointerTwenty.Type = PointerType.Marker;
            sixthGaugeMarkerPointerTwenty.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerTwenty.MarkerWidth = 38;
            sixthGaugeMarkerPointerTwenty.MarkerHeight = 3;
            sixthGaugeMarkerPointerTwenty.Value = 18;
            sixthGaugeMarkerPointerTwenty.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerTwenty);

            CircularGaugePointer sixthGaugeMarkerPointerTwentyOne = new CircularGaugePointer();
            sixthGaugeMarkerPointerTwentyOne.Color = "#7edfb4";
            sixthGaugeMarkerPointerTwentyOne.Type = PointerType.Marker;
            sixthGaugeMarkerPointerTwentyOne.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerTwentyOne.MarkerWidth = 38;
            sixthGaugeMarkerPointerTwentyOne.MarkerHeight = 3;
            sixthGaugeMarkerPointerTwentyOne.Value = 19;
            sixthGaugeMarkerPointerTwentyOne.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerTwentyOne);

            CircularGaugePointer sixthGaugeMarkerPointerTwentyTwo = new CircularGaugePointer();
            sixthGaugeMarkerPointerTwentyTwo.Color = "#7edfb4";
            sixthGaugeMarkerPointerTwentyTwo.Type = PointerType.Marker;
            sixthGaugeMarkerPointerTwentyTwo.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerTwentyTwo.MarkerWidth = 38;
            sixthGaugeMarkerPointerTwentyTwo.MarkerHeight = 3;
            sixthGaugeMarkerPointerTwentyTwo.Value = 20;
            sixthGaugeMarkerPointerTwentyTwo.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerTwentyTwo);



            CircularGaugePointer sixthGaugeMarkerPointerTwentyThree = new CircularGaugePointer();
            sixthGaugeMarkerPointerTwentyThree.Color = "#7edfb4";
            sixthGaugeMarkerPointerTwentyThree.Type = PointerType.Marker;
            sixthGaugeMarkerPointerTwentyThree.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerTwentyThree.MarkerWidth = 38;
            sixthGaugeMarkerPointerTwentyThree.MarkerHeight = 3;
            sixthGaugeMarkerPointerTwentyThree.Value = 21;
            sixthGaugeMarkerPointerTwentyThree.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerTwentyThree);

            CircularGaugePointer sixthGaugeMarkerPointerTwentyFour = new CircularGaugePointer();
            sixthGaugeMarkerPointerTwentyFour.Color = "#7edfb4";
            sixthGaugeMarkerPointerTwentyFour.Type = PointerType.Marker;
            sixthGaugeMarkerPointerTwentyFour.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerTwentyFour.MarkerWidth = 38;
            sixthGaugeMarkerPointerTwentyFour.MarkerHeight = 3;
            sixthGaugeMarkerPointerTwentyFour.Value = 22;
            sixthGaugeMarkerPointerTwentyFour.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerTwentyFour);

            CircularGaugePointer sixthGaugeMarkerPointerTwentyFive = new CircularGaugePointer();
            sixthGaugeMarkerPointerTwentyFive.Color = "#7edfb4";
            sixthGaugeMarkerPointerTwentyFive.Type = PointerType.Marker;
            sixthGaugeMarkerPointerTwentyFive.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerTwentyFive.MarkerWidth = 38;
            sixthGaugeMarkerPointerTwentyFive.MarkerHeight = 3;
            sixthGaugeMarkerPointerTwentyFive.Value = 23;
            sixthGaugeMarkerPointerTwentyFive.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerTwentyFive);

            CircularGaugePointer sixthGaugeMarkerPointerTwentySix = new CircularGaugePointer();
            sixthGaugeMarkerPointerTwentySix.Color = "#7edfb4";
            sixthGaugeMarkerPointerTwentySix.Type = PointerType.Marker;
            sixthGaugeMarkerPointerTwentySix.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerTwentySix.MarkerWidth = 38;
            sixthGaugeMarkerPointerTwentySix.MarkerHeight = 3;
            sixthGaugeMarkerPointerTwentySix.Value = 24;
            sixthGaugeMarkerPointerTwentySix.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerTwentySix);

            CircularGaugePointer sixthGaugeMarkerPointerTwentySeven = new CircularGaugePointer();
            sixthGaugeMarkerPointerTwentySeven.Color = "#7edfb4";
            sixthGaugeMarkerPointerTwentySeven.Type = PointerType.Marker;
            sixthGaugeMarkerPointerTwentySeven.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerTwentySeven.MarkerWidth = 38;
            sixthGaugeMarkerPointerTwentySeven.MarkerHeight = 3;
            sixthGaugeMarkerPointerTwentySeven.Value = 25;
            sixthGaugeMarkerPointerTwentySeven.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerTwentySeven);

            CircularGaugePointer sixthGaugeMarkerPointerTwentyEight = new CircularGaugePointer();
            sixthGaugeMarkerPointerTwentyEight.Color = "#7edfb4";
            sixthGaugeMarkerPointerTwentyEight.Type = PointerType.Marker;
            sixthGaugeMarkerPointerTwentyEight.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerTwentyEight.MarkerWidth = 38;
            sixthGaugeMarkerPointerTwentyEight.MarkerHeight = 3;
            sixthGaugeMarkerPointerTwentyEight.Value = 26;
            sixthGaugeMarkerPointerTwentyEight.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerTwentyEight);

            CircularGaugePointer sixthGaugeMarkerPointerTwentyNine = new CircularGaugePointer();
            sixthGaugeMarkerPointerTwentyNine.Color = "#7edfb4";
            sixthGaugeMarkerPointerTwentyNine.Type = PointerType.Marker;
            sixthGaugeMarkerPointerTwentyNine.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerTwentyNine.MarkerWidth = 38;
            sixthGaugeMarkerPointerTwentyNine.MarkerHeight = 3;
            sixthGaugeMarkerPointerTwentyNine.Value = 27;
            sixthGaugeMarkerPointerTwentyNine.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerTwentyNine);

            CircularGaugePointer sixthGaugeMarkerPointerThirty = new CircularGaugePointer();
            sixthGaugeMarkerPointerThirty.Color = "#7edfb4";
            sixthGaugeMarkerPointerThirty.Type = PointerType.Marker;
            sixthGaugeMarkerPointerThirty.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerThirty.MarkerWidth = 38;
            sixthGaugeMarkerPointerThirty.MarkerHeight = 3;
            sixthGaugeMarkerPointerThirty.Value = 28;
            sixthGaugeMarkerPointerThirty.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerThirty);

            CircularGaugePointer sixthGaugeMarkerPointerThirtyOne = new CircularGaugePointer();
            sixthGaugeMarkerPointerThirtyOne.Color = "#7edfb4";
            sixthGaugeMarkerPointerThirtyOne.Type = PointerType.Marker;
            sixthGaugeMarkerPointerThirtyOne.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerThirtyOne.MarkerWidth = 38;
            sixthGaugeMarkerPointerThirtyOne.MarkerHeight = 3;
            sixthGaugeMarkerPointerThirtyOne.Value = 29;
            sixthGaugeMarkerPointerThirtyOne.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerThirtyOne);

            CircularGaugePointer sixthGaugeMarkerPointerThirtyTwo = new CircularGaugePointer();
            sixthGaugeMarkerPointerThirtyTwo.Color = "#7edfb4";
            sixthGaugeMarkerPointerThirtyTwo.Type = PointerType.Marker;
            sixthGaugeMarkerPointerThirtyTwo.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerThirtyTwo.MarkerWidth = 38;
            sixthGaugeMarkerPointerThirtyTwo.MarkerHeight = 3;
            sixthGaugeMarkerPointerThirtyTwo.Value = 30;
            sixthGaugeMarkerPointerThirtyTwo.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerThirtyTwo);

            CircularGaugePointer sixthGaugeMarkerPointerThirtyThree = new CircularGaugePointer();
            sixthGaugeMarkerPointerThirtyThree.Color = "#7edfb4";
            sixthGaugeMarkerPointerThirtyThree.Type = PointerType.Marker;
            sixthGaugeMarkerPointerThirtyThree.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerThirtyThree.MarkerWidth = 38;
            sixthGaugeMarkerPointerThirtyThree.MarkerHeight = 3;
            sixthGaugeMarkerPointerThirtyThree.Value = 31;
            sixthGaugeMarkerPointerThirtyThree.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerThirtyThree);

            CircularGaugePointer sixthGaugeMarkerPointerThirtyFour = new CircularGaugePointer();
            sixthGaugeMarkerPointerThirtyFour.Color = "#7edfb4";
            sixthGaugeMarkerPointerThirtyFour.Type = PointerType.Marker;
            sixthGaugeMarkerPointerThirtyFour.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerThirtyFour.MarkerWidth = 38;
            sixthGaugeMarkerPointerThirtyFour.MarkerHeight = 3;
            sixthGaugeMarkerPointerThirtyFour.Value = 32;
            sixthGaugeMarkerPointerThirtyFour.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerThirtyFour);

            CircularGaugePointer sixthGaugeMarkerPointerThirtyFive = new CircularGaugePointer();
            sixthGaugeMarkerPointerThirtyFive.Color = "#7edfb4";
            sixthGaugeMarkerPointerThirtyFive.Type = PointerType.Marker;
            sixthGaugeMarkerPointerThirtyFive.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerThirtyFive.MarkerWidth = 38;
            sixthGaugeMarkerPointerThirtyFive.MarkerHeight = 3;
            sixthGaugeMarkerPointerThirtyFive.Value = 33;
            sixthGaugeMarkerPointerThirtyFive.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerThirtyFive);

            CircularGaugePointer sixthGaugeMarkerPointerThirtySix = new CircularGaugePointer();
            sixthGaugeMarkerPointerThirtySix.Color = "#7edfb4";
            sixthGaugeMarkerPointerThirtySix.Type = PointerType.Marker;
            sixthGaugeMarkerPointerThirtySix.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerThirtySix.MarkerWidth = 38;
            sixthGaugeMarkerPointerThirtySix.MarkerHeight = 3;
            sixthGaugeMarkerPointerThirtySix.Value = 34;
            sixthGaugeMarkerPointerThirtySix.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerThirtySix);

            CircularGaugePointer sixthGaugeMarkerPointerThirtySeven = new CircularGaugePointer();
            sixthGaugeMarkerPointerThirtySeven.Color = "#7edfb4";
            sixthGaugeMarkerPointerThirtySeven.Type = PointerType.Marker;
            sixthGaugeMarkerPointerThirtySeven.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerThirtySeven.MarkerWidth = 38;
            sixthGaugeMarkerPointerThirtySeven.MarkerHeight = 3;
            sixthGaugeMarkerPointerThirtySeven.Value = 35;
            sixthGaugeMarkerPointerThirtySeven.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerThirtySeven);

            CircularGaugePointer sixthGaugeMarkerPointerThirtyEight = new CircularGaugePointer();
            sixthGaugeMarkerPointerThirtyEight.Color = "#7edfb4";
            sixthGaugeMarkerPointerThirtyEight.Type = PointerType.Marker;
            sixthGaugeMarkerPointerThirtyEight.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerThirtyEight.MarkerWidth = 38;
            sixthGaugeMarkerPointerThirtyEight.MarkerHeight = 3;
            sixthGaugeMarkerPointerThirtyEight.Value = 36;
            sixthGaugeMarkerPointerThirtyEight.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerThirtyEight);

            CircularGaugePointer sixthGaugeMarkerPointerThirtyNine = new CircularGaugePointer();
            sixthGaugeMarkerPointerThirtyNine.Color = "#7edfb4";
            sixthGaugeMarkerPointerThirtyNine.Type = PointerType.Marker;
            sixthGaugeMarkerPointerThirtyNine.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerThirtyNine.MarkerWidth = 38;
            sixthGaugeMarkerPointerThirtyNine.MarkerHeight = 3;
            sixthGaugeMarkerPointerThirtyNine.Value = 37;
            sixthGaugeMarkerPointerThirtyNine.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerThirtyNine);

            CircularGaugePointer sixthGaugeMarkerPointerFourty = new CircularGaugePointer();
            sixthGaugeMarkerPointerFourty.Color = "#7edfb4";
            sixthGaugeMarkerPointerFourty.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFourty.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFourty.MarkerWidth = 38;
            sixthGaugeMarkerPointerFourty.MarkerHeight = 3;
            sixthGaugeMarkerPointerFourty.Value = 38;
            sixthGaugeMarkerPointerFourty.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFourty);

            CircularGaugePointer sixthGaugeMarkerPointerFourtyOne = new CircularGaugePointer();
            sixthGaugeMarkerPointerFourtyOne.Color = "#7edfb4";
            sixthGaugeMarkerPointerFourtyOne.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFourtyOne.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFourtyOne.MarkerWidth = 38;
            sixthGaugeMarkerPointerFourtyOne.MarkerHeight = 3;
            sixthGaugeMarkerPointerFourtyOne.Value = 39;
            sixthGaugeMarkerPointerFourtyOne.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFourtyOne);

            CircularGaugePointer sixthGaugeMarkerPointerFourtyTwo = new CircularGaugePointer();
            sixthGaugeMarkerPointerFourtyTwo.Color = "#7edfb4";
            sixthGaugeMarkerPointerFourtyTwo.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFourtyTwo.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFourtyTwo.MarkerWidth = 38;
            sixthGaugeMarkerPointerFourtyTwo.MarkerHeight = 3;
            sixthGaugeMarkerPointerFourtyTwo.Value = 40;
            sixthGaugeMarkerPointerFourtyTwo.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFourtyTwo);

            CircularGaugePointer sixthGaugeMarkerPointerFourtyThree = new CircularGaugePointer();
            sixthGaugeMarkerPointerFourtyThree.Color = "#7edfb4";
            sixthGaugeMarkerPointerFourtyThree.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFourtyThree.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFourtyThree.MarkerWidth = 38;
            sixthGaugeMarkerPointerFourtyThree.MarkerHeight = 3;
            sixthGaugeMarkerPointerFourtyThree.Value = 41;
            sixthGaugeMarkerPointerFourtyThree.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFourtyThree);

            CircularGaugePointer sixthGaugeMarkerPointerFourtyFour = new CircularGaugePointer();
            sixthGaugeMarkerPointerFourtyFour.Color = "#7edfb4";
            sixthGaugeMarkerPointerFourtyFour.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFourtyFour.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFourtyFour.MarkerWidth = 38;
            sixthGaugeMarkerPointerFourtyFour.MarkerHeight = 3;
            sixthGaugeMarkerPointerFourtyFour.Value = 42;
            sixthGaugeMarkerPointerFourtyFour.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFourtyFour);

            CircularGaugePointer sixthGaugeMarkerPointerFourtyFive = new CircularGaugePointer();
            sixthGaugeMarkerPointerFourtyFive.Color = "#7edfb4";
            sixthGaugeMarkerPointerFourtyFive.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFourtyFive.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFourtyFive.MarkerWidth = 38;
            sixthGaugeMarkerPointerFourtyFive.MarkerHeight = 3;
            sixthGaugeMarkerPointerFourtyFive.Value = 43;
            sixthGaugeMarkerPointerFourtyFive.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFourtyFive);

            CircularGaugePointer sixthGaugeMarkerPointerFourtySix = new CircularGaugePointer();
            sixthGaugeMarkerPointerFourtySix.Color = "#7edfb4";
            sixthGaugeMarkerPointerFourtySix.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFourtySix.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFourtySix.MarkerWidth = 38;
            sixthGaugeMarkerPointerFourtySix.MarkerHeight = 3;
            sixthGaugeMarkerPointerFourtySix.Value = 44;
            sixthGaugeMarkerPointerFourtySix.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFourtySix);

            CircularGaugePointer sixthGaugeMarkerPointerFourtySeven = new CircularGaugePointer();
            sixthGaugeMarkerPointerFourtySeven.Color = "#7edfb4";
            sixthGaugeMarkerPointerFourtySeven.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFourtySeven.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFourtySeven.MarkerWidth = 38;
            sixthGaugeMarkerPointerFourtySeven.MarkerHeight = 3;
            sixthGaugeMarkerPointerFourtySeven.Value = 45;
            sixthGaugeMarkerPointerFourtySeven.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFourtySeven);

            CircularGaugePointer sixthGaugeMarkerPointerFourtyEight = new CircularGaugePointer();
            sixthGaugeMarkerPointerFourtyEight.Color = "#7edfb4";
            sixthGaugeMarkerPointerFourtyEight.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFourtyEight.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFourtyEight.MarkerWidth = 38;
            sixthGaugeMarkerPointerFourtyEight.MarkerHeight = 3;
            sixthGaugeMarkerPointerFourtyEight.Value = 46;
            sixthGaugeMarkerPointerFourtyEight.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFourtyEight);

            CircularGaugePointer sixthGaugeMarkerPointerFourtyNine = new CircularGaugePointer();
            sixthGaugeMarkerPointerFourtyNine.Color = "#7edfb4";
            sixthGaugeMarkerPointerFourtyNine.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFourtyNine.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFourtyNine.MarkerWidth = 38;
            sixthGaugeMarkerPointerFourtyNine.MarkerHeight = 3;
            sixthGaugeMarkerPointerFourtyNine.Value = 47;
            sixthGaugeMarkerPointerFourtyNine.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFourtyNine);

            CircularGaugePointer sixthGaugeMarkerPointerFifty = new CircularGaugePointer();
            sixthGaugeMarkerPointerFifty.Color = "#7edfb4";
            sixthGaugeMarkerPointerFifty.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFifty.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFifty.MarkerWidth = 38;
            sixthGaugeMarkerPointerFifty.MarkerHeight = 3;
            sixthGaugeMarkerPointerFifty.Value = 48;
            sixthGaugeMarkerPointerFifty.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFifty);

            CircularGaugePointer sixthGaugeMarkerPointerFiftyOne = new CircularGaugePointer();
            sixthGaugeMarkerPointerFiftyOne.Color = "#7edfb4";
            sixthGaugeMarkerPointerFiftyOne.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFiftyOne.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFiftyOne.MarkerWidth = 38;
            sixthGaugeMarkerPointerFiftyOne.MarkerHeight = 3;
            sixthGaugeMarkerPointerFiftyOne.Value = 49;
            sixthGaugeMarkerPointerFiftyOne.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFiftyOne);

            CircularGaugePointer sixthGaugeMarkerPointerFiftyTwo = new CircularGaugePointer();
            sixthGaugeMarkerPointerFiftyTwo.Color = "#7edfb4";
            sixthGaugeMarkerPointerFiftyTwo.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFiftyTwo.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFiftyTwo.MarkerWidth = 38;
            sixthGaugeMarkerPointerFiftyTwo.MarkerHeight = 3;
            sixthGaugeMarkerPointerFiftyTwo.Value = 50;
            sixthGaugeMarkerPointerFiftyTwo.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFiftyTwo);

            CircularGaugePointer sixthGaugeMarkerPointerFiftyThree = new CircularGaugePointer();
            sixthGaugeMarkerPointerFiftyThree.Color = "#7edfb4";
            sixthGaugeMarkerPointerFiftyThree.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFiftyThree.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFiftyThree.MarkerWidth = 38;
            sixthGaugeMarkerPointerFiftyThree.MarkerHeight = 3;
            sixthGaugeMarkerPointerFiftyThree.Value = 51;
            sixthGaugeMarkerPointerFiftyThree.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFiftyThree);

            CircularGaugePointer sixthGaugeMarkerPointerFiftyFour = new CircularGaugePointer();
            sixthGaugeMarkerPointerFiftyFour.Color = "#7edfb4";
            sixthGaugeMarkerPointerFiftyFour.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFiftyFour.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFiftyFour.MarkerWidth = 38;
            sixthGaugeMarkerPointerFiftyFour.MarkerHeight = 3;
            sixthGaugeMarkerPointerFiftyFour.Value = 52;
            sixthGaugeMarkerPointerFiftyFour.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFiftyFour);

            CircularGaugePointer sixthGaugeMarkerPointerFiftyFive = new CircularGaugePointer();
            sixthGaugeMarkerPointerFiftyFive.Color = "#7edfb4";
            sixthGaugeMarkerPointerFiftyFive.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFiftyFive.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFiftyFive.MarkerWidth = 38;
            sixthGaugeMarkerPointerFiftyFive.MarkerHeight = 3;
            sixthGaugeMarkerPointerFiftyFive.Value = 53;
            sixthGaugeMarkerPointerFiftyFive.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFiftyFive);

            CircularGaugePointer sixthGaugeMarkerPointerFiftySix = new CircularGaugePointer();
            sixthGaugeMarkerPointerFiftySix.Color = "#7edfb4";
            sixthGaugeMarkerPointerFiftySix.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFiftySix.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFiftySix.MarkerWidth = 38;
            sixthGaugeMarkerPointerFiftySix.MarkerHeight = 3;
            sixthGaugeMarkerPointerFiftySix.Value = 54;
            sixthGaugeMarkerPointerFiftySix.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFiftySix);

            CircularGaugePointer sixthGaugeMarkerPointerFiftySeven = new CircularGaugePointer();
            sixthGaugeMarkerPointerFiftySeven.Color = "#7edfb4";
            sixthGaugeMarkerPointerFiftySeven.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFiftySeven.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFiftySeven.MarkerWidth = 38;
            sixthGaugeMarkerPointerFiftySeven.MarkerHeight = 3;
            sixthGaugeMarkerPointerFiftySeven.Value = 55;
            sixthGaugeMarkerPointerFiftySeven.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFiftySeven);

            CircularGaugePointer sixthGaugeMarkerPointerFiftyEight = new CircularGaugePointer();
            sixthGaugeMarkerPointerFiftyEight.Color = "#7edfb4";
            sixthGaugeMarkerPointerFiftyEight.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFiftyEight.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFiftyEight.MarkerWidth = 38;
            sixthGaugeMarkerPointerFiftyEight.MarkerHeight = 3;
            sixthGaugeMarkerPointerFiftyEight.Value = 56;
            sixthGaugeMarkerPointerFiftyEight.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFiftyEight);

            CircularGaugePointer sixthGaugeMarkerPointerFiftyNine = new CircularGaugePointer();
            sixthGaugeMarkerPointerFiftyNine.Color = "#7edfb4";
            sixthGaugeMarkerPointerFiftyNine.Type = PointerType.Marker;
            sixthGaugeMarkerPointerFiftyNine.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerFiftyNine.MarkerWidth = 38;
            sixthGaugeMarkerPointerFiftyNine.MarkerHeight = 3;
            sixthGaugeMarkerPointerFiftyNine.Value = 57;
            sixthGaugeMarkerPointerFiftyNine.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerFiftyNine);

            CircularGaugePointer sixthGaugeMarkerPointerSixty = new CircularGaugePointer();
            sixthGaugeMarkerPointerSixty.Color = "#7edfb4";
            sixthGaugeMarkerPointerSixty.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSixty.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSixty.MarkerWidth = 38;
            sixthGaugeMarkerPointerSixty.MarkerHeight = 3;
            sixthGaugeMarkerPointerSixty.Value = 58;
            sixthGaugeMarkerPointerSixty.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSixty);

            CircularGaugePointer sixthGaugeMarkerPointerSixtyOne = new CircularGaugePointer();
            sixthGaugeMarkerPointerSixtyOne.Color = "#7edfb4";
            sixthGaugeMarkerPointerSixtyOne.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSixtyOne.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSixtyOne.MarkerWidth = 38;
            sixthGaugeMarkerPointerSixtyOne.MarkerHeight = 3;
            sixthGaugeMarkerPointerSixtyOne.Value = 59;
            sixthGaugeMarkerPointerSixtyOne.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSixtyOne);

            CircularGaugePointer sixthGaugeMarkerPointerSixtyTwo = new CircularGaugePointer();
            sixthGaugeMarkerPointerSixtyTwo.Color = "#7edfb4";
            sixthGaugeMarkerPointerSixtyTwo.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSixtyTwo.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSixtyTwo.MarkerWidth = 38;
            sixthGaugeMarkerPointerSixtyTwo.MarkerHeight = 3;
            sixthGaugeMarkerPointerSixtyTwo.Value = 60;
            sixthGaugeMarkerPointerSixtyTwo.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSixtyTwo);

            CircularGaugePointer sixthGaugeMarkerPointerSixtyThree = new CircularGaugePointer();
            sixthGaugeMarkerPointerSixtyThree.Color = "#7edfb4";
            sixthGaugeMarkerPointerSixtyThree.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSixtyThree.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSixtyThree.MarkerWidth = 38;
            sixthGaugeMarkerPointerSixtyThree.MarkerHeight = 3;
            sixthGaugeMarkerPointerSixtyThree.Value = 61;
            sixthGaugeMarkerPointerSixtyThree.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSixtyThree);

            CircularGaugePointer sixthGaugeMarkerPointerSixtyFour = new CircularGaugePointer();
            sixthGaugeMarkerPointerSixtyFour.Color = "#7edfb4";
            sixthGaugeMarkerPointerSixtyFour.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSixtyFour.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSixtyFour.MarkerWidth = 38;
            sixthGaugeMarkerPointerSixtyFour.MarkerHeight = 3;
            sixthGaugeMarkerPointerSixtyFour.Value = 62;
            sixthGaugeMarkerPointerSixtyFour.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSixtyFour);

            CircularGaugePointer sixthGaugeMarkerPointerSixtyFive = new CircularGaugePointer();
            sixthGaugeMarkerPointerSixtyFive.Color = "#7edfb4";
            sixthGaugeMarkerPointerSixtyFive.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSixtyFive.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSixtyFive.MarkerWidth = 38;
            sixthGaugeMarkerPointerSixtyFive.MarkerHeight = 3;
            sixthGaugeMarkerPointerSixtyFive.Value = 63;
            sixthGaugeMarkerPointerSixtyFive.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSixtyFive);

            CircularGaugePointer sixthGaugeMarkerPointerSixtySix = new CircularGaugePointer();
            sixthGaugeMarkerPointerSixtySix.Color = "#7edfb4";
            sixthGaugeMarkerPointerSixtySix.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSixtySix.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSixtySix.MarkerWidth = 38;
            sixthGaugeMarkerPointerSixtySix.MarkerHeight = 3;
            sixthGaugeMarkerPointerSixtySix.Value = 64;
            sixthGaugeMarkerPointerSixtySix.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSixtySix);

            CircularGaugePointer sixthGaugeMarkerPointerSixtySeven = new CircularGaugePointer();
            sixthGaugeMarkerPointerSixtySeven.Color = "#7edfb4";
            sixthGaugeMarkerPointerSixtySeven.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSixtySeven.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSixtySeven.MarkerWidth = 38;
            sixthGaugeMarkerPointerSixtySeven.MarkerHeight = 3;
            sixthGaugeMarkerPointerSixtySeven.Value = 65;
            sixthGaugeMarkerPointerSixtySeven.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSixtySeven);

            CircularGaugePointer sixthGaugeMarkerPointerSixtyEight = new CircularGaugePointer();
            sixthGaugeMarkerPointerSixtyEight.Color = "#7edfb4";
            sixthGaugeMarkerPointerSixtyEight.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSixtyEight.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSixtyEight.MarkerWidth = 38;
            sixthGaugeMarkerPointerSixtyEight.MarkerHeight = 3;
            sixthGaugeMarkerPointerSixtyEight.Value = 66;
            sixthGaugeMarkerPointerSixtyEight.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSixtyEight);

            CircularGaugePointer sixthGaugeMarkerPointerSixtyNine = new CircularGaugePointer();
            sixthGaugeMarkerPointerSixtyNine.Color = "#7edfb4";
            sixthGaugeMarkerPointerSixtyNine.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSixtyNine.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSixtyNine.MarkerWidth = 38;
            sixthGaugeMarkerPointerSixtyNine.MarkerHeight = 3;
            sixthGaugeMarkerPointerSixtyNine.Value = 67;
            sixthGaugeMarkerPointerSixtyNine.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSixtyNine);

            CircularGaugePointer sixthGaugeMarkerPointerSeventy = new CircularGaugePointer();
            sixthGaugeMarkerPointerSeventy.Color = "#7edfb4";
            sixthGaugeMarkerPointerSeventy.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSeventy.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSeventy.MarkerWidth = 38;
            sixthGaugeMarkerPointerSeventy.MarkerHeight = 3;
            sixthGaugeMarkerPointerSeventy.Value = 68;
            sixthGaugeMarkerPointerSeventy.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSeventy);

            CircularGaugePointer sixthGaugeMarkerPointerSeventyOne = new CircularGaugePointer();
            sixthGaugeMarkerPointerSeventyOne.Color = "#7edfb4";
            sixthGaugeMarkerPointerSeventyOne.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSeventyOne.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSeventyOne.MarkerWidth = 38;
            sixthGaugeMarkerPointerSeventyOne.MarkerHeight = 3;
            sixthGaugeMarkerPointerSeventyOne.Value = 69;
            sixthGaugeMarkerPointerSeventyOne.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSeventyOne);

            CircularGaugePointer sixthGaugeMarkerPointerSeventyTwo = new CircularGaugePointer();
            sixthGaugeMarkerPointerSeventyTwo.Color = "#7edfb4";
            sixthGaugeMarkerPointerSeventyTwo.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSeventyTwo.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSeventyTwo.MarkerWidth = 38;
            sixthGaugeMarkerPointerSeventyTwo.MarkerHeight = 3;
            sixthGaugeMarkerPointerSeventyTwo.Value = 70;
            sixthGaugeMarkerPointerSeventyTwo.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSeventyTwo);

            CircularGaugePointer sixthGaugeMarkerPointerSeventyThree = new CircularGaugePointer();
            sixthGaugeMarkerPointerSeventyThree.Color = "#7edfb4";
            sixthGaugeMarkerPointerSeventyThree.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSeventyThree.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSeventyThree.MarkerWidth = 38;
            sixthGaugeMarkerPointerSeventyThree.MarkerHeight = 3;
            sixthGaugeMarkerPointerSeventyThree.Value = 71;
            sixthGaugeMarkerPointerSeventyThree.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSeventyThree);

            CircularGaugePointer sixthGaugeMarkerPointerSeventyFour = new CircularGaugePointer();
            sixthGaugeMarkerPointerSeventyFour.Color = "#7edfb4";
            sixthGaugeMarkerPointerSeventyFour.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSeventyFour.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSeventyFour.MarkerWidth = 38;
            sixthGaugeMarkerPointerSeventyFour.MarkerHeight = 3;
            sixthGaugeMarkerPointerSeventyFour.Value = 72;
            sixthGaugeMarkerPointerSeventyFour.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSeventyFour);

            CircularGaugePointer sixthGaugeMarkerPointerSeventyFive = new CircularGaugePointer();
            sixthGaugeMarkerPointerSeventyFive.Color = "#7edfb4";
            sixthGaugeMarkerPointerSeventyFive.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSeventyFive.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSeventyFive.MarkerWidth = 38;
            sixthGaugeMarkerPointerSeventyFive.MarkerHeight = 3;
            sixthGaugeMarkerPointerSeventyFive.Value = 73;
            sixthGaugeMarkerPointerSeventyFive.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSeventyFive);

            CircularGaugePointer sixthGaugeMarkerPointerSeventySix = new CircularGaugePointer();
            sixthGaugeMarkerPointerSeventySix.Color = "#7edfb4";
            sixthGaugeMarkerPointerSeventySix.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSeventySix.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSeventySix.MarkerWidth = 38;
            sixthGaugeMarkerPointerSeventySix.MarkerHeight = 3;
            sixthGaugeMarkerPointerSeventySix.Value = 74;
            sixthGaugeMarkerPointerSeventySix.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSeventySix);

            CircularGaugePointer sixthGaugeMarkerPointerSeventySeven = new CircularGaugePointer();
            sixthGaugeMarkerPointerSeventySeven.Color = "#7edfb4";
            sixthGaugeMarkerPointerSeventySeven.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSeventySeven.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSeventySeven.MarkerWidth = 38;
            sixthGaugeMarkerPointerSeventySeven.MarkerHeight = 3;
            sixthGaugeMarkerPointerSeventySeven.Value = 75;
            sixthGaugeMarkerPointerSeventySeven.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSeventySeven);

            CircularGaugePointer sixthGaugeMarkerPointerSeventyEight = new CircularGaugePointer();
            sixthGaugeMarkerPointerSeventyEight.Color = "#7edfb4";
            sixthGaugeMarkerPointerSeventyEight.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSeventyEight.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSeventyEight.MarkerWidth = 38;
            sixthGaugeMarkerPointerSeventyEight.MarkerHeight = 3;
            sixthGaugeMarkerPointerSeventyEight.Value = 76;
            sixthGaugeMarkerPointerSeventyEight.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSeventyEight);

            CircularGaugePointer sixthGaugeMarkerPointerSeventyNine = new CircularGaugePointer();
            sixthGaugeMarkerPointerSeventyNine.Color = "#7edfb4";
            sixthGaugeMarkerPointerSeventyNine.Type = PointerType.Marker;
            sixthGaugeMarkerPointerSeventyNine.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerSeventyNine.MarkerWidth = 38;
            sixthGaugeMarkerPointerSeventyNine.MarkerHeight = 3;
            sixthGaugeMarkerPointerSeventyNine.Value = 77;
            sixthGaugeMarkerPointerSeventyNine.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerSeventyNine);

            CircularGaugePointer sixthGaugeMarkerPointerEighty = new CircularGaugePointer();
            sixthGaugeMarkerPointerEighty.Color = "#7edfb4";
            sixthGaugeMarkerPointerEighty.Type = PointerType.Marker;
            sixthGaugeMarkerPointerEighty.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerEighty.MarkerWidth = 38;
            sixthGaugeMarkerPointerEighty.MarkerHeight = 3;
            sixthGaugeMarkerPointerEighty.Value = 78;
            sixthGaugeMarkerPointerEighty.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerEighty);

            CircularGaugePointer sixthGaugeMarkerPointerEightyOne = new CircularGaugePointer();
            sixthGaugeMarkerPointerEightyOne.Color = "#7edfb4";
            sixthGaugeMarkerPointerEightyOne.Type = PointerType.Marker;
            sixthGaugeMarkerPointerEightyOne.MarkerShape = GaugeShape.Rectangle;
            sixthGaugeMarkerPointerEightyOne.MarkerWidth = 38;
            sixthGaugeMarkerPointerEightyOne.MarkerHeight = 3;
            sixthGaugeMarkerPointerEightyOne.Value = 79;
            sixthGaugeMarkerPointerEightyOne.Animation = new CircularGaugeAnimation
            {
                Enable = false
            };
            sixthGaugePointerCollections.Add(sixthGaugeMarkerPointerEightyOne);

            ViewData["SixthGaugePointers"] = sixthGaugePointerCollections;

            List<CircularGaugeAnnotation> SixthGaugeAnnotations = new List<CircularGaugeAnnotation>();
            CircularGaugeAnnotation sixthGaugeAnnotationValue = new CircularGaugeAnnotation();
            sixthGaugeAnnotationValue.Angle = 10;
            sixthGaugeAnnotationValue.ZIndex = "1";
            sixthGaugeAnnotationValue.Radius = "7%";
            sixthGaugeAnnotationValue.Content = "<div class='annotationText' style='font-size:18px;font-family:inherit;text-align:center'>80% <br/> <div> Completed </div> </div>";
            SixthGaugeAnnotations.Add(sixthGaugeAnnotationValue);

            ViewData["SixthGaugeAnnotations"] = SixthGaugeAnnotations;

            return View();
        }
    }
}