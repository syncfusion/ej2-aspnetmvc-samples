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
        public ActionResult InsertMedia()
        {
            string hostUrl = "https://services.syncfusion.com/aspnet/production/";
            ViewData["Items"] = new[] { "Bold", "Italic", "Underline", "|", "Formats", "Alignments", "Blockquote", "OrderedList", "UnorderedList", "|", "CreateLink", "Image", "Audio", "Video", "|", "SourceCode", "Undo", "Redo" };
            ViewData["InsertAudioSettings"] = new Syncfusion.EJ2.RichTextEditor.RichTextEditorAudioSettings
            {
                SaveUrl = hostUrl + "api/RichTextEditor/SaveFile",
                RemoveUrl = hostUrl + "api/RichTextEditor/DeleteFile",
                Path = hostUrl + "RichTextEditor/"
            };
            ViewData["InsertVideoSettings"] = new Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings
            {
                SaveUrl = hostUrl + "api/RichTextEditor/SaveFile",
                RemoveUrl = hostUrl + "api/RichTextEditor/DeleteFile",
                Path = hostUrl + "RichTextEditor/"
            };

            return View();
        }
    }
}
