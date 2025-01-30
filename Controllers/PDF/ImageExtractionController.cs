#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
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
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

using Syncfusion.Mvc.Pdf;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Interactive;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Drawing;


namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /ImageExtraction/

        public ActionResult ImageExtraction()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ImageExtraction(string Browser, string submit1)
        {
            if (submit1 == "View Template")
            {
                string dataPath = ResolveApplicationDataPath("Brochure.pdf");
                Stream file2 = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                //Load the template document
                PdfLoadedDocument ldoc = new PdfLoadedDocument(file2);
                return ldoc.ExportAsActionResult("InputTemplate.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            }

            //Load an existing PDF.
            PdfLoadedDocument loadedDocument = new PdfLoadedDocument(ResolveApplicationDataPath("Brochure.pdf"));

            //Load first page.
            PdfPageBase pageBase = loadedDocument.Pages[0];

            //Extract images from first page.            
            System.Drawing.Image[] extractedImages = pageBase.ExtractImages();

            //Stream the output to the browser.    
            if (Browser == "Browser")
            {
                ExportAsImage(extractedImages[0], "sample.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg, HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            }
            else
            {
                ExportAsImage(extractedImages[0], "sample.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg, HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }
            return View();     
        }     

    }
}
