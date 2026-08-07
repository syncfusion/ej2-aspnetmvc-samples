using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2CoreSampleBrowser.Models;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.FormRenderer
{
    public partial class FormRendererController : Controller
    {
        public ActionResult Default()
        {
            ViewData["formSchema"] = new FormRendererData().GetData();
            return View();
        }
    }
}