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
        public ActionResult MentionIntegration()
        {
            ViewData["emails"] = new EmailData().EmailList();
            ViewData["mentionChar"] = '@';
            return View();
        }
    }
}
