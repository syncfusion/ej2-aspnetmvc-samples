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
        // GET: /Pdf/

        public ActionResult ImageInsertion()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ImageInsertion(string InsideBrowser)
        {
            string jpgImage = ResolveApplicationImagePath("Autumn Leaves.jpg");
            string tifImage = ResolveApplicationImagePath("256.tif");
            string bmpImage = ResolveApplicationImagePath("mask2.bmp");
            string pngImage = ResolveApplicationImagePath("design.png");
            string emfImage = ResolveApplicationImagePath("metachart.emf");
            string multiframeImage = ResolveApplicationImagePath("Image.tiff");
            string gifImage = ResolveApplicationImagePath("Ani.gif");

            PdfDocument doc = new PdfDocument();
            doc.ViewerPreferences.PageMode = PdfPageMode.FullScreen;
            PdfTrueTypeFont font = new PdfTrueTypeFont(new Font("Tahoma", 22f, FontStyle.Bold), false);
            PdfSolidBrush brush = new PdfSolidBrush(Color.DarkBlue);

            PdfSection section = doc.Sections.Add();
            PdfPage page = section.Pages.Add();
            PdfGraphics g = page.Graphics;

            //png image
            PdfImage image = new PdfBitmap(pngImage);
            g.DrawImage(image, 0, 0, image.Width, image.Height);
            page.Graphics.DrawString("Png Image", font, brush, new PointF(10, 0));

            page = section.Pages.Add();
            g = page.Graphics;

            //Bitmap with Tiff image mask
            image = new PdfBitmap(tifImage);
            (image as PdfBitmap).Mask = new PdfImageMask(new PdfBitmap(bmpImage));
            page.Graphics.DrawString("Image mask", font, brush, new PointF(10, 0));
            g.DrawImage(image, 80, 40);

            //Image pagination -jpg
            image = new PdfBitmap(jpgImage);

            PdfLayoutFormat format = new PdfLayoutFormat();
            format.Layout = PdfLayoutType.Paginate;

            PointF location = new PointF(0, 400);
            SizeF size = new SizeF(400, -1);
            RectangleF rect = new RectangleF(location, size);
            page.Graphics.DrawString("Image Pagination", font, brush, new PointF(10, 360));
            image.Draw(page, rect, format);

            //Multiframe Tiff image
            PdfBitmap tiffImage = new PdfBitmap(multiframeImage);

            int frameCount = tiffImage.FrameCount;

            for (int i = 0; i < frameCount; i++)
            {
                page = section.Pages.Add();
                section.PageSettings.Margins.All = 0;
                g = page.Graphics;
                tiffImage.ActiveFrame = i;
                g.DrawImage(tiffImage, 0, 0, page.GetClientSize().Width, page.GetClientSize().Height);
            }

            page = section.Pages.Add();
            g = page.Graphics;
            image = new PdfBitmap(gifImage);
            g.DrawImage(image, 0, 0, page.Graphics.ClientSize.Width, image.Height);
            page.Graphics.DrawString("Gif Image", font, brush, new PointF(10, 0));

            section.Pages[section.Pages.Count - 3].Graphics.DrawString("Multiframe Tiff Image", font, brush, new PointF(10, 10));
            section.PageSettings.Transition.PageDuration = 1;
            section.PageSettings.Transition.Duration = 1;
            section.PageSettings.Transition.Style = PdfTransitionStyle.Fly;

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
