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
        // GET: /PdfToPdfAConverter/

        public ActionResult PdfToPdfAConverter()
        {
            ViewData.Add("conformance", new SelectList(new string[] { "PDF/A-1b", "PDF/A-2b", "PDF/A-3b", "PDF/A-4" }));
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult PdfToPdfAConverter(string Browser, string conformance, HttpPostedFileBase file = null)
        {
            if (file != null && file.ContentLength > 0)
            {
                //Load an existing PDF.
                PdfLoadedDocument doc = new PdfLoadedDocument(file.InputStream);

                if (conformance == "PDF/A-1b")
                {
                    //Create a new document with PDF/A standard.
                    doc.Conformance = PdfConformanceLevel.Pdf_A1B;
                }
                else if (conformance == "PDF/A-2b")
                {
                    //Create a new document with PDF/A standard.
                    doc.Conformance = PdfConformanceLevel.Pdf_A2B;
                }
                else if (conformance == "PDF/A-3b")
                {
                    //Create a new document with PDF/A standard.
                    doc.Conformance = PdfConformanceLevel.Pdf_A3B;
                }
                else if (conformance == "PDF/A-4")
                {
                    //Create a new document with PDF/A standard.
                    doc.Conformance = PdfConformanceLevel.Pdf_A4;
                }

                string[] fileName = file.FileName.Split(new string[] { ".pdf" }, StringSplitOptions.RemoveEmptyEntries);

                //Stream the output to the browser.    
                if (Browser == "Browser")
                {
                    return doc.ExportAsActionResult(fileName[0] + "_A.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
                }
                else
                {
                    return doc.ExportAsActionResult(fileName[0] + "_A.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
                }
            }
            else
            {
                ViewBag.lab = "Choose a valid PDF file.";
                ViewData.Add("conformance", new SelectList(new string[] { "PDF/A-1b", "PDF/A-2b", "PDF/A-3b", "PDF/A-4" }));
                return View();
            }

        }

    }
}
