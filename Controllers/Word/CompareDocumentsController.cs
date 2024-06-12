#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.IO;
using System.Web.Mvc;
using System.Xml.Linq;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2MVCSampleBrowser.Controllers.Word
{
    public partial class WordController : Controller
    {
        public ActionResult CompareDocuments(string Compare, string DetectFormat)
        {
            if (Compare == null)
            {
                return View();
            }
            //Loads the original template document.
            using (WordDocument originalDocument = new WordDocument(ResolveApplicationDataPath("OriginalDocument.docx", "Data\\Word")))
            {
                //Loads the revised template document.
                using (WordDocument revisedDocument = new WordDocument(ResolveApplicationDataPath("RevisedDocument.docx", "Data\\Word")))
                {
                    if (DetectFormat == "DetectFormat")
                    {
                        //Compares the original document with revised document
                        originalDocument.Compare(revisedDocument, "Nancy Davolio", DateTime.Now.AddDays(-1));
                    }
                    else
                    {
                        //Disable the flag to ignore the formatting changes while comparing the documents
                        ComparisonOptions comparisonOptions = new ComparisonOptions();
                        comparisonOptions.DetectFormatChanges = false;
                        originalDocument.Compare(revisedDocument, "Nancy Davolio", DateTime.Now.AddDays(-1), comparisonOptions);
                    }
                    //Save the document.
                    FormatType type = FormatType.Docx;
                    string filename = "CompareDocuments.docx";
                    string contenttype = "application/vnd.ms-word.document.12";
                    
                    MemoryStream ms = new MemoryStream();
                    originalDocument.Save(ms, type);
                    originalDocument.Close();
                    ms.Position = 0;
                    return File(ms, contenttype, filename);
                }
            }
        }
    }
}
