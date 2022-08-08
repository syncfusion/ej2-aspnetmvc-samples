using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.DocumentEditor
{
    public partial class DocumentEditorController : Controller
    {
        public ActionResult ToolbarCustomization()
        {
            ViewBag.data = new string[] {"New", "Open", "Undo", "Redo","Comments", "Image","Table", "Hyperlink","Bookmark", "TableOfContents", "Header",  "Footer",
        "PageSetup", "PageNumber","Break","Find","LocalClipboard", "RestrictEditing" } ;
            this.DocumentEditorViewResultHelper();
            return View();
        }

    }
}