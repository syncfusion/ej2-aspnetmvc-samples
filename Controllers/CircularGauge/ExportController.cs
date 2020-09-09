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
        // GET: Default
        public ActionResult Export()
        {
           
            // Ranges //
            List<CircularGaugeRange> ranges = new List<CircularGaugeRange>();
            CircularGaugeRange range1 = new CircularGaugeRange();
            range1.Start = 0;
            range1.End = 32;
            range1.Radius = "90%";
            range1.StartWidth = "10";
            range1.EndWidth = "35";
            range1.Color = "#F8A197";
            ranges.Add(range1);

            CircularGaugeRange range2 = new CircularGaugeRange();
            range2.Start = 32;
            range2.End = 70;
            range2.Radius = "90%";
            range2.StartWidth = "10";
            range2.EndWidth = "35";
            range2.Color = "#C45072";
            ranges.Add(range2);

            CircularGaugeRange range3 = new CircularGaugeRange();
            range3.Start = 70;
            range3.End = 100;
            range3.Radius = "90%";
            range3.StartWidth = "10";
            range3.EndWidth = "35";
            range3.Color = "#1B679F";
            ranges.Add(range3);
            ViewBag.Ranges = ranges;


            List<CircularGaugePointer> pointers = new List<CircularGaugePointer>();
            ViewBag.Pointers = pointers;

           ViewBag.labelFont = new CircularGaugeFont
            {
                FontFamily = "Roboto",
                Size = "12px",
                Opacity = 1,
                FontWeight = "Regular"
            };
           

            ViewBag.format = new string[] { "JPEG", "PNG", "SVG", "PDF" };
            return View();
        }
    }
}