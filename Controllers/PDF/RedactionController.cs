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
        public ActionResult Redaction(string Browser, string x, string y, string width, string height, HttpPostedFileBase file)
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
            return View();
        }
    }
}
