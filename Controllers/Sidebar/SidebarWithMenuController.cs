using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class SidebarController : Controller
    {
        // GET: SidebarWithList
        public ActionResult SidebarWithMenu()
        {
            return View();
        }
    }
}