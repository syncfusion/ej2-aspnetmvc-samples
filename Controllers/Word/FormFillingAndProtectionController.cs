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
        public ActionResult FormFillingAndProtection(string Button)
        {
            if (Button == null)
                return View();
            if (Button == "View Template")
                return new TemplateResult("ContentControlTemplate.docx", ResolveApplicationDataPath("Data\\Word"), HttpContext.ApplicationInstance.Response);

            //Creates an Word document instance.
            WordDocument document = new WordDocument();

            //Loads the template document.
            document.Open(ResolveApplicationDataPath("ContentControlTemplate.docx", "Data\\Word"));

            IWTextRange textRange;
            //Gets table from the template document.
            IWTable table = document.LastSection.Tables[0];
            WTableRow row = table.Rows[1];

            #region Fill data and lock the contents of content control
            #region Calendar content control
            IWParagraph cellPara = row.Cells[0].Paragraphs[0];
            //Accesses the date picker content control.
            IInlineContentControl inlineControl = (cellPara.ChildEntities[2] as IInlineContentControl);
            textRange = inlineControl.ParagraphItems[0] as WTextRange;
            //Sets today's date to display.
            textRange.Text = DateTime.Now.ToShortDateString();
            textRange.CharacterFormat.FontSize = 14;
            //Protects the content control.
            inlineControl.ContentControlProperties.LockContents = true;
            #endregion

            #region Plain text content controls
            table = document.LastSection.Tables[1];
            row = table.Rows[0];
            cellPara = row.Cells[0].LastParagraph;
            //Accesses the plain text content control.
            inlineControl = (cellPara.ChildEntities[1] as IInlineContentControl);
            //Protects the content control.
            inlineControl.ContentControlProperties.LockContents = true;
            textRange = inlineControl.ParagraphItems[0] as WTextRange;
            //Sets text in plain text content control.
            textRange.Text = "Northwind Analytics";
            textRange.CharacterFormat.FontSize = 14;

            cellPara = row.Cells[1].LastParagraph;
            //Accesses the plain text content control.
            inlineControl = (cellPara.ChildEntities[1] as IInlineContentControl);
            //Protects the content control.
            inlineControl.ContentControlProperties.LockContents = true;
            textRange = inlineControl.ParagraphItems[0] as WTextRange;
            //Sets text in plain text content control.
            textRange.Text = "Northwind";
            textRange.CharacterFormat.FontSize = 14;

            row = table.Rows[1];
            cellPara = row.Cells[0].LastParagraph;
            //Accesses the plain text content control.
            inlineControl = (cellPara.ChildEntities[1] as IInlineContentControl);
            //Protects the content control.
            inlineControl.ContentControlProperties.LockContents = true;
            //Sets text in plain text content control.
            textRange = inlineControl.ParagraphItems[0] as WTextRange;
            textRange.Text = "10";
            textRange.CharacterFormat.FontSize = 14;

            cellPara = row.Cells[1].LastParagraph;
            //Accesses the plain text content control.
            inlineControl = (cellPara.ChildEntities[1] as IInlineContentControl);
            //Protects the content control.
            inlineControl.ContentControlProperties.LockContents = true;
            //Sets text in plain text content control.
            textRange = inlineControl.ParagraphItems[0] as WTextRange;
            textRange.Text = "Nancy Davolio";
            textRange.CharacterFormat.FontSize = 14;
            #endregion

            #region CheckBox Content control
            row = table.Rows[2];
            cellPara = row.Cells[0].LastParagraph;
            //Inserts checkbox content control.
            inlineControl = cellPara.AppendInlineContentControl(ContentControlType.CheckBox);
            inlineControl.ContentControlProperties.LockContents = true;
            //Sets checkbox as checked state.
            inlineControl.ContentControlProperties.IsChecked = true;
            textRange = cellPara.AppendText("C#, ");
            textRange.CharacterFormat.FontSize = 14;

            //Inserts checkbox content control.
            inlineControl = cellPara.AppendInlineContentControl(ContentControlType.CheckBox);
            inlineControl.ContentControlProperties.LockContents = true;
            //Sets checkbox as checked state.
            inlineControl.ContentControlProperties.IsChecked = true;
            textRange = cellPara.AppendText("VB");
            textRange.CharacterFormat.FontSize = 14;
            #endregion

            #region Drop down list content control
            cellPara = row.Cells[1].LastParagraph;
            //Accesses the dropdown list content control.
            inlineControl = (cellPara.ChildEntities[1] as IInlineContentControl);
            inlineControl.ContentControlProperties.LockContents = true;
            //Sets default option to display.
            textRange = inlineControl.ParagraphItems[0] as WTextRange;
            textRange.Text = "ASP.NET";
            textRange.CharacterFormat.FontSize = 14;
            inlineControl.ParagraphItems.Add(textRange);

            //Adds items to the dropdown list.
            ContentControlListItem item;
            item = new ContentControlListItem();
            item.DisplayText = "ASP.NET MVC";
            item.Value = "2";
            inlineControl.ContentControlProperties.ContentControlListItems.Add(item);

            item = new ContentControlListItem();
            item.DisplayText = "Windows Forms";
            item.Value = "3";
            inlineControl.ContentControlProperties.ContentControlListItems.Add(item);

            item = new ContentControlListItem();
            item.DisplayText = "WPF";
            item.Value = "4";
            inlineControl.ContentControlProperties.ContentControlListItems.Add(item);

            item = new ContentControlListItem();
            item.DisplayText = "Xamarin";
            item.Value = "5";
            inlineControl.ContentControlProperties.ContentControlListItems.Add(item);
            #endregion

            #region Calendar content control
            row = table.Rows[3];
            cellPara = row.Cells[0].LastParagraph;
            //Accesses the date picker content control.
            inlineControl = (cellPara.ChildEntities[1] as IInlineContentControl);
            inlineControl.ContentControlProperties.LockContents = true;
            //Sets default date to display.
            textRange = inlineControl.ParagraphItems[0] as WTextRange;
            textRange.Text = DateTime.Now.AddDays(-5).ToShortDateString();
            textRange.CharacterFormat.FontSize = 14;

            cellPara = row.Cells[1].LastParagraph;
            //Inserts date picker content control.
            inlineControl = (cellPara.ChildEntities[1] as IInlineContentControl);
            inlineControl.ContentControlProperties.LockContents = true;
            //Sets default date to display.
            textRange = inlineControl.ParagraphItems[0] as WTextRange;
            textRange.Text = DateTime.Now.AddDays(10).ToShortDateString();
            textRange.CharacterFormat.FontSize = 14;
            #endregion

            #region Block content control
            //Accesses the block content control.
            BlockContentControl blockContentControl = ((document.ChildEntities[0] as WSection).Body.ChildEntities[2] as BlockContentControl);
            //Protects the block content control
            blockContentControl.ContentControlProperties.LockContents = true;
            #endregion
            #endregion

            return document.ExportAsActionResult("Sample.docx", FormatType.Docx, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
        }
    }
}