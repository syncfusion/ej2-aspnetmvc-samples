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
        public ActionResult InsertSpecialCharacters()
        {
           
            var tools = new
            {
                tooltipText = "Insert Symbol",
                template = "<button class='e-tbar-btn e-btn' tabindex='-1' id='custom_tbar'  style='width:100%'><div class='e-tbar-btn-text rtecustomtool' style='font-weight: 500;'> &#937;</div></button>"
            };
            ViewBag.Items = new object[] { "Bold", "Italic", "Underline", "|", "Formats", "Alignments", "OrderedList",
        "UnorderedList", "|", "CreateLink", "Image", "CreateTable", "|", "SourceCode", tools
        , "|", "Undo", "Redo"
            };
            ViewBag.InsertBtn = new
            {
                content = "Insert",
                isPrimary = true
            };
            ViewBag.CancelBtn = new
            {
                content = "Cancel"
            };

            return View();
        }
    }
}
