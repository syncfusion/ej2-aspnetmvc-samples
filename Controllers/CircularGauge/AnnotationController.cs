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
        // GET: Annotation
        public ActionResult Annotation()
        {


            // Ranges //
            List<CircularGaugeRange> ranges = new List<CircularGaugeRange>();
            CircularGaugeRange range1 = new CircularGaugeRange();
            range1.Start = 0;
            range1.End = 3;
            range1.Color = "rgb(128,128,128)";
            ranges.Add(range1);

            CircularGaugeRange range2 = new CircularGaugeRange();
            range2.Start = 3;
            range2.End = 12;
            range2.Color = "rgb(192,192,192)";
            ranges.Add(range2);
            ViewBag.Ranges = ranges;

            // Pointers //
            List<CircularGaugePointer> pointers = new List<CircularGaugePointer>();
            CircularGaugePointer pointer1 = new CircularGaugePointer();
            CircularGaugeBorder border = new CircularGaugeBorder();
            border.Width = 0;
            pointer1.PointerWidth = 5;
            pointer1.Radius = "40%";
            pointer1.Border = new CircularGaugeBorder {Width = 0 };
            pointer1.Cap = new CircularGaugeCap{ Radius = 0, Border = new CircularGaugeBorder { Width = 0} };
            pointer1.NeedleTail = new CircularGaugeNeedleTail{ Length = "0%" };
            pointer1.Animation = new CircularGaugeAnimation{ Enable = false };
            pointers.Add(pointer1);

            CircularGaugePointer pointer2 = new CircularGaugePointer();
            pointer2.Radius = "60%";
            pointer2.PointerWidth = 5;
            pointer2.Border = new CircularGaugeBorder { Width = 0 };
            pointer2.Cap = new CircularGaugeCap { Radius = 0, Border = new CircularGaugeBorder { Width = 0 } };
            pointer2.NeedleTail = new CircularGaugeNeedleTail{ Length = "0%" };
            pointer2.Animation = new CircularGaugeAnimation { Enable = false };
            pointers.Add(pointer2);

            CircularGaugePointer pointer3 = new CircularGaugePointer();
            pointer3.Radius = "70%";
            pointer3.PointerWidth = 1;
            pointer3.Border = new CircularGaugeBorder { Width = 2 };
            pointer3.Cap = new CircularGaugeCap { Radius = 4, Border = new CircularGaugeBorder { Width = 2 } };
            pointer3.NeedleTail = new CircularGaugeNeedleTail { Length = "20%", Border = new CircularGaugeBorder { Width = 2 } };
            pointer3.Animation = new CircularGaugeAnimation { Enable = false, Duration=500 };
            pointers.Add(pointer3);

            ViewBag.Pointers = pointers;
            return View();
        }
    }
}