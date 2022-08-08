using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.BarcodeGenerator;

namespace EJ2CoreSampleBrowser.Controllers.Barcode
{
    public partial class BarcodeController : Controller
    {
        
        public ActionResult Codabar()
        {
            List<ExpandOptionsCodabar> position = new List<ExpandOptionsCodabar>();
            position.Add(new ExpandOptionsCodabar() { text = "Bottom", value = "bottom" });
            position.Add(new ExpandOptionsCodabar() { text = "Top", value = "top" });

            ViewBag.position = position;

            List<ExpandOptionsCodabar> alignment = new List<ExpandOptionsCodabar>();
            alignment.Add(new ExpandOptionsCodabar() { text = "Center", value = "Center" });
            alignment.Add(new ExpandOptionsCodabar() { text = "Left", value = "Left" });
            alignment.Add(new ExpandOptionsCodabar() { text = "Right", value = "Right" });

            ViewBag.alignment = alignment;
            ViewBag.expandValue = "Bottom";
           
            
            return View();
        }
    }

    public class ExpandOptionsCodabar
    {
        public string text;
        public string value;
    }
    
}