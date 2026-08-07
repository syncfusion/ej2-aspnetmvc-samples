using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class FileManagerController : Controller
    {
        public ActionResult API()
        {
            ViewData["dataSource"] = new string[] { "NewFolder", "Cut", "Copy", "Paste", "Delete", "Download", "Rename", "SortBy", "Refresh", "Selection", "View", "Details" };
            return View();
        }
    }
}
