#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
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
using Syncfusion.Pdf.Redaction;
using System.Drawing;
using System.IO;
using Syncfusion.Pdf.Exporting;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /RemoveImage/

        public ActionResult RemoveImages()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RemoveImages(string viewTemplate, string removeImage, HttpPostedFileBase file)
        {
            if(viewTemplate == "View Template")
            {
                string dataPath = ResolveApplicationDataPath("RemoveImage.pdf");
                Stream file2 = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                //Load the template document
                PdfLoadedDocument doc = new PdfLoadedDocument(file2);
                return doc.ExportAsActionResult("RemoveImageTemplate.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            }
            else if(removeImage == "Remove Images")
            {
                string dataPath = ResolveApplicationDataPath("RemoveImage.pdf");
                Stream file2 = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                //Load the template document
                PdfLoadedDocument doc = new PdfLoadedDocument(file2);

               
                PdfImageInfo[] imagesInfo = doc.Pages[0].ImagesInfo;

                foreach (PdfImageInfo imgInfo in imagesInfo)
                {
                    //Removing Image
                    doc.Pages[0].RemoveImage(imgInfo);
                }
               
                return doc.ExportAsActionResult("RemoveImage.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }
            return View();
        }
    }
}
