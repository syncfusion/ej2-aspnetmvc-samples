using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using EJ2CoreSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class RichTextEditorController : Controller
    {
        // GET: /<controller>/
        public ActionResult PasteCleanup()
        {
            ViewBag.Data = new FormatOption().FormatOptions();
            return View();
        }
    }
}
