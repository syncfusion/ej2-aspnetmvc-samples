#region Copyright
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
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
        #region WordToHTML
        public ActionResult WordToHTML(string button, HttpPostedFileBase file)
        {
            if (button == null)
                return View();
            //Get input Word document.
            WordDocument document = GetWordDocumentForHTMLConversion(file);
            if (document != null)
                return document.ExportAsActionResult("WordToHTML.html", FormatType.Html, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);

            return View();
        }
        #endregion
        /// <summary>
        /// Gets the Word document from default template document or uploaded document.
        /// </summary>
        /// <param name="file">HttpPostedFileBase contains the uploaded file data.</param>
        /// <returns>Returns the Word document instance.</returns>
        private WordDocument GetWordDocumentForHTMLConversion(HttpPostedFileBase file)
        {
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName).ToLower();

                if (extension == ".doc" || extension == ".docx" || extension == ".rtf" || extension == ".dot" || extension == ".dotm" || extension == ".dotx" || extension == ".docm" || extension == ".xml")
                    return new WordDocument(file.InputStream, FormatType.Automatic);
                else
                    ViewData["Message"] = string.Format("Please choose Word format document to convert to HTML");
            }
            else
            {
                string filePath = ResolveApplicationDataPath("WordToHTML.docx", "Data\\Word");
                return new WordDocument(filePath);
            }
            return null;
        }
    }
}