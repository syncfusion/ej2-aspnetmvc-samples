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


using Syncfusion.Pdf;
using Syncfusion.XPS;
using Syncfusion.Mvc.Pdf;
using System.IO;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /XPStoPDF/

        public ActionResult XPStoPDF()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult XPStoPDF(string InsideBrowser)
        {
            Stream readFile = new FileStream(ResolveApplicationDataPath(@"XPStoPDF.xps"), FileMode.Open, FileAccess.Read, FileShare.Read);
            XPSToPdfConverter converter = new XPSToPdfConverter();

            //Convert XPS document into PDF document
            PdfDocument document = converter.Convert(readFile);

            //Save the pdf file            
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
