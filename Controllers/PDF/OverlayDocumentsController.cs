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
using Syncfusion.Pdf.Parsing;
using System.Drawing;
using System.IO;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /OverlayDocuments/

        public ActionResult  OverlayDocuments()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult OverlayDocuments(string InsideBrowser)
        {
            string dataPath1, dataPath2;

            dataPath1 = ResolveApplicationDataPath("BorderTemplate.pdf");
            dataPath2 = ResolveApplicationDataPath("SourceTemplate.pdf");

            Stream stream1 = new FileStream(dataPath2, FileMode.Open, FileAccess.Read);
            FileStream file = new FileStream(dataPath1, FileMode.Open, FileAccess.Read, FileShare.Read);
            PdfLoadedDocument ldDoc1 = new PdfLoadedDocument(file);
            PdfLoadedDocument ldDoc2 = new PdfLoadedDocument(stream1);
            PdfDocument doc = new PdfDocument();

            for (int i = 0, count = ldDoc2.Pages.Count; i < count; ++i)
            {
                PdfPage page = doc.Pages.Add();
                PdfGraphics g = page.Graphics;

                PdfPageBase lpage = ldDoc2.Pages[i];
                PdfTemplate template = lpage.CreateTemplate();

                g.DrawPdfTemplate(template, PointF.Empty, page.GetClientSize());

                lpage = ldDoc1.Pages[0];
                template = lpage.CreateTemplate();

                g.DrawPdfTemplate(template, PointF.Empty, page.GetClientSize());
            }

            if (InsideBrowser == "Browser")
                return doc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            else
                return doc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
        }

    }
}
