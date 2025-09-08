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
        #region AutoShapes
        public ActionResult AutoShapes(string Group1)
        {
            if (Group1 == null)
                return View();
            
            //Initialize Word document
            WordDocument doc = new WordDocument();
            //Ensure Minimum
            doc.EnsureMinimal();
            //Append AutoShape
            Shape shape = doc.LastParagraph.AppendShape(AutoShapeType.RoundedRectangle, 130, 45);
            //Set horizontal alignment
            shape.HorizontalAlignment = ShapeHorizontalAlignment.Center;
            //Set horizontal origin
            shape.HorizontalOrigin = HorizontalOrigin.Page;
            //Set vertical origin
            shape.VerticalOrigin = VerticalOrigin.Page;
            //Set vertical position
            shape.VerticalPosition = 50;
            //Set AllowOverlap to true for overlapping shapes
            shape.WrapFormat.AllowOverlap = true;
            //Set Fill Color
            shape.FillFormat.Color = System.Drawing.Color.Blue;
            //Set Content vertical alignment
            shape.TextFrame.TextVerticalAlignment = VerticalAlignment.Middle;
            //Add Texbody contents to Shape
            IWParagraph para = shape.TextBody.AddParagraph();
            para.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            para.AppendText("Requirement").ApplyCharacterFormat(new WCharacterFormat(doc) { Bold = true, TextColor = System.Drawing.Color.White, FontSize = 12, FontName = "Verdana" });

            shape = doc.LastParagraph.AppendShape(AutoShapeType.DownArrow, 45, 45);
            shape.HorizontalAlignment = ShapeHorizontalAlignment.Center;
            shape.HorizontalOrigin = HorizontalOrigin.Page;
            shape.VerticalOrigin = VerticalOrigin.Page;
            shape.VerticalPosition = 95;
            shape.WrapFormat.AllowOverlap = true;

            shape = doc.LastParagraph.AppendShape(AutoShapeType.RoundedRectangle, 130, 45);
            shape.HorizontalAlignment = ShapeHorizontalAlignment.Center;
            shape.HorizontalOrigin = HorizontalOrigin.Page;
            shape.VerticalOrigin = VerticalOrigin.Page;
            shape.VerticalPosition = 140;
            shape.WrapFormat.AllowOverlap = true;
            shape.FillFormat.Color = System.Drawing.Color.Orange;
            shape.TextFrame.TextVerticalAlignment = VerticalAlignment.Middle;
            para = shape.TextBody.AddParagraph();
            para.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            para.AppendText("Design").ApplyCharacterFormat(new WCharacterFormat(doc) { Bold = true, TextColor = System.Drawing.Color.White, FontSize = 12, FontName = "Verdana" });

            shape = doc.LastParagraph.AppendShape(AutoShapeType.DownArrow, 45, 45);
            shape.HorizontalAlignment = ShapeHorizontalAlignment.Center;
            shape.HorizontalOrigin = HorizontalOrigin.Page;
            shape.VerticalOrigin = VerticalOrigin.Page;
            shape.VerticalPosition = 185;
            shape.WrapFormat.AllowOverlap = true;

            shape = doc.LastParagraph.AppendShape(AutoShapeType.RoundedRectangle, 130, 45);
            shape.HorizontalAlignment = ShapeHorizontalAlignment.Center;
            shape.HorizontalOrigin = HorizontalOrigin.Page;
            shape.VerticalOrigin = VerticalOrigin.Page;
            shape.VerticalPosition = 230;
            shape.WrapFormat.AllowOverlap = true;
            shape.FillFormat.Color = System.Drawing.Color.Blue;
            shape.TextFrame.TextVerticalAlignment = VerticalAlignment.Middle;
            para = shape.TextBody.AddParagraph();
            para.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            para.AppendText("Execution").ApplyCharacterFormat(new WCharacterFormat(doc) { Bold = true, TextColor = System.Drawing.Color.White, FontSize = 12, FontName = "Verdana" });

            shape = doc.LastParagraph.AppendShape(AutoShapeType.DownArrow, 45, 45);
            shape.HorizontalAlignment = ShapeHorizontalAlignment.Center;
            shape.HorizontalOrigin = HorizontalOrigin.Page;
            shape.VerticalOrigin = VerticalOrigin.Page;
            shape.VerticalPosition = 275;
            shape.WrapFormat.AllowOverlap = true;

            shape = doc.LastParagraph.AppendShape(AutoShapeType.RoundedRectangle, 130, 45);
            shape.HorizontalAlignment = ShapeHorizontalAlignment.Center;
            shape.HorizontalOrigin = HorizontalOrigin.Page;
            shape.VerticalOrigin = VerticalOrigin.Page;
            shape.VerticalPosition = 320;
            shape.WrapFormat.AllowOverlap = true;
            shape.FillFormat.Color = System.Drawing.Color.Violet;
            shape.TextFrame.TextVerticalAlignment = VerticalAlignment.Middle;
            para = shape.TextBody.AddParagraph();
            para.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            para.AppendText("Testing").ApplyCharacterFormat(new WCharacterFormat(doc) { Bold = true, TextColor = System.Drawing.Color.White, FontSize = 12, FontName = "Verdana" });

            shape = doc.LastParagraph.AppendShape(AutoShapeType.DownArrow, 45, 45);
            shape.HorizontalAlignment = ShapeHorizontalAlignment.Center;
            shape.HorizontalOrigin = HorizontalOrigin.Page;
            shape.VerticalOrigin = VerticalOrigin.Page;
            shape.VerticalPosition = 365;
            shape.WrapFormat.AllowOverlap = true;

            shape = doc.LastParagraph.AppendShape(AutoShapeType.RoundedRectangle, 130, 45);
            shape.HorizontalAlignment = ShapeHorizontalAlignment.Center;
            shape.HorizontalOrigin = HorizontalOrigin.Page;
            shape.VerticalOrigin = VerticalOrigin.Page;
            shape.VerticalPosition = 410;
            shape.WrapFormat.AllowOverlap = true;
            shape.FillFormat.Color = System.Drawing.Color.PaleVioletRed;
            shape.TextFrame.TextVerticalAlignment = VerticalAlignment.Middle;
            para = shape.TextBody.AddParagraph();
            para.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            para.AppendText("Release").ApplyCharacterFormat(new WCharacterFormat(doc) { Bold = true, TextColor = System.Drawing.Color.White, FontSize = 12, FontName = "Verdana" });

            #region save document
            //Save as .docx format
            if (Group1 == "WordDocx")
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
            #endregion
            return View();
        }
        #endregion
    }
}
