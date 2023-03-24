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
        // GET: /OpenTypeFont/

        public ActionResult OpenTypeFont()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult OpenTypeFont(string InsideBrowser)
        {
			
            //Create a new PDF document
            PdfDocument doc = new PdfDocument();

            //Add a page
            PdfPage page = doc.Pages.Add();

            //Create font
			string path = ResolveApplicationDataPath("NotoSerif-Black.otf");
			Stream fontStream = System.IO.File.OpenRead(path);            
            PdfFont font = new PdfTrueTypeFont(fontStream, 14);
            

            //Text to draw
            string text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";           

            //Create a brush
            PdfBrush brush = new PdfSolidBrush(Color.Black);
            PdfPen pen = new PdfPen(Color.Black);
            SizeF clipBounds = page.Graphics.ClientSize;
            RectangleF rect = new RectangleF(0, 0, clipBounds.Width, clipBounds.Height);
            
			//Draw text.
            page.Graphics.DrawString(text, font, brush, rect);
			
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
