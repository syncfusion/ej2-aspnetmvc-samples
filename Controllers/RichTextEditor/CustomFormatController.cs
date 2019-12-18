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
        public ActionResult CustomFormat()
        {
            ViewBag.Items = new object[] {"Bold", "Italic", "StrikeThrough", "|",
                "Formats", "OrderedList", "UnorderedList", "|",
                "CreateLink", "Image", "|",
                new {
                tooltipText= "Preview",
                    template= @"<button id='preview-code' class='e-tbar-btn e-control e-btn e-icon-btn'>
                        <span class='e-btn-icon e-icons e-md-preview'></span></button>"
                }, "Undo", "Redo"};

            return View();
        }
    }
}
