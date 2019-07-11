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
            ViewBag.items = new[] { "Bold", "Italic", "Underline",
                "Formats", "-", "Alignments", "OrderedList", "UnorderedList",
                "CreateLink" };
            ViewBag.value = @"<p>The sample is configured with inline mode of editor. Initially, the editor is rendered without a 
                            <a href='https://ej2.syncfusion.com/home/'>toolbar</a>. 
                            The toolbar becomes visible only when the content is selected.</p>";
            return View();
        }
    }
}
