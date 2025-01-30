#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
        public ActionResult ImageToPdf(string InsideBrowser, string pageSize, string pageOrientation, string margin, HttpPostedFileBase imageFile)
        {

            if (imageFile != null && Request.Files.Count != 0)
            {
                //Create a new PDF document
                PdfDocument document = new PdfDocument();

                for (int i = 0; i < Request.Files.Count; i++)
                {
                    if (Request.Files[i].ContentType.Contains("image/"))
                    {
                        //Load the image from the file
                        MemoryStream imageStream = new MemoryStream();
                        Request.Files[i].InputStream.CopyTo(imageStream);

                        PdfBitmap image = new PdfBitmap(imageStream);

                        PdfSection section = document.Sections.Add();

                        SizeF pageSizeF = GetPdfPageSize(pageSize);

                        //Set the page size
                        section.PageSettings.Size = pageSizeF == SizeF.Empty ? image.PhysicalDimension : pageSizeF;

                        if (pageOrientation != "Default")
                        {
                            //Set the page orientation
                            section.PageSettings.Orientation = pageOrientation == "Portrait"
                                ? PdfPageOrientation.Portrait
                                : PdfPageOrientation.Landscape;
                        }

                        //Set the page margins
                        section.PageSettings.Margins.All = GetPdfMargin(margin);

                        //Create a new PDF page
                        PdfPage page = section.Pages.Add();

                        //Draw the image on the PDF page
                        page.Graphics.DrawImage(image, 0, 0, page.GetClientSize().Width, page.GetClientSize().Height);

                        //Close the image stream
                        imageStream.Dispose();
                    }
                }

                //Stream the output to the browser.    
                if (InsideBrowser == "Browser")
                {
                    return document.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
                }
                else
                {
                    return document.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
                }
            }
            else
            {
                ViewBag.lab = "NOTE: Please select a image file to convert.";
                return View();
            }
        }
        private SizeF GetPdfPageSize(string pageSize)
        {
            switch (pageSize)
            {
                case "A4":
                    return PdfPageSize.A4;
                case "Letter":
                    return PdfPageSize.Letter;
                default:
                    return SizeF.Empty;
            }
        }
        private float GetPdfMargin(string margin)
        {
            switch (margin)
            {
                case "Small":
                    return 20;
                case "Large":
                    return 40;
                default:
                    return 0;
            }
        }
    }
}
