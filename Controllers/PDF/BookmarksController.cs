#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
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
using System.Drawing;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /Bookmarks/

        public ActionResult Bookmarks()
        {
            return View();
        }

        # region Methods
        public PdfBookmark AddBookmark1(PdfPage page, string title, PointF point)
        {

            PdfGraphics graphics = page.Graphics;

            //Add bookmark in PDF document
            PdfBookmark bookmarks = document.Bookmarks.Add(title);

            brush = new PdfSolidBrush(Color.Red);

            //Draw the content in the PDF page
            graphics.DrawString(title, font, brush, new PointF(point.X, point.Y));

            bookmarks.Destination = new PdfDestination(page);
            bookmarks.Destination.Location = point;

            return bookmarks;
        }

        public PdfBookmark AddSection1(PdfBookmark bookmark, PdfPage page, string title, PointF point, bool isSubSection)
        {
            PdfGraphics graphics = page.Graphics;
            //Add bookmark in PDF document
            PdfBookmark bookmarks = bookmark.Add(title);

            brush = new PdfSolidBrush(Color.Green);

            if (bookmark.Title.StartsWith("Section"))
            {
                brush = new PdfSolidBrush(Color.Blue);
            }

            //Draw the content in the PDF page
            graphics.DrawString(title, font, brush, new PointF(point.X, point.Y));

            bookmarks.Destination = new PdfDestination(page);
            bookmarks.Destination.Location = point;

            return bookmarks;
        }
        #endregion


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Bookmarks(string Browser)
        {
            //Creates a new PDF document.
            document = new PdfDocument();

            //Set the Font
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 10f);

            //Set PdfBrush
            brush = new PdfSolidBrush(Color.Black);

            for (int i = 1; i <= 3; i++)
            {
                PdfPage pages = document.Pages.Add();

                //Add bookmark in PDF document
                PdfBookmark bookmark = AddBookmark1(pages, "Chapter " + i, new PointF(10, 10));

                bookmark.Color = Color.Red;

                //Add sections to bookmark
                PdfBookmark section1 = AddSection1(bookmark, pages, "Section " + i + ".1", new PointF(30, 30), false);
                section1.Color = Color.Green;
                PdfBookmark section2 = AddSection1(bookmark, pages, "Section " + i + ".2", new PointF(30, 400), false);
                section2.Color = Color.Green;

                //Add subsections to section
                PdfBookmark subsection1 = AddSection1(section1, pages, "Paragraph " + i + ".1.1", new PointF(50, 50), true);
                subsection1.Color = Color.Blue;
                PdfBookmark subsection2 = AddSection1(section1, pages, "Paragraph " + i + ".1.2", new PointF(50, 150), true);
                subsection2.Color = Color.Blue;
                PdfBookmark subsection3 = AddSection1(section1, pages, "Paragraph " + i + ".1.3", new PointF(50, 250), true);
                subsection3.Color = Color.Blue;
                PdfBookmark subsection4 = AddSection1(section2, pages, "Paragraph " + i + ".2.1", new PointF(50, 420), true);
                subsection4.Color = Color.Blue;
                PdfBookmark subsection5 = AddSection1(section2, pages, "Paragraph " + i + ".2.2", new PointF(50, 560), true);
                subsection5.Color = Color.Blue;
                PdfBookmark subsection6 = AddSection1(section2, pages, "Paragraph " + i + ".2.3", new PointF(50, 680), true);
                subsection6.Color = Color.Blue;
            }

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
