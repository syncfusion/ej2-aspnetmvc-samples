#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
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
using System.Drawing;

using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf;
using Syncfusion.Mvc.Pdf;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        # region Fields
        # endregion
        //
        // GET: /PdfCompression/

        public ActionResult PdfCompression()
        {
            ViewData.Add("compress", new SelectList(new string[] { "None", "BelowNormal",  "BestSpeed", "Normal", "AboveNormal", "Best" }));
            ViewData.Add("img", new SelectList(new string[] { "Minimum", "Low", "Medium", "High", "Maximum" }));
         
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult PdfCompression(string compress, string img, string Browser)
        {
            int quality = GetTargetQuality(img);

            PdfDocument document = new PdfDocument();
            document.Compression = (PdfCompressionLevel)Enum.Parse(typeof(PdfCompressionLevel), compress, true);
            document.PageSettings.Margins.All = 0;

            # region Text and Image content

            // Add a new page to the document.
            pdfPage = document.Pages.Add();

            // Get page size
            SizeF size = pdfPage.GetClientSize();

            PdfLayoutFormat format = new PdfLayoutFormat();
            format.Layout = PdfLayoutType.Paginate;

            PdfBitmap image = PdfImage.FromFile(ResolveApplicationImagePath("page1.png")) as PdfBitmap;
            image.Quality = quality;
            pdfPage.Graphics.DrawImage(image, PointF.Empty, new SizeF(size.Width, image.PhysicalDimension.Height));

            float yPos = image.PhysicalDimension.Height + 100;
            float xPos = size.Width / 4;

            PdfFont headerFont = new PdfTrueTypeFont(new Font("Arial", 18.16f), true);
            PdfFont bodyFont = new PdfTrueTypeFont(new Font("Arial", 10f), true);
            PdfTextElement elem = new PdfTextElement("Essential Studio Enterprise Edition");
            elem.Font = headerFont;
            PdfLayoutResult result = elem.Draw(pdfPage, new PointF(xPos, yPos), size.Width / 2, format);
            yPos = result.Bounds.Bottom + 10;

            elem = new PdfTextElement("If you need it all, and want to do it all, then Essential Studio Enterprise Edition is all you could want. This comprehensive suite of components and controls is comprised of all the user interface, business intelligence, and reporting tools and libraries that we offer. It’s the one package you need to develop across every platform—WinRT, Mobile MVC, ASP.NET, ASP.NET MVC, WPF, Silverlight, Windows Phone, and Windows Forms.");
            elem.Font = bodyFont;
            elem.Brush = PdfBrushes.Gray;
            elem.StringFormat = new PdfStringFormat();
            elem.StringFormat.LineSpacing = 5;
            result = elem.Draw(pdfPage, new PointF(xPos, yPos), size.Width / 2, format);
            yPos = result.Bounds.Bottom + 25;

            elem = new PdfTextElement("Essential Studio for ASP.NET");
            elem.Font = headerFont;
            result = elem.Draw(pdfPage, new PointF(xPos, yPos), size.Width / 2, format);
            yPos = result.Bounds.Bottom + 10;

            elem = new PdfTextElement("Essential Studio for ASP.NET contains 66 unique controls, everything you need to build line-of-business web applications—including grids, charts, gauges, menus, calendars, editors, and much more. It also comes with high-performance libraries that enable your applications to read and write Excel, Word, and PDF documents.");
            elem.Font = bodyFont;
            elem.Brush = PdfBrushes.Gray;
            elem.StringFormat = new PdfStringFormat();
            elem.StringFormat.LineSpacing = 5;
            result = elem.Draw(pdfPage, new PointF(xPos, yPos), size.Width / 2, format);
            yPos = result.Bounds.Bottom + 25;

            elem = new PdfTextElement("Essential Studio for ASP.NET MVC");
            elem.Font = headerFont;
            result = elem.Draw(pdfPage, new PointF(xPos, yPos), size.Width / 2, format);
            yPos = result.Bounds.Bottom + 10;

            elem = new PdfTextElement("Our very first natively written MVC control suite contains 50 unique controls essential for assembling enterprise-grade web applications—including grids, charts, gauges, menus, calendars, editors, and much more. It comes with high-performance libraries that enable your applications to read and write Excel, Word, and PDF documents. You will also find several one-of-a-kind MVC controls like OlapClient, PDF Viewer, and Report Viewer.");
            elem.Font = bodyFont;
            elem.Brush = PdfBrushes.Gray;
            elem.StringFormat = new PdfStringFormat();
            elem.StringFormat.LineSpacing = 5;
            result = elem.Draw(pdfPage, new PointF(xPos, yPos), size.Width / 2, format);

            pdfPage = document.Pages.Add();
            PdfBitmap tiff1 = PdfImage.FromFile(ResolveApplicationImagePath("page2.tif")) as PdfBitmap;
            tiff1.Quality = quality;
            tiff1.Encoding = EncodingType.JBIG2;
            pdfPage.Graphics.DrawImage(
                tiff1, PointF.Empty);

            pdfPage = document.Pages.Add();
            PdfBitmap tiff2 = PdfImage.FromFile(ResolveApplicationImagePath("page3.tif")) as PdfBitmap;
            tiff2.Quality = quality;
            tiff2.Encoding = EncodingType.JBIG2;
            pdfPage.Graphics.DrawImage(tiff2, PointF.Empty);

            # endregion

            # region Footer
            PdfBitmap fooImage = PdfImage.FromFile(ResolveApplicationImagePath("footer.png")) as PdfBitmap;
            fooImage.Quality = quality;
            PdfPageTemplateElement footer = new PdfPageTemplateElement(pdfPage.Graphics.ClientSize.Width, fooImage.PhysicalDimension.Height);
            footer.Graphics.DrawImage(fooImage, new PointF(0, 0));
            document.Template.Bottom = footer;
            # endregion

            //Save to disk
            //Stream the output to the browser.    
            if (Browser == "Browser")
                return document.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            else
                return document.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
        }

        # region Helpher methods
        private int GetTargetQuality(string p)
        {
            int quality = 100;

            switch (p)
            {
                case "Minimum":
                    quality = 20;
                    break;

                case "Low":
                    quality = 40;
                    break;

                case "Medium":
                    quality = 60;
                    break;

                case "High":
                    quality = 80;
                    break;

                case "Maximum":
                default:
                    quality = 100;
                    break;
            }

            return quality;
        }
        #endregion

    }
}
