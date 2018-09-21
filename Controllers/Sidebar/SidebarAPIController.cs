using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class SidebarController : Controller
    {
        // GET: SidebarAPI
        public ActionResult SidebarAPI()
        {
            ViewBag.data = new string[] { "Over", "Push", "Slide", "Auto" };
            return View();
        }
    }
}