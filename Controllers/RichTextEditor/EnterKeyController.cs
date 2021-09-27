using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using EJ2CoreSampleBrowser.Models;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class RichTextEditorController : Controller
    {
        // GET: /<controller>/
        public ActionResult EnterKey()
        {
            ViewBag.EnterData = new FormatOption().EnterOption();
            ViewBag.ShiftEnterData = new FormatOption().ShiftEnterOption();
            return View();
        }
    }
}
