using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        // GET: /PdfConformance/

        public ActionResult PdfConformance()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult PdfConformance(string Browser)
        {
            //Create a new document with PDF/A standard.
            PdfDocument doc = new PdfDocument(PdfConformanceLevel.Pdf_A1B);

            //Add a page
            PdfPage page = doc.Pages.Add();

            //Create Pdf graphics for the page
            PdfGraphics g = page.Graphics;

            SizeF bounds = page.GetClientSize();

            //Read the RTF document
            StreamReader reader = new StreamReader(ResolveApplicationDataPath("PDF_A.rtf"), System.Text.Encoding.ASCII);
            string text = reader.ReadToEnd();
            reader.Close();

            //Convert it as metafile.
            PdfMetafile metafile = (PdfMetafile)PdfImage.FromRtf(text, bounds.Width, PdfImageType.Metafile);
            PdfMetafileLayoutFormat format = new PdfMetafileLayoutFormat();

            //Allow the text to flow multiple pages without any breaks.
            format.SplitTextLines = true;

            //Draw the image.
            metafile.Draw(page, 0, 0, format);


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
