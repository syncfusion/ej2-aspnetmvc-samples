#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
using System.IO;
using System.Drawing;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /RtlSupport/

        public ActionResult RtlSupport()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult RtlSupport(string InsideBrowser)
        {
            //Create a new PDF document
            PdfDocument doc = new PdfDocument();

            //Add a page
            PdfPage page = doc.Pages.Add();

            //Create font
            Font f = new Font("Arial", 14);
            PdfFont font = new PdfTrueTypeFont(f, true);
            string path = ResolveApplicationDataPath("arabic.txt");

            //Read the text from text file
            StreamReader reader = new StreamReader(path, System.Text.Encoding.Unicode);
            string text = reader.ReadToEnd();
            reader.Close();

            //Create a brush
            PdfBrush brush = new PdfSolidBrush(Color.Black);
            PdfPen pen = new PdfPen(Color.Black);
            SizeF clipBounds = page.Graphics.ClientSize;
            RectangleF rect = new RectangleF(0, 0, clipBounds.Width / 2f, clipBounds.Height / 3f);

            //Set the property for RTL text
            PdfStringFormat format = new PdfStringFormat();
            format.RightToLeft = true;
            format.ParagraphIndent = 35f;

            page.Graphics.DrawString(text, font, brush, rect, format);
            page.Graphics.DrawRectangle(pen, rect);

            //Set the alignment
            format.Alignment = PdfTextAlignment.Center;
            rect.Offset(rect.Width, 0);
            page.Graphics.DrawString(text, font, brush, rect, format);
            page.Graphics.DrawRectangle(pen, rect);

            format.Alignment = PdfTextAlignment.Right;
            rect.Offset(-rect.Width, rect.Height);
            page.Graphics.DrawString(text, font, brush, rect, format);
            page.Graphics.DrawRectangle(pen, rect);

            format.Alignment = PdfTextAlignment.Justify;
            format.LineAlignment = PdfVerticalAlignment.Middle;
            rect.Offset(rect.Width, 0);
            page.Graphics.DrawString(text, font, brush, rect, format);
            page.Graphics.DrawRectangle(pen, rect);

            //Stream the output to the browser.    
            if (InsideBrowser == "Browser")
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
