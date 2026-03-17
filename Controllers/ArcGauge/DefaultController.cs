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
using Syncfusion.EJ2.CircularGauge;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.ArcGauge
{
    public partial class ArcGaugeController : Controller
    {
        // GET: Default
        public ActionResult Default()
        {
            List<CircularGaugeRange> rangeCollections = new List<CircularGaugeRange>();
            CircularGaugeRange youTubeRange = new CircularGaugeRange();
            youTubeRange.Start = 0;
            youTubeRange.End = 68;
            youTubeRange.Color = "#c8eab7";
            youTubeRange.Radius = "94%";
            youTubeRange.StartWidth = "22";
            youTubeRange.EndWidth = "22";
            rangeCollections.Add(youTubeRange);

            CircularGaugeRange youTubeRangeLine = new CircularGaugeRange();
            youTubeRangeLine.Start = 74;
            youTubeRangeLine.End = 100;
            youTubeRangeLine.Color = "#7a7f82";
            youTubeRangeLine.Radius = "89%";
            youTubeRangeLine.StartWidth = "1";
            youTubeRangeLine.EndWidth = "1";
            rangeCollections.Add(youTubeRangeLine);

            CircularGaugeRange instagramRange = new CircularGaugeRange();
            instagramRange.Start = 0;
            instagramRange.End = 43;
            instagramRange.Color = "#82cdbc";
            instagramRange.Radius = "80%";
            instagramRange.StartWidth = "22";
            instagramRange.EndWidth = "22";
            rangeCollections.Add(instagramRange);

            CircularGaugeRange instagramRangeLine = new CircularGaugeRange();
            instagramRangeLine.Start = 49;
            instagramRangeLine.End = 100;
            instagramRangeLine.Color = "#7a7f82";
            instagramRangeLine.Radius = "75%";
            instagramRangeLine.StartWidth = "1";
            instagramRangeLine.EndWidth = "1";
            rangeCollections.Add(instagramRangeLine);


            CircularGaugeRange twitterRange = new CircularGaugeRange();
            twitterRange.Start = 0;
            twitterRange.End = 21;
            twitterRange.Color = "#43b6c4";
            twitterRange.Radius = "66%";
            twitterRange.StartWidth = "22";
            twitterRange.EndWidth = "22";
            rangeCollections.Add(twitterRange);

            CircularGaugeRange twitterRangeLine = new CircularGaugeRange();
            twitterRangeLine.Start = 28;
            twitterRangeLine.End = 100;
            twitterRangeLine.Color = "#7a7f82";
            twitterRangeLine.Radius = "61%";
            twitterRangeLine.StartWidth = "1";
            twitterRangeLine.EndWidth = "1";
            rangeCollections.Add(twitterRangeLine);

            CircularGaugeRange facebookRange = new CircularGaugeRange();
            facebookRange.Start = 0;
            facebookRange.End = 75;
            facebookRange.Color = "#1d91bf";
            facebookRange.Radius = "52%";
            facebookRange.StartWidth = "22";
            facebookRange.EndWidth = "22";
            rangeCollections.Add(facebookRange);

            CircularGaugeRange facebookRangeLine = new CircularGaugeRange();
            facebookRangeLine.Start = 85;
            facebookRangeLine.End = 100;
            facebookRangeLine.Color = "#7a7f82";
            facebookRangeLine.Radius = "47%";
            facebookRangeLine.StartWidth = "1";
            facebookRangeLine.EndWidth = "1";
            rangeCollections.Add(facebookRangeLine);

            CircularGaugeRange tiktokRange = new CircularGaugeRange();
            tiktokRange.Start = 0;
            tiktokRange.End = 44;
            tiktokRange.Color = "#205ea8";
            tiktokRange.Radius = "38%";
            tiktokRange.StartWidth = "22";
            tiktokRange.EndWidth = "22";
            rangeCollections.Add(tiktokRange);

            CircularGaugeRange tiktokRangeLine = new CircularGaugeRange();
            tiktokRangeLine.Start = 55;
            tiktokRangeLine.End = 100;
            tiktokRangeLine.Color = "#7a7f82";
            tiktokRangeLine.Radius = "34%";
            tiktokRangeLine.StartWidth = "1";
            tiktokRangeLine.EndWidth = "1";
            rangeCollections.Add(tiktokRangeLine);

            ViewData["Ranges"] = rangeCollections;

            List<CircularGaugeAnnotation> annotationCollections = new List<CircularGaugeAnnotation>();
            CircularGaugeAnnotation youtubeText = new CircularGaugeAnnotation();
            youtubeText.Content = "<div class='titleText' style='color:#c8eab7;font-family:inherit;'>YouTube</div>";
            youtubeText.Angle = 344;
            youtubeText.Radius = "94%";
            youtubeText.ZIndex = "1";
            annotationCollections.Add(youtubeText);

            CircularGaugeAnnotation instagramText = new CircularGaugeAnnotation();
            instagramText.Content = "<div class='titleText' style='color:#82cdbc;font-family:inherit;'>Instagram</div>";
            instagramText.Angle = 340;
            instagramText.Radius = "81%";
            instagramText.ZIndex = "1";
            annotationCollections.Add(instagramText);

            CircularGaugeAnnotation twitterText = new CircularGaugeAnnotation();
            twitterText.Content = "<div class='titleText' style='color:#43b6c4;font-family:inherit;'>Twitter</div>";
            twitterText.Angle = 340;
            twitterText.Radius = "66%";
            twitterText.ZIndex = "1";
            annotationCollections.Add(twitterText);

            CircularGaugeAnnotation facebookText = new CircularGaugeAnnotation();
            facebookText.Content = "<div class='titleText' style='color:#1d91bf;font-family:inherit;'>Facebook</div>";
            facebookText.Angle = 332;
            facebookText.Radius = "55%";
            facebookText.ZIndex = "1";
            annotationCollections.Add(facebookText);

            CircularGaugeAnnotation tiktokText = new CircularGaugeAnnotation();
            tiktokText.Content = "<div class='titleText' style='color:#205ea8;font-family:inherit;'>TikTok</div>";
            tiktokText.Angle = 328;
            tiktokText.Radius = "40%";
            tiktokText.ZIndex = "1";
            annotationCollections.Add(tiktokText);

            CircularGaugeAnnotation youtubeAnnotationValue = new CircularGaugeAnnotation();
            youtubeAnnotationValue.Content = "<div class='annotationText'>68%</div>";
            youtubeAnnotationValue.Angle = 191;
            youtubeAnnotationValue.Radius = "89%";
            youtubeAnnotationValue.ZIndex = "1";
            annotationCollections.Add(youtubeAnnotationValue);

            CircularGaugeAnnotation instagramAnnotationValue = new CircularGaugeAnnotation();
            instagramAnnotationValue.Content = "<div class='annotationText'>43%</div>";
            instagramAnnotationValue.Angle = 125;
            instagramAnnotationValue.Radius = "75%";
            instagramAnnotationValue.ZIndex = "1";
            annotationCollections.Add(instagramAnnotationValue);

            CircularGaugeAnnotation twitterAnnotationValue = new CircularGaugeAnnotation();
            twitterAnnotationValue.Content = "<div class='annotationText'>21%</div>";
            twitterAnnotationValue.Angle = 67;
            twitterAnnotationValue.Radius = "62%";
            twitterAnnotationValue.ZIndex = "1";
            annotationCollections.Add(twitterAnnotationValue);

            CircularGaugeAnnotation facebookAnnotationValue = new CircularGaugeAnnotation();
            facebookAnnotationValue.Content = "<div class='annotationText'>75%</div>";
            facebookAnnotationValue.Angle = 215;
            facebookAnnotationValue.Radius = "48%";
            facebookAnnotationValue.ZIndex = "1";
            annotationCollections.Add(facebookAnnotationValue);

            CircularGaugeAnnotation tiktokAnnotationValue = new CircularGaugeAnnotation();
            tiktokAnnotationValue.Content = "<div class='annotationText'>44%</div>";
            tiktokAnnotationValue.Angle = 133;
            tiktokAnnotationValue.Radius = "33%";
            tiktokAnnotationValue.ZIndex = "1";
            annotationCollections.Add(tiktokAnnotationValue);

            ViewData["Annotations"] = annotationCollections;

            ViewData["labelFont"] = new CircularGaugeFont
            {
                FontFamily = "inherit",
                Size = "0px",
                Opacity = 1,
            };
            return View();
        }
    }
}