#region Copyright
// Copyright Syncfusion Inc. 2001 - 2023. All rights reserved.
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

namespace EJ2MVCSampleBrowser.Controllers.Word
{
    public partial class WordController : Controller
    {
        
        #region MarkdownToWord
        public ActionResult MarkdownToWord(string Group1, HttpPostedFileBase file)
        {
            if (Group1 == null)
                return View();
            string output = file == null ? "MarkdownToWord" : Path.GetFileNameWithoutExtension(file.FileName);
            WordDocument document = GetMarkdownDocument(file);
            if (document != null)
            {
                #region Document save option
                //Save as .docx format
                if (Group1 == "WordDocx")
                {
                    return document.ExportAsActionResult(output + ".docx", FormatType.Docx, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                }
                //Save as HTML format
                else if (Group1 == "HTML")
                {
                    return document.ExportAsActionResult(output + ".html", FormatType.Html, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                }
                // Save as PDF format
                else if (Group1 == "PDF")
                {
                    DocToPDFConverter converter = new DocToPDFConverter();
                    //Convert word document into PDF document
                    PdfDocument pdfDoc = converter.ConvertToPDF(document);
                    return pdfDoc.ExportAsActionResult(output + ".pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
                }
                #endregion Document save option
            }
            return View();
        }
        #endregion MarkdownToWord
        /// <summary>
        /// Gets the Markdown from default template document or uploaded document.
        /// </summary>
        /// <param name="file">HttpPostedFileBase contains the uploaded file data.</param>
        /// <returns>Returns the Word document instance.</returns>
        private WordDocument GetMarkdownDocument(HttpPostedFileBase file)
        {
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName).ToLower();
                
                if (extension == ".md")
                    return new WordDocument(file.InputStream, FormatType.Markdown);
                else
                    ViewBag.Message = string.Format("Please choose Markdown format document to convert to Word or PDF");
            }
            else
            {
                string filePath = ResolveApplicationDataPath("MarkdownToWord.md", "Data\\Word");
                return new WordDocument(filePath);
            }
            return null;
        }
    }
}