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
        public ActionResult Inline()
        {
            ViewData["Items"] = new[] { "Formats", "|", "Bold", "Italic", "Fontcolor", "BackgroundColor", "|", "CreateLink", "Image", "CreateTable", "|", "Unorderedlist", "Orderedlist" };
            ViewData["Width"] = new
            {
                width = "auto"
            };
            ViewData["Inline"] = new
            {
                enable = true,
                onSelection = true
            };
            return View();
        }
    }
}