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
        
        public ActionResult Code39()
        {
            List<ExpandOptionsCode39> position = new List<ExpandOptionsCode39>();
            position.Add(new ExpandOptionsCode39() { text = "Bottom", value = "bottom" });
            position.Add(new ExpandOptionsCode39() { text = "Top", value = "top" });

            ViewBag.position = position;

            List<ExpandOptionsCode39> alignment = new List<ExpandOptionsCode39>();
            alignment.Add(new ExpandOptionsCode39() { text = "Center", value = "Center" });
            alignment.Add(new ExpandOptionsCode39() { text = "Left", value = "Left" });
            alignment.Add(new ExpandOptionsCode39() { text = "Right", value = "Right" });

            ViewBag.alignment = alignment;
            ViewBag.expandValue = "Bottom";
           
            
            return View();
        }
    }

    public class ExpandOptionsCode39
    {
        public string text;
        public string value;
    }
    
}