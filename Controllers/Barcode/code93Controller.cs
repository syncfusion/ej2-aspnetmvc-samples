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
        
        public ActionResult Code93()
        {
            List<ExpandOptionsCode93> position = new List<ExpandOptionsCode93>();
            position.Add(new ExpandOptionsCode93() { text = "Bottom", value = "bottom" });
            position.Add(new ExpandOptionsCode93() { text = "Top", value = "top" });

            ViewBag.position = position;

            List<ExpandOptionsCode93> alignment = new List<ExpandOptionsCode93>();
            alignment.Add(new ExpandOptionsCode93() { text = "Center", value = "Center" });
            alignment.Add(new ExpandOptionsCode93() { text = "Left", value = "Left" });
            alignment.Add(new ExpandOptionsCode93() { text = "Right", value = "Right" });

            ViewBag.alignment = alignment;
            ViewBag.expandValue = "Bottom";
           
            
            return View();
        }
    }

    public class ExpandOptionsCode93
    {
        public string text;
        public string value;
    }
    
}