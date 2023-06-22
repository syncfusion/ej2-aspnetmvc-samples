#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Web.Mvc;
using Syncfusion.Mvc.Pdf;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.Drawing;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /HelloWorld/     

        public ActionResult HelloWorld()
        {
            return View();
        }
        [HttpPost]
        public ActionResult HelloWorld(string Browser)
        {
            document = new PdfDocument();
            //Add a page
            PdfPage page = document.Pages.Add();

            //Create Pdf graphics for the page
            PdfGraphics g = page.Graphics;

            //Create a solid brush
            PdfBrush brush = new PdfSolidBrush(System.Drawing.Color.Black);

            //Set the font
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 36);

            //Draw the text
            g.DrawString("Hello world!", font, brush, new PointF(20, 20));

            //Stream the output to the browser.    
            if (Browser == "Browser")
            {
                return document.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            }
            else
            {
                return document.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }
        }

    }
}
