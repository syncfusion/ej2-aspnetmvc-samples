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
using Syncfusion.EJ2.CircularGauge;


namespace EJ2MVCSampleBrowser.Controllers.CircularGauge
{
    public partial class CircularGaugeController : Controller
    {
        // GET: PointerCustom
        public ActionResult PointerCustomization()
        {

 
            // First gauge //
            List<CircularGaugePointer> firstPointers = new List<CircularGaugePointer>();
            CircularGaugePointer pointer1 = new CircularGaugePointer();
            pointer1.Radius = "100%";
            pointer1.Value = 80;
            pointer1.Type = PointerType.Marker;
            pointer1.MarkerShape = GaugeShape.InvertedTriangle;
            pointer1.MarkerHeight = 15;
            pointer1.MarkerWidth = 15;
            pointer1.Color = "rgb(0,171,169)";
            firstPointers.Add(pointer1);
            ViewBag.FirstPointers = firstPointers;


            List<CircularGaugeAnnotation> firstAnnotations = new List<CircularGaugeAnnotation>();
            CircularGaugeAnnotation annotation1 = new CircularGaugeAnnotation();
            annotation1.Angle = 180;
            annotation1.ZIndex = "1";
            annotation1.Radius = "20%";
            annotation1.Content = "<div style='color:#757575; font-family:Roboto; font-size:14px;'>Marker</div>";
            firstAnnotations.Add(annotation1);

            ViewBag.FirstAnnotations = firstAnnotations;

            // Second Gauge //

            List<CircularGaugeAnnotation> secondAnnotations = new List<CircularGaugeAnnotation>();
            CircularGaugeAnnotation annotation2 = new CircularGaugeAnnotation();
            annotation2.Angle = 180;
            annotation2.ZIndex = "1";
            annotation2.Radius = "20%";
            annotation2.Content = "<div style='color:#757575; font-family:Roboto; font-size:14px;'>Range Bar</div>";
            secondAnnotations.Add(annotation2);

            ViewBag.SecondAnnotations = secondAnnotations;

            List<CircularGaugePointer> secondPointers = new List<CircularGaugePointer>();
            CircularGaugePointer pointer2 = new CircularGaugePointer();
            pointer2.Radius = "90%";
            pointer2.Value = 66;
            pointer2.Type = PointerType.RangeBar;
            pointer2.Color = "#ff5985";
            pointer2.PointerWidth = 10;
            pointer2.Animation = new CircularGaugeAnimation { Enable = true, Duration = 1000 };
            secondPointers.Add(pointer2);
            ViewBag.SecondPointers = secondPointers;

 

            // Third gauge //

            List<CircularGaugeAnnotation> thirdAnnotations = new List<CircularGaugeAnnotation>();
            CircularGaugeAnnotation annotation3 = new CircularGaugeAnnotation();
            annotation3.Angle = 180;
            annotation3.ZIndex = "1";
            annotation3.Radius = "20%";
            annotation3.Content = "<div style='color:#757575; font-family:Roboto; font-size:14px;'>Needle</div>";
            thirdAnnotations.Add(annotation3);

            ViewBag.ThirdAnnotations = thirdAnnotations;

            List<CircularGaugePointer> thirdPointers = new List<CircularGaugePointer>();
            CircularGaugePointer pointer3 = new CircularGaugePointer();
            pointer3.Radius = "100%";
            pointer3.Value = 70;
            pointer3.PointerWidth = 6;
            pointer3.Color = "#923C99";
            pointer3.PointerWidth = 10;
            pointer3.Cap = new CircularGaugeCap { Radius = 0, Color = "transparent" };
            pointer3.NeedleTail = new CircularGaugeNeedleTail { Length = "4%", Color = "#923C99" };
            pointer3.Animation = new CircularGaugeAnimation { Enable = true, Duration = 900 };
            thirdPointers.Add(pointer3);
            ViewBag.ThirdPointers = thirdPointers;

 

            // Fourth Gauge //

            List<CircularGaugeAnnotation> fourthAnnotations = new List<CircularGaugeAnnotation>();
            CircularGaugeAnnotation annotation4 = new CircularGaugeAnnotation();
            annotation4.Angle = 180;
            annotation4.ZIndex = "1";
            annotation4.Radius = "20%";
            annotation4.Content = "<div style='color:#757575;font-family:Roboto;font-size:14px;padding-top:10px;'>Customized Needle</div>";
            fourthAnnotations.Add(annotation4);


            ViewBag.FourthAnnotations = fourthAnnotations;



            List<CircularGaugePointer> fourthPointers = new List<CircularGaugePointer>();
            CircularGaugePointer pointer4 = new CircularGaugePointer();
            pointer4.Radius = "90%";
            pointer4.Value = 70;
            pointer4.Color = "#1E7145";
            pointer4.PointerWidth = 2;
            pointer4.Border = new CircularGaugeBorder { Width = 1, Color = "#1E7145" };
            pointer4.Cap = new CircularGaugeCap { Radius= 8, Color = "green" };
            pointer4.Animation = new CircularGaugeAnimation { Enable = true, Duration = 1000 };
            fourthPointers.Add(pointer4);
            ViewBag.FourthPointers = fourthPointers;

           
            // Fifth gauge //


            List<CircularGaugeAnnotation> fifthAnnotations = new List<CircularGaugeAnnotation>();
            CircularGaugeAnnotation annotation5 = new CircularGaugeAnnotation();
            annotation5.Angle = 180;
            annotation5.ZIndex = "1";
            annotation5.Radius = "20%";
            annotation5.Content = "<div style='color:#757575; font-family:Roboto; font-size:14px; padding-top:10px;'>Multiple Needles</div>";
            fifthAnnotations.Add(annotation5);


            ViewBag.FifthAnnotations = fifthAnnotations;



            List<CircularGaugePointer> fifthPointers = new List<CircularGaugePointer>();


            CircularGaugePointer pointer5_1 = new CircularGaugePointer();
            pointer5_1.Radius = "80%";
            pointer5_1.Value = 80;
            pointer5_1.MarkerHeight = 5;
            pointer5_1.MarkerWidth = 5;
            pointer5_1.Color = "#ffb133";
            pointer5_1.PointerWidth = 10;
            pointer5_1.Cap = new  CircularGaugeCap{ Radius = 8, Color="white", Border = new CircularGaugeBorder{ Color= "#ffb133", Width=1 } };
            pointer5_1.NeedleTail = new  CircularGaugeNeedleTail{ Length = "20%", Color = "#ffb133" };
            pointer5_1.Animation = new CircularGaugeAnimation{ Enable = true, Duration = 1000 };
            fifthPointers.Add(pointer5_1);


            CircularGaugePointer pointer5_2 = new CircularGaugePointer();
            pointer5_2.Radius = "60%";
            pointer5_2.Value = 40;
            pointer5_2.MarkerHeight = 5;
            pointer5_2.MarkerWidth = 5;
            pointer5_2.Color = "#ffb133";
            pointer5_2.PointerWidth = 10;
            pointer5_2.Cap = new CircularGaugeCap { Radius = 8, Color = "white", Border = new CircularGaugeBorder { Color = "#ffb133", Width = 1 } };
            pointer5_2.NeedleTail = new CircularGaugeNeedleTail{ Length = "20%", Color = "#ffb133" };
            pointer5_2.Animation = new CircularGaugeAnimation{ Enable = true, Duration = 1000 };
            fifthPointers.Add(pointer5_2);


            ViewBag.FifthPointers = fifthPointers;


            // Sixth gauge //


            List<CircularGaugeAnnotation> sixthAnnotations = new List<CircularGaugeAnnotation>();
            CircularGaugeAnnotation annotation6 = new CircularGaugeAnnotation();
            annotation6.Angle = 180;
            annotation6.ZIndex = "1";
            annotation6.Radius = "20%";
            annotation6.Content = "<div style='color:#757575; font-family:Roboto; font-size:14px; padding-top:10px;'>Live Update</div>";
            sixthAnnotations.Add(annotation6);


            ViewBag.SixthAnnotations = sixthAnnotations;



            List<CircularGaugePointer> sixthPointers = new List<CircularGaugePointer>();


            CircularGaugePointer pointer6_1 = new CircularGaugePointer();
            pointer6_1.Radius = "100%";
            pointer6_1.Value = 40;
            pointer6_1.Color = "#067bc2";
            pointer6_1.PointerWidth = 6;
            pointer6_1.Cap = new CircularGaugeCap { Radius = 0, Color="transparent" };
            pointer6_1.NeedleTail = new CircularGaugeNeedleTail { Length = "4%", Color = "#067bc2" };
            pointer6_1.Animation = new CircularGaugeAnimation{ Enable = true, Duration = 900 };
            sixthPointers.Add(pointer6_1);


            CircularGaugePointer pointer6_2 = new CircularGaugePointer();
            pointer6_2.Radius = "100%";
            pointer6_2.Type = PointerType.RangeBar;
            pointer6_2.Value = 40;
            pointer6_2.PointerWidth = 6;
            pointer6_2.Color = "#067bc2";
            pointer6_2.Animation = new CircularGaugeAnimation{ Enable = true, Duration = 900 };
            sixthPointers.Add(pointer6_2);

            ViewBag.SixthPointers = sixthPointers;
            return View();
        }
    }
}
