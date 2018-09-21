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

namespace EJ2MVCSampleBrowser.Controllers.DocIO
{
    public partial class DocIOController : Controller
    {
        #region InsertBreak
        public ActionResult InsertBreak(string Group1)
        {
            if (Group1 == null)
                return View();

            //Creating a new document
            WordDocument document = new WordDocument();
            //Adding a new section.
            IWSection section = document.AddSection();
            IWParagraph paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            section.PageSetup.Margins.All = 20f;
            IWTextRange text = paragraph.AppendText("Adventure products");
            //Formatting Text
            text.CharacterFormat.FontName = "Bitstream Vera Sans";
            text.CharacterFormat.FontSize = 12f;
            text.CharacterFormat.Bold = true;
            section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.LineSpacing = 20f;
            paragraph.AppendText("In 2000, Adventure Works Cycles bought a small manufacturing plant, Importadores Neptuno, located in Mexico. Importadores Neptuno manufactures several critical subcomponents for the Adventure Works Cycles product line. These subcomponents are shipped to the Bothell location for final product assembly. In 2001, Importadores Neptuno, became the sole manufacturer and distributor of the touring bicycle product group ");
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Justify;

            #region Line break
            paragraph.AppendBreak(BreakType.LineBreak);
            paragraph.AppendBreak(BreakType.LineBreak);
            #endregion Line break

            section = document.AddSection();

            section.BreakCode = SectionBreakCode.NoBreak;
            section.PageSetup.Margins.All = 20f;
            //Adding three columns to section.
            section.AddColumn(100, 15);
            section.AddColumn(100, 15);
            section.AddColumn(100, 15);
            //Set the columns to be of equal width.
            section.MakeColumnsEqual();

            //Adding a new paragraph to the section.
            paragraph = section.AddParagraph();
            //Adding text.
            text = paragraph.AppendText("Mountain-200");
            //Formatting Text
            text.CharacterFormat.FontName = "Bitstream Vera Sans";
            text.CharacterFormat.FontSize = 12f;
            text.CharacterFormat.Bold = true;
            //Adding a new paragraph to the section.
            section.AddParagraph();
            paragraph = section.AddParagraph();
            //Inserting an Image.
            WPicture picture = paragraph.AppendPicture(new Bitmap(ResolveApplicationDataPath("Mountain-200.jpg", "Images\\DocIO"))) as WPicture;
            picture.Width = 120f;
            picture.Height = 90f;
            //Adding a new paragraph to the section.
            section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.LineSpacing = 20f;
            //Adding text.            
            paragraph.AppendText(@"Product No:BK-M68B-38" + "\n" + "Size: 38" + "\n" + "Weight: 25\n" + "Price: $2,294.99");
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Justify;

            // Set column break as true. It navigates the cursor position to the next Column.
            paragraph.ParagraphFormat.ColumnBreakAfter = true;

            paragraph = section.AddParagraph();
            text = paragraph.AppendText("Mountain-300");
            text.CharacterFormat.FontName = "Bitstream Vera Sans";
            text.CharacterFormat.FontSize = 12f;
            text.CharacterFormat.Bold = true;

            section.AddParagraph();
            paragraph = section.AddParagraph();
            picture = paragraph.AppendPicture(new Bitmap(ResolveApplicationDataPath("Mountain-300.jpg", "Images\\DocIO"))) as WPicture;
            picture.Width = 120f;
            picture.Height = 90f;
            section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.LineSpacing = 20f;
            paragraph.AppendText(@"Product No:BK-M4-38" + "\n" + "Size: 35\n" + "Weight: 22" + "\n" + "Price: $1,079.99");
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Justify;

            paragraph.ParagraphFormat.ColumnBreakAfter = true;

            paragraph = section.AddParagraph();
            text = paragraph.AppendText("Road-150");
            text.CharacterFormat.FontName = "Bitstream Vera Sans";
            text.CharacterFormat.FontSize = 12f;
            text.CharacterFormat.Bold = true;

            section.AddParagraph();
            paragraph = section.AddParagraph();
            picture = paragraph.AppendPicture(new Bitmap(ResolveApplicationDataPath("Road-550-W.jpg", "Images\\DocIO"))) as WPicture;
            picture.Width = 120f;
            picture.Height = 90f;
            section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.LineSpacing = 20f;
            paragraph.AppendText(@"Product No: BK-R93R-44" + "\n" + "Size: 44" + "\n" + "Weight: 14" + "\n" + "Price: $3,578.27");
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Justify;

            section = document.AddSection();
            section.BreakCode = SectionBreakCode.NoBreak;
            section.PageSetup.Margins.All = 20f;

            text = section.AddParagraph().AppendText("First Look\n");
            //Formatting Text
            text.CharacterFormat.FontName = "Bitstream Vera Sans";
            text.CharacterFormat.FontSize = 12f;
            text.CharacterFormat.Bold = true;

            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.LineSpacing = 20f;
            paragraph.AppendText(@"Adventure Works Cycles, the fictitious company, is a large, multinational manufacturing company. The company manufactures and sells metal and composite bicycles to North American, European and Asian commercial markets. While its base operation is located in Bothell, Washington with 290 employees, several regional sales teams are located throughout their market base.");
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Justify;
            paragraph.ParagraphFormat.PageBreakAfter = true;

            paragraph = section.AddParagraph();
            text = paragraph.AppendText("Introduction\n");
            //Formatting Text
            text.CharacterFormat.FontName = "Bitstream Vera Sans";
            text.CharacterFormat.FontSize = 12f;
            text.CharacterFormat.Bold = true;
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.LineSpacing = 20f;
            paragraph.AppendText(@"In 2000, Adventure Works Cycles bought a small manufacturing plant, Importadores Neptuno, located in Mexico. Importadores Neptuno manufactures several critical subcomponents for the Adventure Works Cycles product line. These subcomponents are shipped to the Bothell location for final product assembly. In 2001, Importadores Neptuno, became the sole manufacturer and distributor of the touring bicycle product group.");
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Justify;

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
        #endregion InsertBreak
    }
}