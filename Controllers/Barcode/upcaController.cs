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
        
        public ActionResult UpcA()
        {
            List<ExpandOptionsUpcA> position = new List<ExpandOptionsUpcA>();
            position.Add(new ExpandOptionsUpcA() { text = "Bottom", value = "bottom" });
            position.Add(new ExpandOptionsUpcA() { text = "Top", value = "top" });

            ViewBag.position = position;

            List<ExpandOptionsUpcA> alignment = new List<ExpandOptionsUpcA>();
            alignment.Add(new ExpandOptionsUpcA() { text = "Center", value = "Center" });
            alignment.Add(new ExpandOptionsUpcA() { text = "Left", value = "Left" });
            alignment.Add(new ExpandOptionsUpcA() { text = "Right", value = "Right" });

            ViewBag.alignment = alignment;
            ViewBag.expandValue = "Bottom";
           
            
            return View();
        }
    }

    public class ExpandOptionsUpcA
    {
        public string text;
        public string value;
    }
    
}