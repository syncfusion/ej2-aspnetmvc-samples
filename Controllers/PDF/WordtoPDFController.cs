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
        // GET: /WordtoPDF/

        public ActionResult WordtoPDF()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult WordtoPDF(string InsideBrowser)
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
