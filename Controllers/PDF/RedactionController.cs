#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
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
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Redaction;
using System.Drawing;
using System.IO;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /Redaction/

        public ActionResult Redaction()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Redaction(string viewTemplate, string RedactPdf, string Browser, string x, string y, string width, string height, HttpPostedFileBase file)
        {
            if (viewTemplate == "View Template")
            {
                string dataPath = ResolveApplicationDataPath("Redaction.pdf");
                Stream file2 = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                //Load the template document
                PdfLoadedDocument doc = new PdfLoadedDocument(file2);
                return doc.ExportAsActionResult("RedactionTemplate.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            }
            else if (RedactPdf == "Redact PDF")
            {
                string dataPath = ResolveApplicationDataPath("Redaction.pdf");
                Stream file2 = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                //Load the template document
                PdfLoadedDocument doc = new PdfLoadedDocument(file2);

                PdfLoadedPage lpage = doc.Pages[0] as PdfLoadedPage;

                PdfRedaction textRedaction = new PdfRedaction(new RectangleF(86.998f, 39.565f, 62.709f, 20.802f), System.Drawing.Color.Black);
                //Create PDF redaction for the page to redact text 
                PdfRedaction pathRedaction = new PdfRedaction(new RectangleF(83.7744f, 576.066f, 210.0746f, 104.155f), System.Drawing.Color.Black);
                //Create PDF redaction for the page to redact text
                PdfRedaction imageRedation = new PdfRedaction(new RectangleF(327.848f, 63.97198f, 232.179f, 223.429f), System.Drawing.Color.Black);

                lpage.Redactions.Add(textRedaction);
                lpage.Redactions.Add(pathRedaction);
                lpage.Redactions.Add(imageRedation);

                return doc.ExportAsActionResult("Redaction.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }
            else
            {
                if (file != null && file.ContentLength > 0)
                {

                    var fileName = Path.GetFileName(file.FileName);

                    float x1;
                    float y1;
                    float width1;
                    float height1;
                    if (x != null && x.Length > 0 && float.TryParse(x.ToString(), out x1) && y != null && y.Length > 0 && float.TryParse(y.ToString(), out y1) && width != null && width.Length > 0 && float.TryParse(width.ToString(), out width1) && height != null && height.Length > 0 && float.TryParse(height.ToString(), out height1))
                    {
                        //Load a PDF document
                        PdfLoadedDocument ldoc = new PdfLoadedDocument(file.InputStream);
                        //Get first page from document
                        PdfLoadedPage lpage = ldoc.Pages[0] as PdfLoadedPage;

                        //Create PDF redaction for the page
                        PdfRedaction redaction = new PdfRedaction(new RectangleF(x1, y1, width1, height1), Color.Black);

                        //Adds the redaction to loaded page
                        lpage.Redactions.Add(redaction);

                        //Save to disk
                        if (Browser == "Browser")
                        {
                            return ldoc.ExportAsActionResult("Document1.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
                        }
                        else
                        {
                            return ldoc.ExportAsActionResult("Document1.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
                        }
                    }
                    else
                    {
                        ViewBag.lab = "Fill proper redaction bounds to redact";
                    }
                }
                else
                {
                    ViewBag.lab = "Choose PDF document to redact";
                }
            }
            return View();
        }
    }
}
