#region Copyright
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
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
        public ActionResult BookmarkNavigation(string Group1,string Button)
        {
            if (Group1 == null)
                return View();
            if (Button == null)
                return View();

            if (Button == "View Template")
                return new TemplateResult("Bookmark_Template.docx", ResolveApplicationDataPath("Data\\Word"), HttpContext.ApplicationInstance.Response);
            #region BookmarkNavigation
            // Creating a new document.
            WordDocument document = new WordDocument();
            //Adds section with one empty paragraph to the Word document
            document.EnsureMinimal();
            //sets the page margins
            document.LastSection.PageSetup.Margins.All = 72f;
            //Appends bookmark to the paragraph
            document.LastParagraph.AppendBookmarkStart("NorthwindDatabase");
            document.LastParagraph.AppendText("Northwind database with normalization concept");
            document.LastParagraph.AppendBookmarkEnd("NorthwindDatabase");
            // Open an existing template document with single section to get Northwind.information
            WordDocument nwdInformation = new WordDocument(ResolveApplicationDataPath("Bookmark_Template.docx", "Data\\Word"));
            // Open an existing template document with multiple section to get Northwind data.
            WordDocument templateDocument = new WordDocument(ResolveApplicationDataPath("BkmkDocumentPart_Template.docx", "Data\\Word"));
            // Creating a bookmark navigator. Which help us to navigate through the 
            // bookmarks in the template document.
            BookmarksNavigator bk = new BookmarksNavigator(templateDocument);
            // Move to the NorthWind bookmark in template document
            bk.MoveToBookmark("NorthWind");
            //Gets the bookmark content as WordDocumentPart
            WordDocumentPart documentPart = bk.GetContent();
            // Creating a bookmark navigator. Which help us to navigate through the 
            // bookmarks in the Northwind information document.
            bk = new BookmarksNavigator(nwdInformation);
            // Move to the information bookmark 
            bk.MoveToBookmark("Information");
            // Get the content of information bookmark.
            TextBodyPart bodyPart = bk.GetBookmarkContent();
            // Creating a bookmark navigator. Which help us to navigate through the 
            // bookmarks in the destination document.
            bk = new BookmarksNavigator(document);
            // Move to the NorthWind database in the destination document
            bk.MoveToBookmark("NorthwindDatabase");
            //Replace the bookmark content using word document parts
            bk.ReplaceContent(documentPart);
            // Move to the Northwind_Information in the destination document
            bk.MoveToBookmark("Northwind_Information");
            // Replacing content of Northwind_Information bookmark.
            bk.ReplaceBookmarkContent(bodyPart);
            #region Bookmark selection for table
            // Creating a bookmark navigator. Which help us to navigate through the 
            // bookmarks in the Northwind information document.
            bk = new BookmarksNavigator(nwdInformation);
            bk.MoveToBookmark("SuppliersTable");
            //Sets the column index where the bookmark starts within the table
              bk.CurrentBookmark.FirstColumn = 1;
            //Sets the column index where the bookmark ends within the table
            bk.CurrentBookmark.LastColumn = 5;
            //// Get the content of suppliers table bookmark.
            bodyPart = bk.GetBookmarkContent();
            // Creating a bookmark navigator. Which help us to navigate through the 
            // bookmarks in the destination document.
            bk = new BookmarksNavigator(document);
            bk.MoveToBookmark("Table");
            bk.ReplaceBookmarkContent(bodyPart);
            #endregion
            // Move to the text bookmark
            bk.MoveToBookmark("Text");
            //Deletes the bookmark content
            bk.DeleteBookmarkContent(true);
            // Inserting text inside the bookmark. This will preserve the source formatting
            bk.InsertText("Northwind Database contains the following table:");
            #region tableinsertion
            WTable tbl = new WTable(document);
            tbl.TableFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.None;
            tbl.TableFormat.IsAutoResized = true;
            tbl.ResetCells(8, 2);
            IWParagraph paragraph;
            tbl.Rows[0].IsHeader = true;
            paragraph = tbl[0, 0].AddParagraph();
            paragraph.AppendText("Suppliers");
            paragraph.BreakCharacterFormat.FontName = "Calibri";
            paragraph.BreakCharacterFormat.FontSize = 10;

            paragraph = tbl[0, 1].AddParagraph();
            paragraph.AppendText("1");
            paragraph.BreakCharacterFormat.FontName = "Calibri";
            paragraph.BreakCharacterFormat.FontSize = 10;

            paragraph = tbl[1, 0].AddParagraph();
            paragraph.AppendText("Customers");
            paragraph.BreakCharacterFormat.FontName = "Calibri";
            paragraph.BreakCharacterFormat.FontSize = 10;

            paragraph = tbl[1, 1].AddParagraph();
            paragraph.AppendText("1");
            paragraph.BreakCharacterFormat.FontName = "Calibri";
            paragraph.BreakCharacterFormat.FontSize = 10;

            paragraph = tbl[2, 0].AddParagraph();
            paragraph.AppendText("Employees");
            paragraph.BreakCharacterFormat.FontName = "Calibri";
            paragraph.BreakCharacterFormat.FontSize = 10;

            paragraph = tbl[2, 1].AddParagraph();
            paragraph.AppendText("3");
            paragraph.BreakCharacterFormat.FontName = "Calibri";
            paragraph.BreakCharacterFormat.FontSize = 10;

            paragraph = tbl[3, 0].AddParagraph();
            paragraph.AppendText("Products");
            paragraph.BreakCharacterFormat.FontName = "Calibri";
            paragraph.BreakCharacterFormat.FontSize = 10;

            paragraph = tbl[3, 1].AddParagraph();
            paragraph.AppendText("1");
            paragraph.BreakCharacterFormat.FontName = "Calibri";
            paragraph.BreakCharacterFormat.FontSize = 10;

            paragraph = tbl[4, 0].AddParagraph();
            paragraph.AppendText("Inventory");
            paragraph.BreakCharacterFormat.FontName = "Calibri";
            paragraph.BreakCharacterFormat.FontSize = 10;

            paragraph = tbl[4, 1].AddParagraph();
            paragraph.AppendText("2");
            paragraph.BreakCharacterFormat.FontName = "Calibri";
            paragraph.BreakCharacterFormat.FontSize = 10;

            paragraph = tbl[5, 0].AddParagraph();
            paragraph.AppendText("Shippers");
            paragraph.BreakCharacterFormat.FontName = "Calibri";
            paragraph.BreakCharacterFormat.FontSize = 10;

            paragraph = tbl[5, 1].AddParagraph();
            paragraph.AppendText("1");
            paragraph.BreakCharacterFormat.FontName = "Calibri";
            paragraph.BreakCharacterFormat.FontSize = 10;

            paragraph = tbl[6, 0].AddParagraph();
            paragraph.AppendText("PO Transactions");
            paragraph.BreakCharacterFormat.FontName = "Calibri";
            paragraph.BreakCharacterFormat.FontSize = 10;

            paragraph = tbl[6, 1].AddParagraph();
            paragraph.AppendText("3");
            paragraph.BreakCharacterFormat.FontName = "Calibri";
            paragraph.BreakCharacterFormat.FontSize = 10;

            paragraph = tbl[7, 0].AddParagraph();
            paragraph.AppendText("Sales Transactions");
            paragraph.BreakCharacterFormat.FontName = "Calibri";
            paragraph.BreakCharacterFormat.FontSize = 10;

            paragraph = tbl[7, 1].AddParagraph();
            paragraph.AppendText("7");
            paragraph.BreakCharacterFormat.FontName = "Calibri";
            paragraph.BreakCharacterFormat.FontSize = 10;

            bk.InsertTable(tbl);
            #endregion tableinsertion
            //Move to image bookmark
            bk.MoveToBookmark("Image");
            //Deletes the bookmark content
            bk.DeleteBookmarkContent(true);
            // Inserting image to the bookmark.
            IWPicture pic = bk.InsertParagraphItem(ParagraphItemType.Picture) as WPicture;
            pic.LoadImage(System.Drawing.Image.FromFile(ResolveApplicationDataPath("Northwind.png", "Images\\Word")));
            pic.WidthScale = 50f;  // It reduce the image size because it don't fit 
            pic.HeightScale = 75f; // in document page.
            #endregion BookmarkNavigation

            #region Document SaveOption
            //Save as .doc format
            if (Group1 == "WordDoc")
            {
                return document.ExportAsActionResult("Bookmark Navigation.doc", FormatType.Doc, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            //Save as .docx format
            else if (Group1 == "WordDocx")
            {
                return document.ExportAsActionResult("Bookmark Navigation.docx", FormatType.Docx, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            // Save as WordML(.xml) format
            else if (Group1 == "WordML")
            {
                return document.ExportAsActionResult("Bookmark Navigation.xml", FormatType.WordML, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            //Save as .pdf format
            else if (Group1 == "Pdf")
            {
                DocToPDFConverter converter = new DocToPDFConverter();
                PdfDocument pdfDoc = converter.ConvertToPDF(document);

                return pdfDoc.ExportAsActionResult("Bookmark Navigation.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }
            #endregion Document SaveOption
            return View();
        }
    }
}