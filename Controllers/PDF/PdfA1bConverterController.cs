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

using Syncfusion.Pdf.Parsing;
using Syncfusion.Mvc.Pdf;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.IO;
using System.Drawing;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /PdfA1bConverter/

        public ActionResult PdfA1bConverter()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult PdfA1bConverter(string Browser, HttpPostedFileBase file = null)
        {
            if (file != null && file.ContentLength > 0)
            {
                //Load an existing PDF.
                PdfLoadedDocument doc = new PdfLoadedDocument(file.InputStream);

                //Set the conformance for PDF/A-1b conversion.
                doc.Conformance = PdfConformanceLevel.Pdf_A1B;

                string[] fileName = file.FileName.Split(new string[] { ".pdf" }, StringSplitOptions.RemoveEmptyEntries);

                //Stream the output to the browser.    
                if (Browser == "Browser")
                {
                    return doc.ExportAsActionResult(fileName[0] + "_A1b.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
                }
                else
                {
                    return doc.ExportAsActionResult(fileName[0] + "_A1b.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
                }
            }
            else
            {
                ViewBag.lab = "Choose a valid PDF file.";
                return View();
            }

        }

    }
}
