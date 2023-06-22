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
        public ActionResult Watermark(string Group1, string Group2)
        {
            if (Group2 == null)
                return View();

            //Open an existing word document 
            WordDocument doc = new WordDocument(ResolveApplicationDataPath("Watermark.doc", "Data\\Word"));

            if (Group2 != "Picture")
            {
                //Add text watermark.
                TextWatermark textWatermark = new TextWatermark();
                doc.Watermark = textWatermark;

                //Set the text for the watermark.
                textWatermark.Text = "Demo";

                //Set the color for the watermark text.
                textWatermark.Color = Color.Gray;

                //Set the size.
                textWatermark.Size = 120;
            }
            else
            {
                //Add Picture watermark to the word document.
                PictureWatermark picWatermark = new PictureWatermark();
                doc.Watermark = picWatermark;

                //Set the picture.
                picWatermark.Picture = System.Drawing.Image.FromFile(ResolveApplicationDataPath("Northwind_logo.png", "Images\\Word"));

                //Set the properties for the watermark.
                picWatermark.Scaling = 100.0f;
                picWatermark.Washout = false;
            }
            #region Document Save Option
            //Save as .doc format
            if (Group1 == "WordDoc")
            {
                return doc.ExportAsActionResult("Sample.doc", FormatType.Doc, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            //Save as .docx format
            else if (Group1 == "WordDocx")
            {
                return doc.ExportAsActionResult("Sample.docx", FormatType.Docx, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            // Save as WordML(.xml) format
            else if (Group1 == "WordML")
            {
                return doc.ExportAsActionResult("Sample.xml", FormatType.WordML, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            //Save as .pdf format
            else if (Group1 == "Pdf")
            {
                DocToPDFConverter converter = new DocToPDFConverter();
                PdfDocument pdfDoc = converter.ConvertToPDF(doc);

                return pdfDoc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }
            #endregion Document Save Option

            return View();
        }
    }
}