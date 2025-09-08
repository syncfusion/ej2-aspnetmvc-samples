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

namespace EJ2MVCSampleBrowser.Controllers.Word
{
    public partial class WordController : Controller
    {
        #region TableOfFigures
        public ActionResult TableOfFigures(string Group1, string Button, string ExcludeLabelsAndNumbers)
        {
            if (Group1 == null)
                return View();
            if (Button == "View Template")
                return new TemplateResult("TableOfFiguresInput.docx", ResolveApplicationDataPath("Data\\Word"), HttpContext.ApplicationInstance.Response);

            //Open an existing word document.
            WordDocument document = new WordDocument(ResolveApplicationDataPath("TableOfFiguresInput.docx", "Data\\Word"));
            #region Add Table of Figures
            //Create a new paragraph.
            WParagraph paragraph = new WParagraph(document);
            paragraph.AppendText("List of Figures");
            //Apply Heading1 style for paragraph.
            paragraph.ApplyStyle(BuiltinStyle.Heading1);
            //Insert the paragraph. 
            document.LastSection.Body.ChildEntities.Insert(0, paragraph);

            //Create new paragraph and append TOC.
            paragraph = new WParagraph(document);
            TableOfContent tableOfContent = paragraph.AppendTOC(1, 3);
            //Disable a flag to exclude heading style paragraphs in TOC entries.
            tableOfContent.UseHeadingStyles = false;
            //Set the name of SEQ field identifier for table of figures.
            tableOfContent.TableOfFiguresLabel = "Figure";
            if (ExcludeLabelsAndNumbers == "ExcludeLabelsAndNumbers")
                //Disable the flag, to exclude caption's label and number in TOC entries.
                tableOfContent.IncludeCaptionLabelsAndNumbers = false;

            //Insert the paragraph to the text body.
            document.LastSection.Body.ChildEntities.Insert(1, paragraph);
            #endregion

            #region Add caption for pictures
            //Find all pictures from the document.
            List<Entity> pictures = document.FindAllItemsByProperty(EntityType.Picture, null, null);
            // Iterate each picture and add caption.
            foreach (WPicture picture in pictures)
            {
                //Set alternate text as caption for picture.
                WParagraph captionPara = picture.AddCaption("Figure", CaptionNumberingFormat.Number, CaptionPosition.AfterImage) as WParagraph;
                captionPara.AppendText(" " + picture.AlternativeText);
                //Apply formatting to the caption.
                captionPara.ApplyStyle(BuiltinStyle.Caption);
                captionPara.ParagraphFormat.BeforeSpacing = 8;
                captionPara.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;
            }
            #endregion


            #region Add Table of Tables
            // Create a new paragraph.
            paragraph = new WParagraph(document);
            paragraph.AppendText("List of Tables");
            // Apply Heading1 style for paragraph.
            paragraph.ApplyStyle(BuiltinStyle.Heading1);
            // Insert the paragraph.
            document.LastSection.Body.ChildEntities.Insert(2, paragraph);

            //Create a new paragraph and append TOC.
            paragraph = new WParagraph(document);
            tableOfContent = paragraph.AppendTOC(1, 3);
            //Disable a flag to exclude heading style paragraphs in TOC entries.
            tableOfContent.UseHeadingStyles = false;
            //Set the name of SEQ field identifier for table of tables.
            tableOfContent.TableOfFiguresLabel = "Table";
            if (ExcludeLabelsAndNumbers == "ExcludeLabelsAndNumbers")
                //Disable the flag, to exclude caption's label and number in TOC entries.
                tableOfContent.IncludeCaptionLabelsAndNumbers = false;
            // Insert the paragraph to the text body.
            document.LastSection.Body.ChildEntities.Insert(3, paragraph);
            #endregion

            #region Add caption for tables
            // Find all tables from the document.
            List<Entity> tables = document.FindAllItemsByProperty(EntityType.Table, null, null);
            //Iterate each table and add caption.
            foreach (WTable table in tables)
            {
                //Gets the table index.
                int tableIndex = table.OwnerTextBody.ChildEntities.IndexOf(table);
                //Create a new paragraph and appends the sequence field to use as a caption.
                WParagraph captionPara = new WParagraph(document);
                captionPara.AppendText("Table ");
                captionPara.AppendField("Table", FieldType.FieldSequence);
                //Set alternate text as caption for table.
                captionPara.AppendText(" " + table.Description);
                // Apply formatting to the paragraph.
                captionPara.ApplyStyle(BuiltinStyle.Caption);
                captionPara.ParagraphFormat.BeforeSpacing = 8;
                captionPara.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;
                //Insert the paragraph next to the table.
                table.OwnerTextBody.ChildEntities.Insert(tableIndex + 1, captionPara);
            }
            #endregion

            #region Update
            //Update all document fields to update SEQ fields.
            document.UpdateDocumentFields();
            //Update the table of contents.
            document.UpdateTableOfContents();
            #endregion

            #region Document SaveOption
            //Save as .doc format
            if (Group1 == "WordDoc")
            {
                return document.ExportAsActionResult("TableOfFigures.doc", FormatType.Doc, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            // Saves as .docx format.
            else if (Group1 == "WordDocx")
            {
                return document.ExportAsActionResult("TableOfFigures.docx", FormatType.Docx, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            // Saves as WordML(.xml) format.
            else if (Group1 == "WordML")
            {
                return document.ExportAsActionResult("TableOfFigures.xml", FormatType.WordML, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            //Saves as .pdf format.
            else if (Group1 == "Pdf")
            {
                DocToPDFConverter converter = new DocToPDFConverter();
                PdfDocument pdfDoc = converter.ConvertToPDF(document);
                converter.Dispose();
                return pdfDoc.ExportAsActionResult("TableOfFigures.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }
            #endregion

            return View();
        }
        #endregion TableOfFigures
    }
}