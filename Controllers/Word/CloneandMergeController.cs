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
        #region Clone and Merge
        public ActionResult CloneandMerge(string Group1, string Group2, string ImportOptions)
        {
            if (Group1 == null)
                return View();
            if (Group2 == null)
                return View();

            string basePath = ResolveApplicationDataPath("", "Data\\Word");
            string sourceFileName = basePath + "Adventure.docx";
            // Opens a source document.
            WordDocument document = new WordDocument(basePath + "Northwind.docx");

            if (Group2 == "UseImportcontents")
            {
                document.ImportContent(new WordDocument(sourceFileName), GetImportOption(ImportOptions));
            }
            else
            {
                //Specifies the import option for the cloning the contents.
                document.ImportOptions = GetImportOption(ImportOptions);
                // Read the source template document
                WordDocument destinationDocument = new WordDocument(sourceFileName);
                // Enumerate all the sections from the source document.
                foreach (IWSection sec in destinationDocument.Sections)
                {
                    // Cloning all the sections one by one and merging it to the destination document.
                    document.Sections.Add(sec.Clone());
                    // Setting section break code to be the same as the template.
                    document.LastSection.BreakCode = sec.BreakCode;
                }
            }
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
        /// <summary>
        /// Returns the ImportOption.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private ImportOptions GetImportOption(string value)
        {
            switch (value)
            {
                case "0":
                    return ImportOptions.KeepSourceFormatting;
                case "1":
                    return ImportOptions.MergeFormatting;
                case "2":
                    return ImportOptions.KeepTextOnly;
                case "3":
                    return ImportOptions.UseDestinationStyles;
                case "4":
                    return ImportOptions.ListContinueNumbering;
                case "5":
                    return ImportOptions.ListRestartNumbering;
            }
            return ImportOptions.UseDestinationStyles;
        }
        #endregion Clone and Merge
    }
}