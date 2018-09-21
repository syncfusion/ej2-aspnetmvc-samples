using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class SliderController : Controller
    {
        public string content { get; private set; }
        public bool isPrimary { get; private set; }

        public ActionResult CloudPricing()
        {
            return View();
        }
    }
}
