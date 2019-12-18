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
        // GET: /<controller>/
        public ActionResult Types()
        {
            List<Data> datasource = new List<Data>();
            datasource.Add(new Data() { text = "Expand", value = 1 });
            datasource.Add(new Data() { text = "Multi Row", value = 2 });
            ViewBag.Data = datasource;
            ViewBag.Items = new[] {"Bold", "Italic", "Underline", "StrikeThrough",
                "FontName", "FontSize", "FontColor", "BackgroundColor",
                "LowerCase", "UpperCase", "|",
                "Formats", "Alignments", "OrderedList", "UnorderedList",
                "Outdent", "Indent", "|",
                "CreateLink", "Image", "|", "ClearFormat", "Print",
                "SourceCode", "FullScreen", "|", "Undo", "Redo" };
            return View();
        }
    }
}
