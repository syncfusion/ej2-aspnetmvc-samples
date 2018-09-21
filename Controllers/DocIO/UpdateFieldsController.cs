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
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using Syncfusion.Mvc.Pdf;

namespace EJ2MVCSampleBrowser.Controllers.DocIO
{
    public partial class DocIOController : Controller
    {
        #region Update Fields
        public ActionResult UpdateFields(string Group1, string Button)
        {
            if (Group1 == null)
                return View();
            if (Button == "View Template")
                return new TemplateResult("TemplateUpdateFields.docx", ResolveApplicationDataPath("Data\\DocIO"), HttpContext.ApplicationInstance.Response);

            //Loads the template document.
            WordDocument document = new WordDocument(ResolveApplicationDataPath("TemplateUpdateFields.docx", "Data\\DocIO"));

            //Initialize DataSet object.
            DataSet ds = new DataSet();

            //Load data from the xml document.
            ds.ReadXml(ResolveApplicationDataPath("StockDetails.xml", "Data\\DocIO"));

            // Execute Mail Merge with groups.
            document.MailMerge.ExecuteGroup(ds.Tables["StockDetails"]);

            //Update fields in the document.
            document.UpdateDocumentFields();

            #region saveOption
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
            #endregion saveOption
            return View();
        }
        #endregion Update Fields
    }
}