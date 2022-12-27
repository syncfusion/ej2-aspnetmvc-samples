#region Copyright
// Copyright Syncfusion Inc. 2001 - 2022. All rights reserved.
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
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using Syncfusion.Mvc.Pdf;
using Syncfusion.OfficeChartToImageConverter;

namespace EJ2MVCSampleBrowser.Controllers.Word
{
    public partial class WordController : Controller
    {
        #region Word to Markdown
        public ActionResult WordToMarkdown(string button, HttpPostedFileBase file)
        {
            if (button == null)
                return View();
            WordDocument document = GetInputWordocumentForConversion(file);
            if (document != null)
            {
                string output = file == null ? "WordtoMD" : Path.GetFileNameWithoutExtension(file.FileName);

                //Convert word document into Markdown document
                try
                {
                   return document.ExportAsActionResult(output + ".md", FormatType.Markdown, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                }
                catch (Exception)
                {
                }
                finally
                {

                }
            }
            return View();
        }
        /// <summary>
        /// Gets the Word document from default template document or uploaded document.
        /// </summary>
        /// <param name="file">HttpPostedFileBase contains the uploaded file data.</param>
        /// <returns>Returns the Word document instance.</returns>
        private WordDocument GetInputWordocumentForConversion(HttpPostedFileBase file)
        {
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName).ToLower();

                if (extension == ".doc" || extension == ".docx" || extension == ".dot" || extension == ".dotx" || extension == ".dotm" || extension == ".docm"
                   || extension == ".xml" || extension == ".rtf")
                    return new WordDocument(file.InputStream, FormatType.Automatic);
                else
                    ViewBag.Message = string.Format("Please choose Word format document to convert to Markdown");
            }
            else
            {
                string filePath = ResolveApplicationDataPath("WordtoMD.docx", "Data\\Word");
                return new WordDocument(filePath);
            }
            return null;
        }
        #endregion Word to Markdown
    }
}