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
using System.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Mvc.Pdf;
using System.IO;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
       
        public ActionResult CompressExistingPDF()
        {
            Session.Clear();
            ViewData.Add("imageQuality", new SelectList(new string[] { "10", "20",  "30", "40", "50", "60" , "70","80","90","100"},"50"));
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult CompressExistingPDF(bool compressImage =false , bool optPageContents =false , bool removeMetaData =false , bool optFont =false , string imageQuality = "50", string Browser = "null", HttpPostedFileBase file = null)
        {

            if (file != null && file.ContentLength > 0)
            {
                //Load a existing PDF document
                PdfLoadedDocument ldoc = new PdfLoadedDocument(file.InputStream);            

                //Create a new PDF compression options
                PdfCompressionOptions options = new PdfCompressionOptions();

                if (compressImage)
                {
                    //Compress image.
                    options.CompressImages = true;
                    options.ImageQuality = int.Parse((imageQuality));
                }
                else
                    options.CompressImages = false;

                //Compress the font data
                if (optFont)
                    options.OptimizeFont = true;
                else
                    options.OptimizeFont = false;

                //Compress the page contents
                if (optPageContents)
                    options.OptimizePageContents = true;
                else
                    options.OptimizePageContents = false;

                //Remove the metadata information.
                if (removeMetaData)
                    options.RemoveMetadata = true;
                else
                    options.RemoveMetadata = false;

                //Set the options to loaded PDF document
                ldoc.CompressionOptions = options;

                string inputFileSize = "";
                 inputFileSize = GetActualSize(file.ContentLength);

                Session["inputFileSize"] = inputFileSize;

                MemoryStream ms = new MemoryStream();
                ldoc.Save(ms);
                string outputFileSize = "";
                outputFileSize = GetActualSize(ms.Length);

                Session["outputFileSize"] = outputFileSize;

               string[] fileName = file.FileName.Split(new string[] { ".pdf" }, StringSplitOptions.RemoveEmptyEntries);

                //Save to disk
                //Stream the output to the browser.    
                if (Browser == "Browser")
                    return ldoc.ExportAsActionResult(fileName[0] + "_compressed.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
                else
                    return ldoc.ExportAsActionResult(fileName[0] + "_compressed.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);

               
            }
            else
            {
                ViewBag.lab = "Choose a valid PDF file.";
                ViewData.Add("imageQuality", new SelectList(new string[] { "10", "20", "30", "40", "50", "60", "70", "80", "90", "100" }, "50"));
                return View();
            }         
        }

        private string GetActualSize(double value)
        {
            string[] bytenaming = { "B", "KB", "MB", "GB", "TB" };

            int order = 0;
            while (value >= 1024 && order < bytenaming.Length - 1)
            {
                order++;
                value = value / 1024;
            }


            string result = String.Format("{0:0.##} {1}", value, bytenaming[order]);
            return result;
        }

        public string GetStatus()
        {
            string status = string.Empty;
            if (Session["inputFileSize"] != null && Session["outputFileSize"] != null)
            {
                status = "We compressed your file from " + Session["inputFileSize"] + " to " + Session["outputFileSize"]; ;
            }
            return status;
        }


    }
}
