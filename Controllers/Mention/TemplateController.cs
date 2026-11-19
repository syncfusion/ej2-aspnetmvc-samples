using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class MentionController : Controller
    {
        public ActionResult Template()
        {
            ViewData["sports"] = new SportsData().SportsList();
            return View();
        }
    }
}