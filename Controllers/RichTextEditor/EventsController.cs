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
        public ActionResult Events()
        {
            string hostUrl = "https://services.syncfusion.com/aspnet/production/";
            ViewData["AjaxSettings"] = new
            {
                url = hostUrl + "api/RichTextEditor/FileOperations",
                getImageUrl = hostUrl + "api/RichTextEditor/GetImage",
                uploadUrl = hostUrl + "api/RichTextEditor/Upload",
                downloadUrl = hostUrl + "api/RichTextEditor/Download"
            };
            ViewData["Items"] = new[] {"Bold", "Italic", "Underline", "StrikeThrough", "SuperScript", "SubScript", "|",
                "FontName", "FontSize", "FontColor", "BackgroundColor",  "|",
                "LowerCase", "UpperCase",
                "Formats", "Alignments", "Blockquote", "|", "NumberFormatList", "BulletFormatList", "|",
                "Outdent", "Indent", "|",
                "CreateLink", "Image", "FileManager", "Video", "Audio", "CreateTable", "|", "FormatPainter", "ClearFormat", "|", "EmojiPicker", "Print", "|",
                "SourceCode", "FullScreen", "|", "Undo", "Redo"};
            return View();
        }
    }
}