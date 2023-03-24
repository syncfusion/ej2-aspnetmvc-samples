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
using System.Text.RegularExpressions;
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
        public ActionResult FindandHighlight(string Group1, string Button, string Group2)
        {
            if (Group1 == null)
                return View();
            if (Button == "View Template")
                return new TemplateResult("Adventure.docx", ResolveApplicationDataPath("Data\\Word"), HttpContext.ApplicationInstance.Response);

            try
            {
                //Load template document
                WordDocument doc = new WordDocument(ResolveApplicationDataPath("Adventure.docx", "Data\\Word"));
                //Get the pattern for regular expression
                Regex regex = new Regex(Group2);
                //Find the first occurrence of the text in the Word document.
                TextSelection text = doc.Find(regex);
                //Set the highlight color for the text.
                if(text != null)
                    text.GetAsOneRange().CharacterFormat.HighlightColor = Color.Green;
                try
                {
                    #region Document SaveOption

                    //Save as .doc format
                    if (Group1 == "WordDoc")
                    {
                        return doc.ExportAsActionResult("Sample.doc", FormatType.Doc,
                            HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                    }
                    //Save as .docx format
                    else if (Group1 == "WordDocx")
                    {
                        return doc.ExportAsActionResult("Sample.docx", FormatType.Docx,
                            HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                    }
                    // Save as WordML(.xml) format
                    else if (Group1 == "WordML")
                    {
                        return doc.ExportAsActionResult("Sample.xml", FormatType.WordML,
                            HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                    }
                    //Save as .pdf format
                    else if (Group1 == "Pdf")
                    {
                        DocToPDFConverter converter = new DocToPDFConverter();
                        PdfDocument pdfDoc = converter.ConvertToPDF(doc);

                        return pdfDoc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response,
                            HttpReadType.Save);
                    }

                    #endregion Document SaveOption
                }
                catch (Exception)
                { }
            }
            catch (Exception Ex)
            {
                System.Diagnostics.Trace.WriteLine(Ex.Message + "\n\n\n" + Ex.StackTrace);
            }
            return View();
        }
    }
}