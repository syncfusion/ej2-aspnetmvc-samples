using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2CoreSampleBrowser.Models;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.FormBuilder
{
    public partial class FormBuilderController : Controller
    {
        public ActionResult Default()
        {
            ViewData["formSchema"] = new FormBuilderData().GetData();
            return View();
        }
    }
}