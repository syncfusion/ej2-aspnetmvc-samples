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
using System.Drawing;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /PageSettings/
        # region Private Members
        PdfSection section;
        PdfPage pdfPage;
        # endregion

        public ActionResult PageSettings()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult PageSettings(string InsideBrowser)
        {
            // Create a new document class object.
            PdfDocument doc = new PdfDocument();

            // Create few sections with one page in each.
            for (int i = 0; i < 4; ++i)
            {
                section = doc.Sections.Add();

                //Create page label
                PdfPageLabel label = new PdfPageLabel();

                label.Prefix = "Sec" + i + "-";
                section.PageLabel = label;
                pdfPage = section.Pages.Add();
                section.Pages[0].Graphics.SetTransparency(0.35f);
                section.PageSettings.Transition.PageDuration = 1;
                section.PageSettings.Transition.Duration = 1;
                section.PageSettings.Transition.Style = PdfTransitionStyle.Box;
            }

            //Set page size
            doc.PageSettings.Size = PdfPageSize.A6;

            //Set viewer prefernce.
            doc.ViewerPreferences.HideToolbar = true;
            doc.ViewerPreferences.PageMode = PdfPageMode.FullScreen;

            //Set page orientation
            doc.PageSettings.Orientation = PdfPageOrientation.Landscape;

            //Create a brush
            PdfSolidBrush brush = new PdfSolidBrush(Color.Black);
            brush.Color = new PdfColor(System.Drawing.Color.LightGreen);

            //Create a Rectangle
            PdfRectangle rect = new PdfRectangle(0, 0, 1000f, 1000f);
            rect.Brush = brush;
            PdfPen pen = new PdfPen(System.Drawing.Color.Black);
            pen.Width = 6f;

            //Get the first page in first section
            pdfPage = doc.Sections[0].Pages[0];

            //Draw the rectangle
            rect.Draw(pdfPage.Graphics);

            //Draw a line
            pdfPage.Graphics.DrawLine(pen, 0, 100, 300, 100);

            // Add margins.
            doc.PageSettings.SetMargins(0f);

            //Get the first page in second section
            pdfPage = doc.Sections[1].Pages[0];
            doc.Sections[1].PageSettings.Rotate = PdfPageRotateAngle.RotateAngle90;
            rect.Draw(pdfPage.Graphics);

            pdfPage.Graphics.DrawLine(pen, 0, 100, 300, 100);

            // Change the angle f the section. This should rotate the previous page.
            doc.Sections[2].PageSettings.Rotate = PdfPageRotateAngle.RotateAngle180;
            pdfPage = doc.Sections[2].Pages[0];
            rect.Draw(pdfPage.Graphics);
            pdfPage.Graphics.DrawLine(pen, 0, 100, 300, 100);

            section = doc.Sections[3];
            section.PageSettings.Orientation = PdfPageOrientation.Portrait;
            pdfPage = section.Pages[0];
            rect.Draw(pdfPage.Graphics);
            pdfPage.Graphics.DrawLine(pen, 0, 100, 300, 100);

            //Set the font
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 16f);
            PdfSolidBrush fieldBrush = new PdfSolidBrush(Color.Black);

            //Create page number field
            PdfPageNumberField pageNumber = new PdfPageNumberField(font, fieldBrush);

            //Create page count field
            PdfPageCountField count = new PdfPageCountField(font, fieldBrush);

            //Draw page template
            PdfPageTemplateElement templateElement = new PdfPageTemplateElement(400, 400);
            templateElement.Graphics.DrawString("Page :\tof", font, PdfBrushes.Black, new PointF(260, 200));

            //Draw current page number
            pageNumber.Draw(templateElement.Graphics, new PointF(306, 200));

            //Draw number of pages
            count.Draw(templateElement.Graphics, new PointF(345, 200));
            doc.Template.Stamps.Add(templateElement);
            templateElement.Background = true;

            //Stream the output to the browser.    
            if (InsideBrowser == "Browser")
                return doc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            else
                return doc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);

        }

    }
}
