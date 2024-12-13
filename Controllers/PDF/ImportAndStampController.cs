#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
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

using Syncfusion.Mvc.Pdf;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Interactive;
using System.Drawing;
using System.IO;
using Syncfusion.Pdf.Parsing;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /ImportAndStamp/

        public ActionResult ImportAndStamp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ImportAndStamp(string Browser, string Stamptext, HttpPostedFileBase file)
        {
            PdfLoadedDocument ldoc = null;
            if (file != null && file.ContentLength > 0)
            {
                ldoc = new PdfLoadedDocument(file.InputStream);

                PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 36f);

                foreach (PdfPageBase lPage in ldoc.Pages)
                {
                    PdfGraphics graphics = lPage.Graphics;
                    PdfGraphicsState state = graphics.Save();
                    graphics.SetTransparency(0.25f);
                    graphics.RotateTransform(-40);
                    graphics.DrawString(Stamptext, font, PdfPens.Red, PdfBrushes.Red, new PointF(-150, 450));
                    graphics.Restore(state);
                }
            }
            else 
            {
                ViewBag.lab = "NOTE: Please select PDF document.";
                return View();
            }
            //Stream the output to the browser.    
            if (Browser == "Browser")
            {

                return ldoc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            }
            else
            {
                return ldoc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }
        }
    }
}
