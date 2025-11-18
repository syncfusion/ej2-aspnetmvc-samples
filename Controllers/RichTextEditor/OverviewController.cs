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
        public ActionResult Overview()
        {
            ViewData["RTEValue"] = "<h2>Welcome to the Syncfusion Rich Text Editor</h2><p>The Rich Text Editor, a WYSIWYG (what you see is what you get) editor, is a user interface that allows you to create, edit, and format rich text content. You can try out a demo of this editor here.</p><h3>Do you know the key features of the editor?</h3><ul> <li>Basic features include headings, block quotes, numbered lists, bullet lists, and support to insert images, tables, audio, and video.</li> <li>Inline styles include <b>bold</b>, <em>italic</em>, <span style=\"text-decoration: underline\">underline</span>, <span style=\"text-decoration: line-through\">strikethrough</span>, <a class=\"e-rte-anchor\" href=\"https://ej2.syncfusion.com/aspnetmvc/richtexteditor/overview#/material3\" title=\"https://ej2.syncfusion.com/aspnetmvc/richtexteditor/overview#/material3\">hyperlinks</a>,<code>InlineCode</code>, 😀 and more.</li> <li>The toolbar has multi-row, expandable, and scrollable modes. The Editor supports an inline toolbar, a floating toolbar, and custom toolbar items.</li> <li>Integration with Syncfusion Mention control lets users tag other users. To learn more, check out the <a class=\"e-rte-anchor\" href=\"https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/mention-integration\" title=\"Mention Documentation\">documentation</a> and <a class=\"e-rte-anchor\" href=\"https://ej2.syncfusion.com/aspnetmvc/richtexteditor/mentionintegration#/material3\" title=\"Mention Demos\">demos</a>.</li> <li><b>Paste from MS Word</b> - helps to reduce the effort while converting the Microsoft Word content to HTML format with format and styles. To learn more, check out the documentation <a class=\"e-rte-anchor\" href=\"https://ej2.syncfusion.com/documentation/rich-text-editor/paste-cleanup\" title=\"Paste from MS Word Documentation\">here</a>.</li> <li>Other features: placeholder text, character count, form validation, enter key configuration, resizable editor, IFrame rendering, tooltip, source code view, RTL mode, persistence, HTML Sanitizer, autosave, and <a class=\"e-rte-anchor\" href=\"https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.richtexteditor.richtexteditor.html\" title=\"Rich Text Editor API\">more</a>.</li></ul><blockquote><p><em>Easily access Audio, Image, Link, Video, and Table operations through the quick toolbar by right-clicking on the corresponding element with your mouse.</em></p></blockquote><h3>Unlock the Power of Tables</h3><p>A table can be created in the editor using either a keyboard shortcut or the toolbar. With the quick toolbar, you can perform table cell insert, delete, split, and merge operations. You can style the table cells using background colours and borders.</p><table class=\"e-rte-table\" style=\"width: 100%; min-width: 0px; height: 151px\"> <thead style=\"height: 16.5563%\"> <tr style=\"height: 16.5563%\"> <th style=\"width: 12.1813%\"><span>S No</span><br></th> <th style=\"width: 23.2295%\"><span>Name</span><br></th> <th style=\"width: 9.91501%\"><span>Age</span><br></th> <th style=\"width: 15.5807%\"><span>Gender</span><br></th> <th style=\"width: 17.9887%\"><span>Occupation</span><br></th> <th style=\"width: 21.1048%\">Mode of Transport</th> </tr> </thead> <tbody> <tr style=\"height: 16.5563%\"> <td style=\"width: 12.1813%\">1</td> <td style=\"width: 23.2295%\">Selma Rose</td> <td style=\"width: 9.91501%\">30</td> <td style=\"width: 15.5807%\">Female</td> <td style=\"width: 17.9887%\"><span>Engineer</span><br></td> <td style=\"width: 21.1048%\"><span style=\"font-size: 14pt\">🚴</span></td> </tr> <tr style=\"height: 16.5563%\"> <td style=\"width: 12.1813%\">2</td> <td style=\"width: 23.2295%\"><span>Robert</span><br></td> <td style=\"width: 9.91501%\">28</td> <td style=\"width: 15.5807%\">Male</td> <td style=\"width: 17.9887%\"><span>Graphic Designer</span></td> <td style=\"width: 21.1048%\"><span style=\"font-size: 14pt\">🚗</span></td> </tr> <tr style=\"height: 16.5563%\"> <td style=\"width: 12.1813%\">3</td> <td style=\"width: 23.2295%\"><span>William</span><br></td> <td style=\"width: 9.91501%\">35</td> <td style=\"width: 15.5807%\">Male</td> <td style=\"width: 17.9887%\">Teacher</td> <td style=\"width: 21.1048%\"><span style=\"font-size: 14pt\">🚗</span></td> </tr> <tr style=\"height: 16.5563%\"> <td style=\"width: 12.1813%\">4</td> <td style=\"width: 23.2295%\"><span>Laura Grace</span><br></td> <td style=\"width: 9.91501%\">42</td> <td style=\"width: 15.5807%\">Female</td> <td style=\"width: 17.9887%\">Doctor</td> <td style=\"width: 21.1048%\"><span style=\"font-size: 14pt\">🚌</span></td> </tr> <tr style=\"height: 16.5563%\"> <td style=\"width: 12.1813%\">5</td><td style=\"width: 23.2295%\"><span>Andrew James</span><br></td><td style=\"width: 9.91501%\">45</td><td style=\"width: 15.5807%\">Male</td><td style=\"width: 17.9887%\">Lawyer</td><td style=\"width: 21.1048%\"><span style=\"font-size: 14pt\">🚕</span></td></tr></tbody></table><h3>Elevating Your Content with Images</h3><p>Images can be added to the editor by pasting or dragging into the editing area, using the toolbar to insert one as a URL, or uploading directly from the File Browser. Easily manage your images on the server by configuring the <a class=\"e-rte-anchor\" href=\"https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/image\" title=\"Insert Image Settings API\">InsertImageSettings</a> to upload, save, or remove them. </p><p>The Editor can integrate with the Syncfusion Image Editor to crop, rotate, annotate, and apply filters to images. Check out the demos <a class=\"e-rte-anchor\" href=\"https://ej2.syncfusion.com/aspnetmvc/richtexteditor/overview#/material3\" title=\"Image Editor Demo\">here</a>.</p><p><img alt=\"Sky with sun\" src=\"https://cdn.syncfusion.com/ej2/richtexteditor-resources/RTE-Overview.png\" style=\"width: 440px\" class=\"e-rte-image e-imginline\"></p>";
            ViewData["Tools"] = new object[]  { "Undo", "Redo", "|", "ImportWord", "ExportWord", "ExportPdf", "|",
                "Bold", "Italic", "Underline", "StrikeThrough", "InlineCode", "|", "CreateLink", "Image", "CreateTable", "CodeBlock",
                "HorizontalLine", "Blockquote", "|", "BulletFormatList", "NumberFormatList", "Checklist", "|", "Formats", "Alignments", "|", "Outdent", "Indent", "|",
                "FontColor", "BackgroundColor", "FontName", "FontSize", "|", "LowerCase", "UpperCase", "|", "SuperScript", "SubScript", "|",
                "EmojiPicker", "FileManager", "Video", "Audio", "|", "FormatPainter", "ClearFormat",
                "|", "Print", "FullScreen", "|", "SourceCode"};
            string hostUrl = "https://services.syncfusion.com/aspnet/production/";
            ViewData["AjaxSettings"] = new
            {
                url = "https://ej2-aspcore-service.azurewebsites.net/api/FileManager/FileOperations",
                getImageUrl = "https://ej2-aspcore-service.azurewebsites.net/api/FileManager/GetImage",
                uploadUrl = "https://ej2-aspcore-service.azurewebsites.net/api/FileManager/Upload",
                downloadUrl = "https://ej2-aspcore-service.azurewebsites.net/api/FileManager/Download"
            };
            ViewData["InsertImageSettings"] = new Syncfusion.EJ2.RichTextEditor.RichTextEditorImageSettings
            {
                SaveUrl = hostUrl + "api/RichTextEditor/SaveFile",
                RemoveUrl = hostUrl + "api/RichTextEditor/DeleteFile",
                Path = hostUrl + "RichTextEditor/"
            };
            ViewData["Text"] = new[] {
                "Formats", "|", "Bold", "Italic", "Fontcolor", "BackgroundColor", "|", "CreateLink", "Image", "CreateTable", "Blockquote", "|", "Unorderedlist", "Orderedlist", "Indent", "Outdent"
            };
            ViewData["Table"] = new[] {
                "Tableheader", "TableRemove", "|", "TableRows", "TableColumns", "TableCell", "|" , "TableEditProperties", "Styles", "BackgroundColor", "Alignments", "TableCellVerticalAlign"
            };
            ViewData["EmailData"] = new EmailDatas().EmailList();
            ViewData["ImportWord"] = new Syncfusion.EJ2.RichTextEditor.RichTextEditorImportWord
            {
                ServiceUrl = hostUrl + "api/RichTextEditor/ImportFromWord",
            };
            ViewData["ExportWord"] = new Syncfusion.EJ2.RichTextEditor.RichTextEditorExportWord
            {
                ServiceUrl = hostUrl + "api/RichTextEditor/ExportToDocx",
                FileName = "RichTextEditor.docx",
                Stylesheet = ".e-rte-content{ font-size: 1em; font-weight: 400; margin: 0; }"
            };

            ViewData["ExportPdf"] = new Syncfusion.EJ2.RichTextEditor.RichTextEditorExportPdf
            {
                ServiceUrl = hostUrl + "api/RichTextEditor/ExportToPdf",
                FileName = "RichTextEditor.pdf",
                Stylesheet = ".e-rte-content{ font-size: 1em; font-weight: 400; margin: 0; }"
            };
            ViewData["SlashMenuSettings"] = new Syncfusion.EJ2.RichTextEditor.RichTextEditorSlashMenuSettings
            {
                Enable = true,
                Items = new object[] { "Paragraph", "Heading 1", "Heading 2", "Heading 3", "Heading 4", "OrderedList", "UnorderedList",
            "CodeBlock", "Blockquote", "Link", "Image", "Video", "Audio", "Table", "Emojipicker"
                }
            };
            return View();
        }
    }
}
