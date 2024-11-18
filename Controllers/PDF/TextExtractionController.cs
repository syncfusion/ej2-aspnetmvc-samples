#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
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
using System.IO;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /TextExtraction/

        public ActionResult TextExtraction()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult TextExtraction(string Extract, string extractTextFromFile, int pageNumber, HttpPostedFileBase file)
        {
            if (!string.IsNullOrEmpty(Extract))
            {

                //Stream sfile1 = fileUpload1.PostedFile.InputStream;
                Stream sfile1 = new FileStream(ResolveApplicationDataPath("Manual.Pdf"), FileMode.Open, FileAccess.Read, FileShare.Read);
                // Load an existing PDF
                PdfLoadedDocument ldoc = new PdfLoadedDocument(sfile1);

                // Loading Page collections
                PdfLoadedPageCollection loadedPages = ldoc.Pages;

                string s = "";

                // Extract text from PDF document pages
                foreach (PdfLoadedPage lpage in loadedPages)
                {
                    s += lpage.ExtractText();
                }

                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(s);
                MemoryStream stream = new MemoryStream(byteArray);
                FileStreamResult fileStreamResult = new FileStreamResult(stream, "application/txt");
                fileStreamResult.FileDownloadName = "Sample.txt";
                return fileStreamResult;
            }
            else if(!string.IsNullOrEmpty(extractTextFromFile))
            {
                if (file != null)
                {
                    //Load the PDF document.
                    PdfLoadedDocument loadedDocument = new PdfLoadedDocument(file.InputStream);
                    if (pageNumber <= loadedDocument.Pages.Count && pageNumber != 0)
                    { 
                        
                        //Get the page from the PDF document.
                        PdfPageBase page = loadedDocument.Pages[pageNumber - 1];

                        //Extract text.
                        string s = page.ExtractText(true);

                        byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(s);
                        MemoryStream stream = new MemoryStream(byteArray);
                        FileStreamResult fileStreamResult = new FileStreamResult(stream, "application/txt");
                        fileStreamResult.FileDownloadName = "Sample.txt";
                        return fileStreamResult;
                    }
                    else
                    {
                        ViewBag.Message = "Please enter a valid page number. The page number must be within the range 1 to " + loadedDocument.Pages.Count;
                        loadedDocument.Close(true);
                        return View();
                    }
                }
                else
                {
                    ViewBag.Message = "Please select a PDF document to extract text.";
                    return View();
                }
            }
            return View();

        }
    }
}