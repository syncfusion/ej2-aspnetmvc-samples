#region Copyright
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;

namespace EJ2MVCSampleBrowser.Controllers.Word
{
    public partial class WordController : Controller
    {
        #region HTMLtoDOC
        public ActionResult HTMLtoDOC(string Group1, HttpPostedFileBase file)
        {
            if (Group1 == null)
                return View();
           //Get input HTML file.
            WordDocument document = GetDocumentForWordConversion(file);
            if (document != null)
            {
                #region Document save option
                //Save as .doc format
                if (Group1 == "WordDoc")
                {
                    return document.ExportAsActionResult("Sample.doc", FormatType.Doc, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                }
                //Save as .docx format
                else if (Group1 == "WordDocx")
                {
                    return document.ExportAsActionResult("Sample.docx", FormatType.Docx, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                }
                // Save as WordML(.xml) format
                else if (Group1 == "WordML")
                {
                    return document.ExportAsActionResult("Sample.xml", FormatType.WordML, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                }
                #endregion Document save option
            }
            else
            {
                ViewBag.Message = string.Format("Browse a HTML document and then click the button to convert as a Word document");
            }
            return View();
        }
        #endregion HTMLtoDOC
        /// <summary>
        /// Gets the HTML document.
        /// </summary>
        /// <param name="file">HttpPostedFileBase contains the uploaded file data.</param>
        /// <returns>Returns the Word document instance.</returns>
        private WordDocument GetDocumentForWordConversion(HttpPostedFileBase file)
        {
            if (file != null)
            {
                return new WordDocument(file.InputStream, FormatType.Html);
            }
            else
            {
                string filePath = ResolveApplicationDataPath("HTMLToWord.html", "Data\\Word");
                return new WordDocument(filePath);
            }
            return null;
        }
    }
}