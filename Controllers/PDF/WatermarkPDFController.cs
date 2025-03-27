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

using Syncfusion.Mvc.Pdf;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Interactive;
using System.Drawing;
using System.IO;
using Syncfusion.Pdf.Parsing;
using System.Web.Hosting;
using Syncfusion.DocIO.DLS;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /ImportAndStamp/

        public ActionResult WatermarkPDF()
        {
            return View();
        }

        [HttpPost]
        public ActionResult WatermarkPDF(string Browser, string Stamptext, string imageWatermark, float transparency, HttpPostedFileBase file, HttpPostedFileBase imageFile)
        {
            PdfLoadedDocument ldoc = null;
            Stream fileStream = GetInputDocument(file);
            if ((imageWatermark == "Watermark" && imageFile != null && imageFile.ContentLength > 0) || imageWatermark == null && !string.IsNullOrEmpty(Stamptext))
            {
                ldoc = new PdfLoadedDocument(fileStream);

                PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 36f);

                foreach (PdfPageBase lPage in ldoc.Pages)
                {
                    SizeF pageSize = lPage.Size;
                    if (!string.IsNullOrEmpty(Stamptext))
                    {
                        var textSize = font.MeasureString(Stamptext);
                        while (textSize.Width > 600)
                        {
                            font = new PdfStandardFont(PdfFontFamily.Helvetica, font.Size - 1);
                            textSize = font.MeasureString(Stamptext);
                        }
                        PdfGraphics graphics = lPage.Graphics;
                        PdfGraphicsState state = graphics.Save();
                        graphics.SetTransparency(transparency);
                        graphics.TranslateTransform(pageSize.Width / 2, pageSize.Height / 2);
                        graphics.RotateTransform(-45);
                        graphics.DrawString(Stamptext, font, PdfBrushes.Red, new RectangleF(-(textSize.Width / 2), -(textSize.Height / 2), pageSize.Width, pageSize.Height));
                        graphics.Restore(state);
                    }

                    if (imageWatermark == "Watermark")
                    {
                        PdfGraphics graphics = lPage.Graphics;
                        graphics.Save();
                        PdfImage image = new PdfBitmap(imageFile.InputStream);
                        graphics.SetTransparency(transparency);
                        graphics.DrawImage(image, 0, 0, lPage.Graphics.ClientSize.Width, lPage.Graphics.ClientSize.Height);
                        graphics.Restore();
                    }
                }
            }
            else
            {
                ViewData["lab"] = "NOTE: Please select a valid image file or enter text to add a watermark.";
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
        private Stream GetInputDocument(HttpPostedFileBase file)
        {

            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName).ToLower();
                if (extension == ".pdf")
                {
                    MemoryStream stream = new MemoryStream();
                    Request.InputStream.CopyTo(stream);
                    return stream;
                }
                else
                {
                    ViewData["Message"] = string.Format("Please choose a valid PDF document to add watermark");
                    return null;
                }
            }
            else
            {
                //Opens an existing document from stream through constructor of `WordDocument` class
                FileStream fileStreamPath = new FileStream(ResolveApplicationDataPath(@"HTTP Succinctly.pdf"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                return fileStreamPath;
            }
        }
    }
}
