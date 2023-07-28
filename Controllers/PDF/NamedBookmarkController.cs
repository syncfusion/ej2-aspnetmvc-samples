#region Copyright Syncfusion Inc. 2001-2016.
// Copyright Syncfusion Inc. 2001-2016. All rights reserved.
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
using Syncfusion.Pdf.Tables;
using System.Data;
using System.Drawing;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /NamedBookmark/
        public ActionResult NamedBookmark()
        {
            return View();
        }
        # region Fields
        PdfDocument doc = new PdfDocument();
        PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 10f);
        PdfBrush brush = new PdfSolidBrush(Color.Black);
        #endregion

        # region Methods
        public PdfBookmark AddBookmark(PdfPage page, string title, PointF point, bool isnamaedDestination)
        {
            PdfBookmark bookMarks = doc.Bookmarks.Add(title);
            PdfGraphics graphics = page.Graphics;
            graphics.DrawString(title, font, brush, new PointF(point.X, point.Y));
            if (isnamaedDestination == true)
            {
                PdfNamedDestination namedDestination = new PdfNamedDestination(title);
                namedDestination.Destination = new PdfDestination(page, new PointF(point.X, point.Y));
                namedDestination.Destination.Mode = PdfDestinationMode.FitToPage;
                doc.NamedDestinationCollection.Add(namedDestination);
                bookMarks.NamedDestination = namedDestination;
            }
            else
            {
                bookMarks.Destination = new PdfDestination(page, new PointF(point.X, point.Y));
                bookMarks.Destination.Mode = PdfDestinationMode.FitToPage;
            }

            return bookMarks;
        }

        public PdfBookmark AddSection(PdfBookmark bookmark, PdfPage page, string title, PointF point, bool isnamaedDestination)
        {
            PdfBookmark bookMarks = bookmark.Add(title);
            PdfGraphics graphics = page.Graphics;
            graphics.DrawString(title, font, brush, new PointF(point.X, point.Y));
            if (isnamaedDestination == true)
            {
                PdfNamedDestination namedDestination = new PdfNamedDestination(title);
                namedDestination.Destination = new PdfDestination(page, new PointF(point.X, point.Y));
                namedDestination.Destination.Zoom = 1f;
                doc.NamedDestinationCollection.Add(namedDestination);
                bookMarks.NamedDestination = namedDestination;
            }
            else
            {
                bookMarks.Destination = new PdfDestination(page, new PointF(point.X, point.Y));
                bookMarks.Destination.Zoom = 1f;
            }
            return bookMarks;
        }

        public PdfBookmark AddSubSection(PdfBookmark bookmark, PdfPage page, string title, PointF point, bool isnamaedDestination)
        {
            PdfBookmark bookMarks = bookmark.Add(title);
            PdfGraphics graphics = page.Graphics;
            graphics.DrawString(title, font, brush, new PointF(point.X, point.Y));
            if (isnamaedDestination == true)
            {
                PdfNamedDestination namedDestination = new PdfNamedDestination(title);
                namedDestination.Destination = new PdfDestination(page, new PointF(point.X, point.Y));
                namedDestination.Destination.Zoom = 2f;
                doc.NamedDestinationCollection.Add(namedDestination);
                bookMarks.NamedDestination = namedDestination;
            }
            else
            {
                bookMarks.Destination = new PdfDestination(page, new PointF(point.X, point.Y));
                bookMarks.Destination.Zoom = 2f;
            }
            return bookMarks;
        }
        #endregion

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult NamedBookmark(string InsideBrowser)
        {
            # region Body
            for (int i = 1; i <= 6; i++)
            {
                PdfPage pages = doc.Pages.Add();
                PdfBookmark bookmark = AddBookmark(pages, "Chapter " + i, new PointF(10, 10), true);
                PdfBookmark section1 = AddSection(bookmark, pages, "Section " + i + ".1", new PointF(30, 30), true);
                PdfBookmark section2 = AddSection(bookmark, pages, "Section " + i + ".2", new PointF(30, 400), false);
                PdfBookmark subsection1 = AddSubSection(section1, pages, "Paragraph " + i + ".1.1", new PointF(50, 50), true);
                PdfBookmark subsection2 = AddSubSection(section1, pages, "Paragraph " + i + ".1.2", new PointF(50, 150), true);
                PdfBookmark subsection3 = AddSubSection(section1, pages, "Paragraph " + i + ".1.3", new PointF(50, 250), true);
                PdfBookmark subsection4 = AddSubSection(section2, pages, "Paragraph " + i + ".2.1", new PointF(50, 420), false);
                PdfBookmark subsection5 = AddSubSection(section2, pages, "Paragraph " + i + ".2.2", new PointF(50, 560), false);
                PdfBookmark subsection6 = AddSubSection(section2, pages, "Paragraph " + i + ".2.3", new PointF(50, 680), false);
            }
            #endregion
            //Stream the output to the browser.    
            if (InsideBrowser == "Browser")
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
