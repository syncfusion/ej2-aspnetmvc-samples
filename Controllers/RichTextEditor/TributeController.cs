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
        public ActionResult Tribute()
        {
            ViewBag.Items = new[] { "Bold", "Italic", "Underline", "|", "Formats", "Alignments",
                "OrderedList", "UnorderedList", "|", "CreateLink", "Image", "|", "SourceCode", "Undo", "Redo"};
            return View();
        }
    }
}
