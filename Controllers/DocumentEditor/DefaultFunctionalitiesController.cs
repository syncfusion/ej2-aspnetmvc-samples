using Syncfusion.EJ2.Navigations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.DocumentEditor
{
    public partial class DocumentEditorController : Controller
    {
        public ActionResult DefaultFunctionalities()
        {
            this.DocumentEditorViewResultHelper();
            return View();
        }

        public PartialViewResult DocumentEditorViewResultHelper()
        {
            List<object> exportItems = new List<object>();
            exportItems.Add(new { text = "Microsoft Word (.docx)", id = "word" });
            exportItems.Add(new { text = "Syncfusion Document Text (.sfdt)", id = "sfdt" });
            ViewBag.ExportItems = exportItems;
            
            return PartialView();
        }    
    }
}