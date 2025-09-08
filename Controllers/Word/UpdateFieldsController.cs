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

namespace EJ2MVCSampleBrowser.Controllers.Word
{
    public partial class WordController : Controller
    {
        #region Update Fields
        public ActionResult UpdateFields(string Group1, string Button, string UnlinkFields)
        {
            if (Group1 == null)
                return View();
            if (Button == "View Template")
                return new TemplateResult("TemplateUpdateFields.docx", ResolveApplicationDataPath("Data\\Word"), HttpContext.ApplicationInstance.Response);

            //Loads the template document.
            WordDocument document = new WordDocument(ResolveApplicationDataPath("TemplateUpdateFields.docx", "Data\\Word"));

            //Initialize DataSet object.
            DataSet ds = new DataSet();

            //Load data from the xml document.
            ds.ReadXml(ResolveApplicationDataPath("StockDetails.xml", "Data\\Word"));

            // Execute Mail Merge with groups.
            document.MailMerge.ExecuteGroup(ds.Tables["StockDetails"]);

            //Update fields in the document.
            document.UpdateDocumentFields();

            //Unlink the fields in Word document when UnlinkFields is enable.
            if (UnlinkFields == "UnlinkFields")                
                UnlinkFieldsInDocument(document);

            #region saveOption
            //Save as .doc format
            if (Group1 == "WordDoc")
            {
                return document.ExportAsActionResult("Update Fields.doc", FormatType.Doc, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            //Save as .docx format
            else if (Group1 == "WordDocx")
            {
                return document.ExportAsActionResult("Update Fields.docx", FormatType.Docx, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            // Save as WordML(.xml) format
            else if (Group1 == "WordML")
            {
                return document.ExportAsActionResult("Update Fields.xml", FormatType.WordML, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            //Save as .pdf format
            else if (Group1 == "Pdf")
            {
                DocToPDFConverter converter = new DocToPDFConverter();
                PdfDocument pdfDoc = converter.ConvertToPDF(document);

                return pdfDoc.ExportAsActionResult("Update Fields.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            } 
            #endregion saveOption
            return View();
        }

        #region Iterates into document for removing field codes.       
        /// <summary>
        /// Iterates to document elements and get fields.
        /// </summary>
        /// <param name="document">Input Word document.</param>
        /// <param name="fieldType">Type of the field to find in document.</param>
        private void UnlinkFieldsInDocument(WordDocument document)
        {
            //Iterates each section and get the tables.
            foreach (WSection section in document.Sections)
            {
                RemoveFieldCodesInTextBody(section.Body);
            }
        }

        /// <summary>
        /// Iterates into body items.
        /// </summary>
        private void RemoveFieldCodesInTextBody(WTextBody textBody)
        {
            for (int i = 0; i < textBody.ChildEntities.Count; i++)
            {
                //IEntity is the basic unit in DocIO DOM.                 
                IEntity bodyItemEntity = textBody.ChildEntities[i];

                //A Text body has 3 types of elements - Paragraph, Table, and Block Content Control
                //Decides the element type by using EntityType
                switch (bodyItemEntity.EntityType)
                {
                    case EntityType.Paragraph:
                        WParagraph paragraph = bodyItemEntity as WParagraph;
                        //Iterates into paragraph items.
                        RemoveFieldCodesInParagraph(paragraph.Items);
                        break;

                    case EntityType.Table:
                        //Table is a collection of rows and cells
                        //Iterates through table's DOM                        
                            RemoveFieldCodesInTable(bodyItemEntity as WTable);
                        break;

                    case EntityType.BlockContentControl:
                        BlockContentControl blockContentControl = bodyItemEntity as BlockContentControl;
                        //Iterates to the body items of Block Content Control.
                            RemoveFieldCodesInTextBody(blockContentControl.TextBody);
                        break;
                }
            }
        }

        /// <summary>
        /// Iterates into paragraph items.
        /// </summary>
        /// <param name="paragraph">The paragraph.</param>
        /// <param name="fieldType">Type of field.</param>
        private void RemoveFieldCodesInParagraph(ParagraphItemCollection paraItems)
        {
            for (int i = 0; i < paraItems.Count; i++)
            {
                if (paraItems[i] is WField)
                {
                    WField field = paraItems[i] as WField;
                    field.Unlink();
                }
                else if (paraItems[i] is WTextBox)
                {
                    //If paragraph item is textbox, iterates into textbody of textbox.
                    WTextBox textBox = paraItems[i] as WTextBox;
                    RemoveFieldCodesInTextBody(textBox.TextBoxBody);
                }
                else if (paraItems[i] is Shape)
                {
                    //If paragraph item is shape, iterates into textbody of shape.
                    Shape shape = paraItems[i] as Shape;
                    RemoveFieldCodesInTextBody(shape.TextBody);
                }
                else if (paraItems[i] is InlineContentControl)
                {
                    //If paragraph item is inline content control, iterates into its item.
                    InlineContentControl inlineContentControl = paraItems[i] as InlineContentControl;
                    RemoveFieldCodesInParagraph(inlineContentControl.ParagraphItems);
                }
            }
        }
        /// <summary>
        /// Iterates into table.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="fieldType">Type of Field.</param>
        private void RemoveFieldCodesInTable(WTable table)
        {
            //Iterates the row collection in a table
            foreach (WTableRow row in table.Rows)
            {
                //Iterates the cell collection in a table row
                foreach (WTableCell cell in row.Cells)
                {
                    RemoveFieldCodesInTextBody(cell);
                }
            }
        }
        #endregion


        #endregion Update Fields
    }
}