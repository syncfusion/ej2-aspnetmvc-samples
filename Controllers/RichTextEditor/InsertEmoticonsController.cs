using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class RichTextEditorController : Controller
    {
        public ActionResult InsertEmoticons()
         {
            ViewData["Items"] = new object[] { "Bold", "Italic", "Underline", "|", "Formats", "Alignments", "Blockquote", "OrderedList",
                "UnorderedList", "|", "CreateLink", "Image", "|", "SourceCode", "EmojiPicker", "|", "Undo", "Redo"
            };
            return View();
        } 
    }
}
