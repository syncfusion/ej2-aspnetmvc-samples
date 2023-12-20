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
using Syncfusion.Office;

namespace EJ2MVCSampleBrowser.Controllers.Word
{

    public partial class WordController : Controller
    {
        public ActionResult LaTeX(string Button, string Group1, string LaTeX)
        {
            if (Button == null)
                return View();

            //Opens an existing Word document
            WordDocument document = new WordDocument(ResolveApplicationDataPath("Create Equation.docx", "Data\\Word"));
            //Get the last section in the document
            WSection section = document.LastSection;
            //Set page margins
            section.PageSetup.Margins.All = 72;
            //Add new paragraph to the section
            IWParagraph paragraph = section.AddParagraph();

            //Append text to paragraph
            IWTextRange textRange = paragraph.AppendText("Mathematical equation");
            textRange.CharacterFormat.FontSize = 28;
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;
            paragraph.ParagraphFormat.AfterSpacing = 12;

            //Add new paragraph to the section.
            paragraph = section.AddParagraph();
            //Append mathematical equation using LaTeX.
            if (!string.IsNullOrEmpty(LaTeX))
                paragraph.AppendMath(LaTeX);

            //Save as .docx format
            if (Group1== "WordDocx")
            {
                return document.ExportAsActionResult("LaTeXToMath.docx", FormatType.Docx, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            //Save as .pdf format
            else if (Group1 == "Pdf")
            {
                DocToPDFConverter converter = new DocToPDFConverter();
                PdfDocument pdfDoc = converter.ConvertToPDF(document);
                document.Close();
                converter.Dispose();
                return pdfDoc.ExportAsActionResult("LaTeXToMath.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }
            
            return View();
        }
    }
}