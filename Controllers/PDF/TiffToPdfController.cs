#region Copyright Syncfusion Inc. 2001 - 2022
// Copyright Syncfusion Inc. 2001 - 2022. All rights reserved.
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

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /TiffToPdf/

        public ActionResult TiffToPdf()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult TiffToPdf(string Browser)
        {
            //Create a PDF document
            doc = new PdfDocument();

            //Add a section to the PDF document
            PdfSection section = doc.Sections.Add();

            //Declare the PDF page
            PdfPage page;

            //Declare PDF page graphics
            PdfGraphics graphics;

            //Load Multiframe Tiff image
            PdfBitmap tiffImage = new PdfBitmap(ResolveApplicationImagePath("image.tiff"));

            //Get the frame count
            int frameCount = tiffImage.FrameCount;

            //Access each frame draw into the page
            for (int i = 0; i < frameCount; i++)
            {

                page = section.Pages.Add();

                section.PageSettings.Margins.All = 0;

                graphics = page.Graphics;

                tiffImage.ActiveFrame = i;

                graphics.DrawImage(tiffImage, 0, 0, page.GetClientSize().Width, page.GetClientSize().Height);

            }          

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
