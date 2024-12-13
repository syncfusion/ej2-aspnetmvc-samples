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
        public ActionResult NamedDestination()
        {
            return View();
        }

        #region Fields
        //PdfDocument doc = null;
        //PdfFont font = null;
        //PdfBrush brush = null;
        #endregion

        # region Methods
        public PdfBookmark AddBookmark(PdfPage page, string title, PointF point)
        {
            PdfGraphics graphics = page.Graphics;
            //Add bookmark in PDF document
            PdfBookmark bookmarks = document.Bookmarks.Add(title);

            //Draw the content in the PDF page
            graphics.DrawString(title, font, brush, new PointF(point.X, point.Y));

            //Adding bookmark with named destination
            PdfNamedDestination namedDestination = new PdfNamedDestination(title);
            namedDestination.Destination = new PdfDestination(page, new PointF(point.X, point.Y));
            namedDestination.Destination.Mode = PdfDestinationMode.FitToPage;
            document.NamedDestinationCollection.Add(namedDestination);
            bookmarks.NamedDestination = namedDestination;

            return bookmarks;
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
                document.NamedDestinationCollection.Add(namedDestination);
                bookMarks.NamedDestination = namedDestination;
            }
            else
            {
                bookMarks.Destination = new PdfDestination(page, new PointF(point.X, point.Y));
                bookMarks.Destination.Zoom = 1f;
            }
            return bookMarks;
        }
        #endregion

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult NamedDestination(string InsideBrowser)
        {
            document = new PdfDocument();
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 10f);
            brush = new PdfSolidBrush(Color.Black);

            for (int i = 1; i <= 6; i++)
            {
                PdfPage pages = document.Pages.Add();
                //Add bookmark in PDF document
                PdfBookmark bookmark = AddBookmark(pages, "Chapter " + i, new PointF(10, 10));
                //Add sections to bookmark
                PdfBookmark section1 = AddSection(bookmark, pages, "Section " + i + ".1", new PointF(30, 30), false);
                PdfBookmark section2 = AddSection(bookmark, pages, "Section " + i + ".2", new PointF(30, 400), false);
                //Add subsections to section
                PdfBookmark subsection1 = AddSection(section1, pages, "Paragraph " + i + ".1.1", new PointF(50, 50), true);
                PdfBookmark subsection2 = AddSection(section1, pages, "Paragraph " + i + ".1.2", new PointF(50, 150), true);
                PdfBookmark subsection3 = AddSection(section1, pages, "Paragraph " + i + ".1.3", new PointF(50, 250), true);
                PdfBookmark subsection4 = AddSection(section2, pages, "Paragraph " + i + ".2.1", new PointF(50, 420), true);
                PdfBookmark subsection5 = AddSection(section2, pages, "Paragraph " + i + ".2.2", new PointF(50, 560), true);
                PdfBookmark subsection6 = AddSection(section2, pages, "Paragraph " + i + ".2.3", new PointF(50, 680), true);
            }

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
