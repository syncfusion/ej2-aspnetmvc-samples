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
using Syncfusion.DocIO.DLS;
using Syncfusion.DocToPDFConverter;
namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /RTFtoPDF/

        public ActionResult RTFtoPDF()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult RTFtoPDF(string InsideBrowser)
        {
            string text = ResolveApplicationDataPath("Essential PDF.rtf");
            WordDocument wordDoc = new WordDocument(text);
            DocToPDFConverter converter = new DocToPDFConverter();
            //Convert word document into PDF document
            PdfDocument pdfDoc = converter.ConvertToPDF(wordDoc);
            wordDoc.Close();
            converter.Dispose();
            //Stream the output to the browser.    
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
