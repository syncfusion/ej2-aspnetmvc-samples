#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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
using System.Drawing;
using System.IO;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /TextFlow/

        public ActionResult TextFlow()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult TextFlow(string InsideBrowser)
        {
            //Create a new PDF document.
            PdfDocument doc = new PdfDocument();

            //Set compression level
            doc.Compression = PdfCompressionLevel.None;

            //Add a page to the document.
            PdfPage page = doc.Pages.Add();

            //Read the text from the text file
            string path = ResolveApplicationDataPath("Manual.txt");
            StreamReader reader = new StreamReader(path, System.Text.Encoding.ASCII);
            string text = reader.ReadToEnd();
            reader.Close();

            //Set the font
            Font f = new Font("Arial", 12);
            PdfTrueTypeFont font = new PdfTrueTypeFont(f, false);

            //Set the formats for the text
            PdfStringFormat format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Justify;
            format.LineAlignment = PdfVerticalAlignment.Top;
            format.ParagraphIndent = 15f;

            //Create a text element 
            PdfTextElement element = new PdfTextElement(text, font);
            element.Brush = new PdfSolidBrush(Color.Black);
            element.StringFormat = format;
            element.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 12);

            //Set the properties to paginate the text.
            PdfLayoutFormat layoutFormat = new PdfLayoutFormat();
            layoutFormat.Break = PdfLayoutBreakType.FitPage;
            layoutFormat.Layout = PdfLayoutType.Paginate;

            RectangleF bounds = new RectangleF(PointF.Empty, page.Graphics.ClientSize);

            //Raise the events to draw the graphic elements for each page.
            element.BeginPageLayout += new BeginPageLayoutEventHandler(BeginPageLayout);
            element.EndPageLayout += new EndPageLayoutEventHandler(EndPageLayout);

            //Draw the text element with the properties and formats set.
            PdfTextLayoutResult result = element.Draw(page, bounds, layoutFormat);

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

        private void BeginPageLayout(object sender, BeginPageLayoutEventArgs e)
        {
            int index = e.Page.Section.Pages.IndexOf(e.Page);
            float offset = 50;
            PdfSolidBrush brush = new PdfSolidBrush(Color.LightBlue);

            if (index % 2 == 0)
            {
                RectangleF bounds = e.Bounds;
                e.Page.Graphics.DrawEllipse(brush, bounds.Width / 2 - offset, bounds.Height / 2 - offset, 2 * offset, 2 * offset);
            }
            else
            {
                RectangleF bounds = e.Bounds;
                e.Page.Graphics.DrawRectangle(brush, bounds.Width / 2 - offset, bounds.Height / 2 - offset, 2 * offset, 2 * offset);
            }
        }

        private void EndPageLayout(object sender, EndPageLayoutEventArgs e)
        {
            EndTextPageLayoutEventArgs args = (EndTextPageLayoutEventArgs)e;
            PdfPage page = args.Result.Page;
            PdfPen pen = PdfPens.Black;
            page.Graphics.DrawRectangle(pen, new RectangleF(Point.Empty, page.Graphics.ClientSize));
        }

    }
}
