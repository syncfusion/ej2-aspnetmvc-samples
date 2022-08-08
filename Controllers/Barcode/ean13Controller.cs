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
        
        public ActionResult Ean13()
        {
            List<ExpandOptionsEan13> position = new List<ExpandOptionsEan13>();
            position.Add(new ExpandOptionsEan13() { text = "Bottom", value = "bottom" });
            position.Add(new ExpandOptionsEan13() { text = "Top", value = "top" });

            ViewBag.position = position;

            List<ExpandOptionsEan13> alignment = new List<ExpandOptionsEan13>();
            alignment.Add(new ExpandOptionsEan13() { text = "Center", value = "Center" });
            alignment.Add(new ExpandOptionsEan13() { text = "Left", value = "Left" });
            alignment.Add(new ExpandOptionsEan13() { text = "Right", value = "Right" });

            ViewBag.alignment = alignment;
            ViewBag.expandValue = "Bottom";
           
            
            return View();
        }
    }

    public class ExpandOptionsEan13
    {
        public string text;
        public string value;
    }
    
}