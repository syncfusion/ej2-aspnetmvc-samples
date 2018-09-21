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
        string dataPath2;
        #region ImageInsertion
        public ActionResult ImageInsertion(string Group1)
        {
            if (Group1 == null)
                return View();
            //Create a new document
            WordDocument document = new WordDocument();

            //Adding a new section to the document.
            IWSection section = document.AddSection();

            //Adding a paragraph to the section
            IWParagraph paragraph = section.AddParagraph();

            dataPath2 = ResolveApplicationDataPath("", "Images\\DocIO");

            //Writing text.
            paragraph.AppendText("This sample demonstrates how to insert Vector and Scalar images inside a document.");

            //Adding a new paragraph
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            //Inserting .gif .
            WPicture picture = (WPicture)paragraph.AppendPicture(Image.FromFile(System.IO.Path.Combine(dataPath2, "yahoo.gif")));
            //Adding Image caption
            picture.AddCaption("Yahoo [.gif Image]", CaptionNumberingFormat.Roman, CaptionPosition.AboveImage);

            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            //Inserting .bmp
            picture = (WPicture)paragraph.AppendPicture(Image.FromFile(dataPath2 + "Reports.bmp"));
            //Adding Image caption
            picture.AddCaption("Reports [.bmp Image]", CaptionNumberingFormat.Roman, CaptionPosition.AboveImage);

            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            //Inserting .png 
            picture = (WPicture)paragraph.AppendPicture(Image.FromFile(dataPath2 + "google.PNG"));
            //Adding Image caption
            picture.AddCaption("Google [.png Image]", CaptionNumberingFormat.Roman, CaptionPosition.AboveImage);

            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            //Inserting .tif 
            picture = (WPicture)paragraph.AppendPicture(Image.FromFile(dataPath2 + "Square.tif"));
            //Adding Image caption
            picture.AddCaption("Square [.tif Image]", CaptionNumberingFormat.Roman, CaptionPosition.AboveImage);

            //Adding a new paragraph.
            paragraph = section.AddParagraph();
            //Setting Alignment for the image.
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            //Inserting .wmf Image to the document.
            WPicture mImage = (WPicture)paragraph.AppendPicture(Image.FromFile(dataPath2 + "Ess chart.emf"));
            //Scaling Image
            mImage.HeightScale = 50f;
            mImage.WidthScale = 50f;

            //Adding Image caption
            mImage.AddCaption("Chart Vector Image", CaptionNumberingFormat.Roman, CaptionPosition.AboveImage);

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
        #endregion ImageInsertion
    }
}