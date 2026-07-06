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
        public ActionResult QuickFormatToolbar()
        {
            ViewData["Text"] = new[] {
                "Formats", "|", "Bold", "Italic", "Fontcolor", "BackgroundColor", "|", "CreateLink", "Image", "CreateTable", "Blockquote", "|", "Unorderedlist", "Orderedlist", "Indent", "Outdent"
            };
            return View();
        }
    }
}
