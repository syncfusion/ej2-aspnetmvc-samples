#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
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
using Syncfusion.Pdf.Parsing;
using System.Drawing;
using System.IO;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /SplitPDF/

        public ActionResult SplitPDF()
        {
            return View();
        }       

        [HttpPost]
        public ActionResult SplitPDF(string Browser, string pageIndex, HttpPostedFileBase file)
        {
           
            if (file != null && file.ContentLength > 0)
            {
               
                var fileName = Path.GetFileName(file.FileName);                            

                int splitAtPage = int.Parse(pageIndex.ToString());

                PdfLoadedDocument ldoc = new PdfLoadedDocument(file.InputStream);

                if (splitAtPage <= ldoc.Pages.Count&&splitAtPage!=0)
                {                    
                    //Create PDF documents.
                    PdfDocument doc1 = new PdfDocument();

                    //Import PDF document into splitAtPage index.                   
                    doc1.ImportPage(ldoc, splitAtPage-1);

                    //Save to disk
                    if (Browser == "Browser")
                    {
                        return doc1.ExportAsActionResult("Document1.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
                    }
                    else
                    {
                        return doc1.ExportAsActionResult("Document1.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
                    }
                }
                else                 
                {
                    ViewBag.lab = "Invalid Page no";
                }             
            }
            else
            {
                ViewBag.lab = "Choose PDF document to Split";
            }
            return View();
        }       
    }
}
