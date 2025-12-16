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
            ViewData["RTEValue"] = "<h2>Welcome to the Syncfusion<sup>®</sup> Rich Text Editor</h2><p>The Rich Text Editor, a WYSIWYG (what you see is what you get) editor, is a user interface that allows you to create, edit, and format rich text content. You can try out a demo of this editor here.</p><h3>Do you know the key features of the editor?</h3><ul><li>Basic features include headings, block quotes, numbered lists, bullet lists, and support to insert images, tables, audio, and video.</li><li>Inline styles include <b>bold</b>, <em>italic</em>, <span style=\"text-decoration: underline\">underline</span>, <span style=\"text-decoration: line-through\">strikethrough</span>, <a href=\"https://ej2.syncfusion.com/demos/#/material/rich-text-editor/tools.html\">hyperlinks</a>, <code>InlineCode</code>, 😀 and more.</li><li>The toolbar has multi-row, expandable, and scrollable modes. The Editor supports an inline toolbar, a floating toolbar, and custom toolbar items.</li><li>Integration with Syncfusion<sup>®</sup> Mention control lets users tag other users. To learn more, check out the <a href=\"https://ej2.syncfusion.com/documentation/rich-text-editor/mention-integration\">documentation</a> and <a href=\"https://ej2.syncfusion.com/demos/#/material/rich-text-editor/mention-integration.html\">demos</a>.</li><li><b>Paste from MS Word</b> - helps to reduce the effort while converting the Microsoft Word content to HTML format with format and styles. To learn more, check out the documentation <a href=\"https://ej2.syncfusion.com/documentation/rich-text-editor/paste-cleanup\">here</a>.</li><li>Other features: placeholder text, character count, form validation, enter key configuration, resizable editor, IFrame rendering, tooltip, source code view, RTL mode, persistence, HTML Sanitizer, autosave, and <a href=\"https://ej2.syncfusion.com/documentation/api/rich-text-editor/\">more</a>.</li></ul><h3>Auto Formatting – Write Faster, Format Smarter</h3><p>Boost your productivity with Auto Formatting, a powerful feature that lets you style content instantly using simple, familiar Markdown-style shortcuts. No need to reach for the toolbar — just type and watch your content transform in real time.</p><h4>Effortless Formatting Shortcuts</h4><table class=\"e-rte-table\"><thead><tr><th>Action</th><th>Shortcut</th></tr></thead><tbody><tr><td>Bulleted List</td><td>Start a line with <code>*</code> or <code>-</code> followed by a space</td></tr><tr><td>Numbered List</td><td>Start a line with <code>1.</code> or <code>i.</code> followed by a space</td></tr><tr><td>Checklist / To-do</td><td>Start a line with <code>[ ]</code> or <code>[x]</code> followed by a space</td></tr><tr><td>Headings (H1 to H6)</td><td>Use <code>#</code>, <code>##</code>, <code>###</code>, <code>####</code>, <code>#####</code>, or <code>######</code> followed by a space</td></tr><tr><td>Block Quote</td><td>Start a line with <code>&gt;</code> followed by a space</td></tr><tr><td>Code Block</td><td>Start a line with <code>```</code> followed by a space</td></tr><tr><td>Horizontal Line</td><td>Start a line with <code>---</code> followed by a space</td></tr><tr><td>Bold Text</td><td>Type <code>**text**</code> or <code>__text__</code></td></tr><tr><td>Italic Text</td><td>Type <code>*text*</code> or <code>_text_</code></td></tr><tr><td>Inline Code</td><td>Type <code>`text`</code></td></tr><tr><td>Strikethrough</td><td>Type <code>~~text~~</code></td></tr></tbody></table><h3>Elevating Your Content with Images</h3><p>Images can be added to the editor by pasting or dragging into the editing area, using the toolbar to insert one as a URL, or uploading directly from the File Browser. Easily manage your images on the server by configuring the <a href=\"https://ej2.syncfusion.com/documentation/api/rich-text-editor/#insertimagesettings\">insertImageSettings</a> to upload, save, or remove them.</p><p>The Editor can integrate with the Syncfusion<sup>®</sup> Image Editor to crop, rotate, annotate, and apply filters to images. Check out the demos <a href=\"https://ej2.syncfusion.com/demos/#/material/rich-text-editor/image-editor-integration.html\">here</a>.</p><p><img src=\"https://cdn.syncfusion.com/ej2/richtexteditor-resources/RTE-Overview.png\" alt=\"Sky with sun\" style=\"width:440px;\"></p><blockquote><p><em>Easily access Audio, Image, Link, Video, and Table operations through the quick toolbar by right-clicking on the corresponding element with your mouse.</em></p></blockquote>";
            ViewData["Tools"] = new object[]  { "Undo", "Redo", "|", "ImportWord", "ExportWord", "ExportPdf", "|",
                "Bold", "Italic", "Underline", "StrikeThrough", "InlineCode", "|", "CreateLink", "Image", "CreateTable", "CodeBlock",
                "HorizontalLine", "Blockquote", "|", "LineHeight", "Formats", "Alignments", "|", "BulletFormatList", "NumberFormatList", "Checklist", "|", "Outdent", "Indent", "|",
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
