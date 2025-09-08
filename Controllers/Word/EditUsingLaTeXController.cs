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
using Syncfusion.Office;
using System.Text.RegularExpressions;

namespace EJ2MVCSampleBrowser.Controllers.Word
{

    public partial class WordController : Controller
    {
        public ActionResult EditUsingLaTeX(string Button, string Group1, string LaTeX)
        {
            if (Button == null)
                return View();
            if (Button == "View Template")
                return new TemplateResult("EditEquationLaTeXInput.docx", ResolveApplicationDataPath("Data\\Word"), HttpContext.ApplicationInstance.Response);

            //Opens an existing Word document
            WordDocument document = new WordDocument(ResolveApplicationDataPath("EditEquationLaTeXInput.docx", "Data\\Word"));
            //Find all the equations in the Word document.
            List<Entity> entities = document.FindAllItemsByProperty(EntityType.Math, null, null);

            //Get the first math equation.
            WMath math = entities[0] as WMath;

            //Update the modified laTeX code to the equation.
            if (!string.IsNullOrEmpty(LaTeX))
                math.MathParagraph.LaTeX = LaTeX;

            //Save as .docx format
            if (Group1== "WordDocx")
            {
                return document.ExportAsActionResult("EditEquationLaTeX.docx", FormatType.Docx, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            //Save as .pdf format
            else if (Group1 == "Pdf")
            {
                DocToPDFConverter converter = new DocToPDFConverter();
                PdfDocument pdfDoc = converter.ConvertToPDF(document);
                document.Close();
                converter.Dispose();
                return pdfDoc.ExportAsActionResult("EditEquationLaTeX.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }
			
            return View();
        }
    }
}