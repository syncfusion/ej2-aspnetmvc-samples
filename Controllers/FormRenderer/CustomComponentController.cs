using EJ2CoreSampleBrowser.Models;
using EJ2MVCSampleBrowser.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Syncfusion.EJ2.FormRenderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;


namespace EJ2MVCSampleBrowser.Controllers.FormRenderer
{
    public partial class FormRendererController : Controller
    {
        public ActionResult CustomComponents()
        {
            ViewData["contactSchema"] = new FormRendererData().GetContactForm();

            return View();
        }
    }
}