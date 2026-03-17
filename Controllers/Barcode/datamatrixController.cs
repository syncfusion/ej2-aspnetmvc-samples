#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
        
        public ActionResult datamatrix()
        {
            List<ExpandOptionsdatamatrix> encoding = new List<ExpandOptionsdatamatrix>();
            encoding.Add(new ExpandOptionsdatamatrix() { text = "Auto", value = "Auto" });
            encoding.Add(new ExpandOptionsdatamatrix() { text = "ASCII", value = "ASCII" });
            encoding.Add(new ExpandOptionsdatamatrix() { text = "ASCIINumeric", value = "ASCIINumeric" });
            encoding.Add(new ExpandOptionsdatamatrix() { text = "Base256", value = "Base256" });

            ViewData["encoding"] = encoding;


            List<ExpandOptionsdatamatrix> size = new List<ExpandOptionsdatamatrix>();
            size.Add(new ExpandOptionsdatamatrix() { text = "Size22x22", value = "7" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size24x24", value = "8" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size26x26", value = "9" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size32x32", value = "10" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size36x36", value = "11" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size40x40", value = "12" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size44x44", value = "13" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size48x48", value = "14" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size52x52", value = "15" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size64x64", value = "16" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size72x72", value = "17" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size80x80", value = "18" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size88x88", value = "19" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size96x96", value = "20" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size104x104", value = "21" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size120x120", value = "22" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size132x132", value = "23" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size144x144", value = "24" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Auto", value = "0" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size10x10", value = "1" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size12x12", value = "2" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size14x14", value = "3" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size16x16", value = "4" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size18x18", value = "5" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size20x20", value = "6" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size8x18", value = "25" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size8x32", value = "26" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size12x26", value = "27" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size12x36", value = "28" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size16x36", value = "29" });
            size.Add(new ExpandOptionsdatamatrix() { text = "Size16x48", value = "30" });

            ViewData["size"] = size;





            return View();
        }
    }

    public class ExpandOptionsdatamatrix
    {
        public string text;
        public string value;
    }
    
}