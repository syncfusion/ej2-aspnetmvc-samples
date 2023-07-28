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
using System.Drawing;
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
        #region Bookmarks
        public ActionResult Bookmarks(string Group1)
        {
            if (Group1 == null)
                return View();

            #region BookmarkCreation
            // Creating a new document.
            WordDocument document = new WordDocument();

            // Adding a section to the document.
            IWSection section = document.AddSection();

            // Adding a new paragraph to the section.
            IWParagraph paragraph = section.AddParagraph();

            // Writing text
            paragraph.AppendText("This document demonstrates Essential DocIO's Bookmark functionality.").CharacterFormat.FontSize = 14f;

            // Adding paragraph to the section.
            section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.AppendText("1. Inserting Bookmark Text").CharacterFormat.FontSize = 12f;

            // Adding paragraph to the section.
            section.AddParagraph();
            paragraph = section.AddParagraph();

            // BookmarkStart.
            paragraph.AppendBookmarkStart("Bookmark");
            // Write bookmark
            paragraph.AppendText("Bookmark Text");
            // BookmarkEnd.
            paragraph.AppendBookmarkEnd("Bookmark");

            // Adding paragraph to the section.
            section.AddParagraph();
            paragraph = section.AddParagraph();
            // Indicating hidden bookmark text start.
            paragraph.AppendBookmarkStart("_HiddenText");
            // Writing bookmark text
            paragraph.AppendText("2. Hidden Bookmark Text").CharacterFormat.Font = new System.Drawing.Font("Comic Sans MS", 10);
            // Indicating hidden bookmark text end.
            paragraph.AppendBookmarkEnd("_HiddenText");

            section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.AppendText("3. Nested Bookmarks").CharacterFormat.FontSize = 12f;

            // Writing nested bookmarks
            section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.AppendBookmarkStart("Main");
            paragraph.AppendText(" Main data ");
            paragraph.AppendBookmarkStart("Nested");
            paragraph.AppendText(" Nested data ");
            paragraph.AppendBookmarkStart("NestedNested");
            paragraph.AppendText(" Nested Nested ");
            paragraph.AppendBookmarkEnd("NestedNested");
            paragraph.AppendText(" data Nested ");
            paragraph.AppendBookmarkEnd("Nested");
            paragraph.AppendText(" Data Main ");
            paragraph.AppendBookmarkEnd("Main");
            #endregion BookmarkCreation
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

                return pdfDoc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            } 
            return View();
        }
        #endregion Bookmarks
    }
}