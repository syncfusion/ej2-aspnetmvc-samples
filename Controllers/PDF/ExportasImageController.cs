#region Copyright Syncfusion Inc. 2001 - 2023
// Copyright Syncfusion Inc. 2001 - 2023. All rights reserved.
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
using System.Drawing.Imaging;

using Syncfusion.Mvc.Pdf;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Interactive;
using System.Drawing;
using Syncfusion.Pdf.Parsing;
using System.IO;


namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /ExportasImage/

        public ActionResult ExportasImage()
        {
            return View();
        }

        #region Fields
        PdfLoadedDocument loadedDocument = null;
        #endregion

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ExportasImage(string Browser, string submit1)
        {
            if (submit1 == "View Template")
            {
                string dataPath = ResolveApplicationDataPath("MultiColumnReports.pdf");
                Stream file2 = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.Read);

                //Load the template document
                PdfLoadedDocument ldoc = new PdfLoadedDocument(file2);
                return ldoc.ExportAsActionResult("InputTemplate.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            }

            //Loaded input pdf file.
            loadedDocument = new PdfLoadedDocument(ResolveApplicationDataPath("MultiColumnReports.pdf"));

            //Exporting specify page index as image.
            Bitmap image = loadedDocument.ExportAsImage(0);

            //Stream the output to the browser.   
            if (Browser == "Browser")
                ExportAsImage(image, "sample.jpeg", ImageFormat.Jpeg, HttpContext.ApplicationInstance.Response, HttpReadType.Open);

            else
                ExportAsImage(image, "sample.jpeg", ImageFormat.Jpeg, HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            return View(); 
        }
        protected void ExportAsImage(System.Drawing.Image image, string fileName, ImageFormat imageFormat, HttpResponse response, HttpReadType type)
        {
            if (ControllerContext == null)
                throw new ArgumentNullException("Context");
            string disposition = "content-disposition";
            if (type == HttpReadType.Open)
            {
                response.AddHeader(disposition, "inline; filename=" + fileName);
            }
            else if (type == HttpReadType.Save)
            {
                response.AddHeader(disposition, "attachment; filename=\"" + fileName + "\"");
            }
            image.Save(Response.OutputStream, imageFormat);
            Response.End();
        }     

    }
}
