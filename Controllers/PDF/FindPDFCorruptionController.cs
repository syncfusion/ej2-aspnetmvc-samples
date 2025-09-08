#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf;
using Syncfusion.Mvc.Pdf;
using System.IO;
using EJ2MVCSampleBrowser.Models;
using System.Text;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /FindPDFCorruption/

        public ActionResult FindPDFCorruption()
        {
            FindPDFCorruptionMessage message = new FindPDFCorruptionMessage();
            message.Message = string.Empty;
            return View("FindPDFCorruption", message);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult FindPDFCorruption(string InsideBrowser)
        {

            FindPDFCorruptionMessage message = new FindPDFCorruptionMessage();

            ////Create a new instance for the PDF analyzer.
            FileStream fileStreamInput = new FileStream(ResolveApplicationDataPath("CorruptedDocument.pdf"), FileMode.Open, FileAccess.Read);
            PdfDocumentAnalyzer analyzer = new PdfDocumentAnalyzer(fileStreamInput);
            StringBuilder builder = new StringBuilder();

            //Get the syntax errors.
            SyntaxAnalyzerResult result = analyzer.AnalyzeSyntax();

            //Check whether the document is corrupted or not.
            if (result.IsCorrupted)
            {

                builder.AppendLine("The PDF document is corrupted.");
                int count = 1;
                foreach (PdfException exception in result.Errors)
                {
                    builder.AppendLine(count++.ToString() + ": " + exception.Message);
                }
                message.Message = builder.ToString();
            }

            return View("FindPDFCorruption", message);
        }
    }
}
