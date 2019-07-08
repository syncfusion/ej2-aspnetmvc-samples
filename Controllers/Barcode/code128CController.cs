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
        
        public ActionResult Code128C()
        {
            List<ExpandOptionsCode128C> position = new List<ExpandOptionsCode128C>();
            position.Add(new ExpandOptionsCode128C() { text = "Bottom", value = "bottom" });
            position.Add(new ExpandOptionsCode128C() { text = "Top", value = "top" });

            ViewBag.position = position;

            List<ExpandOptionsCode128C> alignment = new List<ExpandOptionsCode128C>();
            alignment.Add(new ExpandOptionsCode128C() { text = "Center", value = "Center" });
            alignment.Add(new ExpandOptionsCode128C() { text = "Left", value = "Left" });
            alignment.Add(new ExpandOptionsCode128C() { text = "Right", value = "Right" });

            ViewBag.alignment = alignment;
            ViewBag.expandValue = "Bottom";
           
            
            return View();
        }
    }

    public class ExpandOptionsCode128C
    {
        public string text;
        public string value;
    }
  
}