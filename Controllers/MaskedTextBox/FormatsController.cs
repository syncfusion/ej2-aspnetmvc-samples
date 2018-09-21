using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class MaskedTextBoxController : Controller
    {


        public ActionResult Formats()
        {
            ViewBag.data = new GameList().MaskEditModel();
            return View();

        }
    }

}