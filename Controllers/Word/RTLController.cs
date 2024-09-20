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
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using Syncfusion.Mvc.Pdf;

namespace EJ2MVCSampleBrowser.Controllers.Word
{
    public partial class WordController : Controller
    {
        #region RTL
        public ActionResult RTL(string Group1)
        {
            if (Group1 == null)
                return View();
            // Creating a new document.
            WordDocument document = new WordDocument();
            document.EnsureMinimal();

            // Reading Arabic text from text file.
            StreamReader s = new StreamReader(ResolveApplicationDataPath("Arabic.txt", "Data\\Word"), System.Text.Encoding.ASCII);
            string text = s.ReadToEnd();

            // Appending Arabic text to the document.
            document.LastParagraph.ParagraphFormat.Bidi = true;
            IWTextRange txtRange = document.LastParagraph.AppendText(text);
            txtRange.CharacterFormat.Bidi = true;

            // Set the RTL text font size.
            txtRange.CharacterFormat.FontSizeBidi = 16;

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
            //Save as .pdf format
            else if (Group1 == "Pdf")
            {
                DocToPDFConverter converter = new DocToPDFConverter();
                PdfDocument pdfDoc = converter.ConvertToPDF(document);
                document.Close();
                converter.Dispose();
                return pdfDoc.ExportAsActionResult("Sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }
            #endregion Document save option
            return View();
        }
        #endregion RTL
    }
}