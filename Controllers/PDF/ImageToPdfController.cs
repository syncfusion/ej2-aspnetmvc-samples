#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
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
using System.Drawing;
using System.IO;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /Pdf/

        public ActionResult ImageToPdf()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ImageToPdf(string InsideBrowser)
        {
            List<Stream> imageStreams = new List<Stream>();
            for (int i = 1; i <= 6; i++)
            {
                FileStream jpgImageStream = new FileStream(ResolveApplicationImagePath("pdf_succinctly_page" + i + ".jpg"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                imageStreams.Add(jpgImageStream);
            }

            //Create ImageToPdfConverter object.
            ImageToPdfConverter imageToPdfConverter = new ImageToPdfConverter();

            //Set the image position.
            imageToPdfConverter.ImagePosition = PdfImagePosition.FitToPageAndMaintainAspectRatio;

            //Convert the images to PDF.
            PdfDocument doc = imageToPdfConverter.Convert(imageStreams);

            //Stream the output to the browser.    
            if (InsideBrowser == "Browser")
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
