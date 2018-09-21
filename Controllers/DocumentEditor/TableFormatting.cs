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
        public ActionResult TableFormatting()
        {
            return View();
        }

        public ActionResult TableFormat()
        {
            return this.DocumentEditorViewResultHelper();
        }
    }
}