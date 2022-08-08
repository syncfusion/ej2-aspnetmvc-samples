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
        public ActionResult SimpleReplace(string Group1, string Button, string MatchCase, string MatchWholeWord, 
            string FindText, string ReplaceText, string ReplaceFirst)
        {
            if (Group1 == null)
                return View();
            if (Button == "View Template")
                return new TemplateResult("Adventure.docx", ResolveApplicationDataPath("Data\\Word"), HttpContext.ApplicationInstance.Response);

            try
            {
                //Load template document
                WordDocument doc = new WordDocument(ResolveApplicationDataPath("Adventure.docx", "Data\\Word"));
                
                //Replaces only the first occurrence of the text
                if (ReplaceFirst == "ReplaceFirst")
                    doc.ReplaceFirst = true;

                //Replace the text that matches the case and whole word
                doc.Replace(FindText, ReplaceText, MatchCase == "MatchCase", MatchWholeWord == "MatchWholeWord");

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