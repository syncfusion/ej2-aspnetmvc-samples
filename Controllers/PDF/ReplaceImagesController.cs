#region Copyright Syncfusion Inc. 2001 - 2023
// Copyright Syncfusion Inc. 2001 - 2023. All rights reserved.
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
        // GET: /ReplaceImages/

        public ActionResult ReplaceImages()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ReplaceImages(string Browser, string submit1)
        {
            if (submit1 == "View Template")
            {
                string dataPath = ResolveApplicationDataPath("imageDoc.pdf");
                Stream file2 = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                //Load the template document
                PdfLoadedDocument ldoc = new PdfLoadedDocument(file2);
                return ldoc.ExportAsActionResult("InputTemplate.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            }

            //Load the PDF document
            PdfLoadedDocument doc = new PdfLoadedDocument(ResolveApplicationDataPath("imageDoc.pdf"));

            //Create an image instance
            PdfBitmap bmp = new PdfBitmap(ResolveApplicationImagePath("Essen PDF.gif"));

            //Replace the first image in the page.
            doc.Pages[0].ReplaceImage(2, bmp);

            bmp = new PdfBitmap(ResolveApplicationImagePath("Essen DocIO.gif"));
            doc.Pages[1].ReplaceImage(0, bmp);

            bmp = new PdfBitmap(ResolveApplicationImagePath("Essen XlsIO.gif"));
            doc.Pages[1].ReplaceImage(1, bmp);

            //Stream the output to the browser.    
            if (Browser == "Browser")
            {
                return doc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            }
            else
            {
                return doc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }
        }

    }
}
