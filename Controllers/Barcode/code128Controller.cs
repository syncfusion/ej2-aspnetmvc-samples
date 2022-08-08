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
        
        public ActionResult Code128()
        {
            List<ExpandOptionsCode128> position = new List<ExpandOptionsCode128>();
            position.Add(new ExpandOptionsCode128() { text = "Bottom", value = "bottom" });
            position.Add(new ExpandOptionsCode128() { text = "Top", value = "top" });

            ViewBag.position = position;

            List<ExpandOptionsCode128> alignment = new List<ExpandOptionsCode128>();
            alignment.Add(new ExpandOptionsCode128() { text = "Center", value = "Center" });
            alignment.Add(new ExpandOptionsCode128() { text = "Left", value = "Left" });
            alignment.Add(new ExpandOptionsCode128() { text = "Right", value = "Right" });

            ViewBag.alignment = alignment;
            ViewBag.expandValue = "Bottom";
           
            
            return View();
        }
    }

    public class ExpandOptionsCode128
    {
        public string text;
        public string value;
    }
    
}