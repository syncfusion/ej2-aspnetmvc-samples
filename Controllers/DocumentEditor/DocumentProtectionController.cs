using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.DocumentEditor
{
    public partial class DocumentEditorController : Controller
    {
        // GET: DocumentProtection
        public ActionResult DocumentProtection()
        {
            this.DocumentEditorViewResultHelper();
            return View();
        }
    }
}