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
        // GET: Legend
        public ActionResult Legend()
        {
            List<CircularGaugePointer> pointers = new List<CircularGaugePointer>();
            CircularGaugePointer pointer1 = new CircularGaugePointer();
            pointer1.Value = 70;
            pointer1.Radius = "60%";
            pointer1.PointerWidth = 8;
            pointer1.Color = "#757575";
            pointer1.Cap = new CircularGaugeCap
            {
                Radius = 7,
                Color = "#757575"
            };
            pointer1.NeedleTail = new CircularGaugeNeedleTail
            {
                Length = "18%"
            };
            pointers.Add(pointer1);
            ViewBag.Pointers = pointers;

            // Ranges //
            List<CircularGaugeRange> ranges = new List<CircularGaugeRange>();
            CircularGaugeRange range1 = new CircularGaugeRange();
            range1.Start = 0;
            range1.End = 5;
            range1.Color = "#ccffff";
            range1.Radius = "110%";
            range1.LegendText = "Light air";
            ranges.Add(range1);

            CircularGaugeRange range2 = new CircularGaugeRange();
            range2.Start = 5;
            range2.End = 11;
            range2.Color = "#99ffff";
            range2.Radius = "110%";
            range2.LegendText = "Light breeze";
            ranges.Add(range2);

            CircularGaugeRange range3 = new CircularGaugeRange();
            range3.Start = 11;
            range3.End = 19;
            range3.Color = "#99ff99";
            range3.Radius = "110%";
            range3.LegendText = "Gentle breeze";
            ranges.Add(range3);

            CircularGaugeRange range4 = new CircularGaugeRange();
            range4.Start = 19;
            range4.End = 28;
            range4.Color = "#79ff4d";
            range4.Radius = "110%";
            range4.LegendText = "Moderate breeze";
            ranges.Add(range4);

            CircularGaugeRange range5 = new CircularGaugeRange();
            range5.Start = 28;
            range5.End = 49;
            range5.Color = "#c6ff1a";
            range5.Radius = "110%";
            range5.LegendText = "Strong breeze";
            ranges.Add(range5);

            CircularGaugeRange range6 = new CircularGaugeRange();
            range6.Start = 49;
            range6.End = 74;
            range6.Color = "#e6ac00";
            range6.Radius = "110%";
            range6.LegendText = "Gale";
            ranges.Add(range6);

            CircularGaugeRange range7 = new CircularGaugeRange();
            range7.Start = 74;
            range7.End = 102;
            range7.Color = "#ff6600";
            range7.Radius = "110%";
            range7.LegendText = "Storm";
            ranges.Add(range7);

            CircularGaugeRange range8 = new CircularGaugeRange();
            range8.Start = 102;
            range8.End = 120;
            range8.Color = "#ff0000";
            range8.Radius = "110%";
            range8.LegendText = "Hurricane force";
            ranges.Add(range8);
            ViewBag.Ranges = ranges;

            return View();
        }
    }
}