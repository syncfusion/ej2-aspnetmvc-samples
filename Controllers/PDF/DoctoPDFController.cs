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

using Syncfusion.DocIO;
using Syncfusion.DocToPDFConverter;
using Syncfusion.DocIO.DLS;
using Syncfusion.Mvc.Pdf;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.IO;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /DoctoPDF/

        public ActionResult DoctoPDF()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult DoctoPDF(string InsideBrowser)
        {
            Stream readFile = new FileStream(ResolveApplicationDataPath(@"DoctoPDF.doc"), FileMode.Open, FileAccess.Read, FileShare.Read);
            WordDocument wordDoc = new WordDocument(readFile);
            DocToPDFConverter converter = new DocToPDFConverter();
            //Convert word document into PDF document
            PdfDocument pdfDoc = converter.ConvertToPDF(wordDoc);

            //Save the pdf file            
            if (InsideBrowser == "Browser")
            {
                return pdfDoc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            }
            else
            {
                return pdfDoc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }
        }

    }
}
