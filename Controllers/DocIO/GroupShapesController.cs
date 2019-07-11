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

namespace EJ2MVCSampleBrowser.Controllers.DocIO
{
    public partial class DocIOController : Controller
    {
        #region GroupShapes
        public ActionResult GroupShapes(string Group1)
        {
            if (Group1 == null)
                return View();
            
            //Initialize Word document
            WordDocument doc = new WordDocument();
            //Ensure Minimum
            doc.EnsureMinimal();
            //Set margins for page.
            doc.LastSection.PageSetup.Margins.All = 72;
            //Create new group shape
            GroupShape groupShape = new GroupShape(doc);

            //Append AutoShape
            Shape shape = new Shape(doc, AutoShapeType.RoundedRectangle);
            shape.Width = 130;
            shape.Height = 45;
            //Set horizontal origin
            shape.HorizontalOrigin = HorizontalOrigin.Page;
            //Set vertical origin
            shape.VerticalOrigin = VerticalOrigin.Page;
            //Set vertical position
            shape.VerticalPosition = 122;
            //Set horizontal position
            shape.HorizontalPosition = 220;
            //Set AllowOverlap to true for overlapping shapes
            shape.WrapFormat.AllowOverlap = true;
            //Set Fill Color
            shape.FillFormat.Color = System.Drawing.Color.Blue;
            //Set Content vertical alignment
            shape.TextFrame.TextVerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;
            //Add Texbody contents to Shape
            IWParagraph para = shape.TextBody.AddParagraph();
            para.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            para.AppendText("Requirement").ApplyCharacterFormat(new WCharacterFormat(doc) { Bold = true, TextColor = System.Drawing.Color.White, FontSize = 12, FontName = "Verdana" });
            groupShape.Add(shape);

            shape = new Shape(doc, AutoShapeType.DownArrow);
            shape.Width = 45;
            shape.Height = 45;
            shape.HorizontalOrigin = HorizontalOrigin.Page;
            shape.VerticalOrigin = VerticalOrigin.Page;
            shape.VerticalPosition = 167;
            //Set horizontal position
            shape.HorizontalPosition = 265;
            shape.WrapFormat.AllowOverlap = true;
            groupShape.Add(shape);

            shape = new Shape(doc, AutoShapeType.RoundedRectangle);
            shape.Width = 130;
            shape.Height = 45;
            shape.HorizontalOrigin = HorizontalOrigin.Page;
            shape.VerticalOrigin = VerticalOrigin.Page;
            shape.VerticalPosition = 212;
            //Set horizontal position
            shape.HorizontalPosition = 220;
            shape.WrapFormat.AllowOverlap = true;
            shape.FillFormat.Color = System.Drawing.Color.Orange;
            shape.TextFrame.TextVerticalAlignment = VerticalAlignment.Middle;
            para = shape.TextBody.AddParagraph();
            para.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            para.AppendText("Design").ApplyCharacterFormat(new WCharacterFormat(doc) { Bold = true, TextColor = System.Drawing.Color.White, FontSize = 12, FontName = "Verdana" });
            groupShape.Add(shape);

            shape = new Shape(doc, AutoShapeType.DownArrow);
            shape.Width = 45;
            shape.Height = 45;
            shape.HorizontalOrigin = HorizontalOrigin.Page;
            shape.VerticalOrigin = VerticalOrigin.Page;
            shape.VerticalPosition = 257;
            //Set horizontal position
            shape.HorizontalPosition = 265;
            shape.WrapFormat.AllowOverlap = true;
            groupShape.Add(shape);

            shape = new Shape(doc, AutoShapeType.RoundedRectangle);
            shape.Width = 130;
            shape.Height = 45;
            shape.HorizontalOrigin = HorizontalOrigin.Page;
            shape.VerticalOrigin = VerticalOrigin.Page;
            shape.VerticalPosition = 302;
            //Set horizontal position
            shape.HorizontalPosition = 220;
            shape.WrapFormat.AllowOverlap = true;
            shape.FillFormat.Color = System.Drawing.Color.Blue;
            shape.TextFrame.TextVerticalAlignment = VerticalAlignment.Middle;
            para = shape.TextBody.AddParagraph();
            para.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            para.AppendText("Execution").ApplyCharacterFormat(new WCharacterFormat(doc) { Bold = true, TextColor = System.Drawing.Color.White, FontSize = 12, FontName = "Verdana" });
            groupShape.Add(shape);

            shape = new Shape(doc, AutoShapeType.DownArrow);
            shape.Width = 45;
            shape.Height = 45;
            shape.HorizontalOrigin = HorizontalOrigin.Page;
            shape.VerticalOrigin = VerticalOrigin.Page;
            shape.VerticalPosition = 347;
            //Set horizontal position
            shape.HorizontalPosition = 265;
            shape.WrapFormat.AllowOverlap = true;
            groupShape.Add(shape);

            shape = new Shape(doc, AutoShapeType.RoundedRectangle);
            shape.Width = 130;
            shape.Height = 45;
            shape.HorizontalOrigin = HorizontalOrigin.Page;
            shape.VerticalOrigin = VerticalOrigin.Page;
            shape.VerticalPosition = 392;
            //Set horizontal position
            shape.HorizontalPosition = 220;
            shape.WrapFormat.AllowOverlap = true;
            shape.FillFormat.Color = System.Drawing.Color.Violet;
            shape.TextFrame.TextVerticalAlignment = VerticalAlignment.Middle;
            para = shape.TextBody.AddParagraph();
            para.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            para.AppendText("Testing").ApplyCharacterFormat(new WCharacterFormat(doc) { Bold = true, TextColor = System.Drawing.Color.White, FontSize = 12, FontName = "Verdana" });
            groupShape.Add(shape);

            shape = new Shape(doc, AutoShapeType.DownArrow);
            shape.Width = 45;
            shape.Height = 45;
            shape.HorizontalOrigin = HorizontalOrigin.Page;
            shape.VerticalOrigin = VerticalOrigin.Page;
            shape.VerticalPosition = 437;
            //Set horizontal position
            shape.HorizontalPosition = 265;
            shape.WrapFormat.AllowOverlap = true;
            groupShape.Add(shape);
            
            shape = new Shape(doc, AutoShapeType.RoundedRectangle);
            shape.Width = 130;
            shape.Height = 45;
            shape.HorizontalOrigin = HorizontalOrigin.Page;
            shape.VerticalOrigin = VerticalOrigin.Page;
            shape.VerticalPosition = 482;
            //Set horizontal position
            shape.HorizontalPosition = 220;
            shape.WrapFormat.AllowOverlap = true;
            shape.FillFormat.Color = System.Drawing.Color.PaleVioletRed;
            shape.TextFrame.TextVerticalAlignment = VerticalAlignment.Middle;
            para = shape.TextBody.AddParagraph();
            para.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            para.AppendText("Release").ApplyCharacterFormat(new WCharacterFormat(doc) { Bold = true, TextColor = System.Drawing.Color.White, FontSize = 12, FontName = "Verdana" });
            groupShape.Add(shape);
            doc.LastParagraph.ChildEntities.Add(groupShape);

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
