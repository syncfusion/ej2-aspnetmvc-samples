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
            return View();
        }

        public PartialViewResult DocumentEditorViewResultHelper()
        {
            List<object> exportItems = new List<object>();
            exportItems.Add(new { text = "Microsoft Word (.docx)", id = "word" });
            exportItems.Add(new { text = "Syncfusion Document Text (.sfdt)", id = "sfdt" });
            ViewBag.ExportItems = exportItems;

            List<object> zoomItems = new List<object>();
            zoomItems.Add(new { text = "200%" });
            zoomItems.Add(new { text = "175%" });
            zoomItems.Add(new { text = "150%" });
            zoomItems.Add(new { text = "125%" });
            zoomItems.Add(new { text = "100%" });
            zoomItems.Add(new { text = "75%" });
            zoomItems.Add(new { text = "50%" });
            zoomItems.Add(new { text = "25%" });
            zoomItems.Add(new { separator = true });
            zoomItems.Add(new { text = "Fit one page" });
            zoomItems.Add(new { text = "Fit page width" });
            ViewBag.zoomList = zoomItems;

            return PartialView();
        }
        public ActionResult Default()
        {
            return this.DocumentEditorViewResultHelper();
        }
    }
}