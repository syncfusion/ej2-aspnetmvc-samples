#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class RichTextEditorController : Controller
    {
        public ActionResult IFrame()
        {
            ViewData["Items"] = new[] {"Undo", "Redo", "|", "ImportWord", "ExportWord", "ExportPdf", "|",
                "Bold", "Italic", "Underline", "StrikeThrough", "InlineCode", "|", "CreateLink", "Image", "CreateTable", "CodeBlock",
                "HorizontalLine", "Blockquote", "|", "BulletFormatList", "NumberFormatList", "Checklist", "|", "Formats", "Alignments", "|", "Outdent", "Indent", "|",
                "FontColor", "BackgroundColor", "FontName", "FontSize", "|", "LowerCase", "UpperCase", "|", "SuperScript", "SubScript", "|",
                "EmojiPicker", "FileManager", "Video", "Audio", "|", "FormatPainter", "ClearFormat",
                "|", "Print", "FullScreen", "|", "SourceCode"};
            string hostUrl = "https://ej2-aspcore-service.azurewebsites.net/";
            ViewData["AjaxSettings"] = new
            {
                url = hostUrl + "api/FileManager/FileOperations",
                getImageUrl = hostUrl + "api/FileManager/GetImage",
                uploadUrl = hostUrl + "api/FileManager/Upload",
                downloadUrl = hostUrl + "api/FileManager/Download"
            };
            ViewData["Text"] = new[] {
                "Formats", "|", "Bold", "Italic", "Fontcolor", "BackgroundColor", "|", "CreateLink", "Image", "CreateTable", "Blockquote", "|", "Unorderedlist", "Orderedlist", "Indent", "Outdent"
            };
            ViewData["Table"] = new[] {
                "Tableheader", "TableRemove", "|", "TableRows", "TableColumns", "TableCell", "|" , "TableEditProperties", "Styles", "BackgroundColor", "Alignments", "TableCellVerticalAlign"
            };
            ViewData["ExportWord"] = new Syncfusion.EJ2.RichTextEditor.RichTextEditorExportWord
            {
                ServiceUrl = "https://services.syncfusion.com/aspnet/production/api/RichTextEditor/ExportToDocx",
                FileName = "RichTextEditor.docx",
                Stylesheet = ".e-rte-content{ font-size: 1em; font-weight: 400; margin: 0; }"
            };

            ViewData["ExportPdf"] = new Syncfusion.EJ2.RichTextEditor.RichTextEditorExportPdf
            {
                ServiceUrl = "https://services.syncfusion.com/aspnet/production/api/RichTextEditor/ExportToPdf",
                FileName = "RichTextEditor.pdf",
                Stylesheet = ".e-rte-content{ font-size: 1em; font-weight: 400; margin: 0; }"
            };
            ViewData["ImportWord"] = new Syncfusion.EJ2.RichTextEditor.RichTextEditorImportWord
            {
                ServiceUrl = "https://services.syncfusion.com/aspnet/production/api/RichTextEditor/ImportFromWord",
            };
            return View();
        }
    }
}
