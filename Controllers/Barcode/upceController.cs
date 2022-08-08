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
        
        public ActionResult UpcE()
        {
            List<ExpandOptionsUpcE> position = new List<ExpandOptionsUpcE>();
            position.Add(new ExpandOptionsUpcE() { text = "Bottom", value = "bottom" });
            position.Add(new ExpandOptionsUpcE() { text = "Top", value = "top" });

            ViewBag.position = position;

            List<ExpandOptionsUpcE> alignment = new List<ExpandOptionsUpcE>();
            alignment.Add(new ExpandOptionsUpcE() { text = "Center", value = "Center" });
            alignment.Add(new ExpandOptionsUpcE() { text = "Left", value = "Left" });
            alignment.Add(new ExpandOptionsUpcE() { text = "Right", value = "Right" });

            ViewBag.alignment = alignment;
            ViewBag.expandValue = "Bottom";
           
            
            return View();
        }
    }

    public class ExpandOptionsUpcE
    {
        public string text;
        public string value;
    }
    
}