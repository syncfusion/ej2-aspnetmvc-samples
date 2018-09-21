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
        // GET: Image
        public ActionResult PointerImage()
        {

            // Annotations //

            List<CircularGaugeAnnotation> annotations = new List<CircularGaugeAnnotation>();

            CircularGaugeAnnotation annotation1 = new CircularGaugeAnnotation();
            annotation1.Content = "12 M";
            annotation1.Radius = "108%";
            annotation1.Angle = 98;
            annotation1.ZIndex = "1";

            annotations.Add(annotation1);


            CircularGaugeAnnotation annotation2 = new CircularGaugeAnnotation();
            annotation2.Content = "11 M";
            annotation2.Radius = "80%";
            annotation2.Angle = 81;
            annotation2.ZIndex = "1";

            annotations.Add(annotation2);

            CircularGaugeAnnotation annotation3 = new CircularGaugeAnnotation();
            annotation3.Content = "10 M";
            annotation3.Radius = "50%";
            annotation3.Angle = 69;
            annotation3.ZIndex = "1";

            annotations.Add(annotation3);

            CircularGaugeAnnotation annotation4 = new CircularGaugeAnnotation();
            annotation4.Content = "Doe";
            annotation4.Radius = "108%";
            annotation4.Angle = 190;
            annotation4.ZIndex = "1";

            annotations.Add(annotation4);

            CircularGaugeAnnotation annotation5 = new CircularGaugeAnnotation();
            annotation5.Content = "Almaida";
            annotation5.Radius = "80%";
            annotation5.Angle = 185;
            annotation5.ZIndex = "1";

            annotations.Add(annotation5);

            CircularGaugeAnnotation annotation6 = new CircularGaugeAnnotation();
            annotation6.Content = "John";
            annotation6.Radius = "50%";
            annotation6.Angle = 180;
            annotation6.ZIndex = "1";

            annotations.Add(annotation6);

            ViewBag.Annotations = annotations;

            // Ranges //
            List<CircularGaugeRange> ranges = new List<CircularGaugeRange>();
            CircularGaugeRange range1 = new CircularGaugeRange();
            range1.Start = 0;
            range1.End = 12;
            range1.Radius = "115%";
            range1.Color = "#01aebe";
            range1.StartWidth = "25";
            range1.EndWidth = "25";
            ranges.Add(range1);

            CircularGaugeRange range2 = new CircularGaugeRange();
            range2.Start = 0;
            range2.End = 11;
            range2.Radius = "85%";
            range2.Color = "#3bceac";
            range2.StartWidth = "25";
            range2.EndWidth = "25";
            ranges.Add(range2);

            CircularGaugeRange range3 = new CircularGaugeRange();
            range3.Start = 0;
            range3.End = 10;
            range3.Radius = "55%";
            range3.Color = "#ee4266";
            range3.StartWidth = "25";
            range3.EndWidth = "25";
            ranges.Add(range3);

            ViewBag.Ranges = ranges;


            return View();
        }
    }
}