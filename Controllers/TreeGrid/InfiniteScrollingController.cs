using EJ2MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.TreeGrid
{
    public partial class TreeGridController : Controller
    {
        // GET: InfiniteScrolling
        public ActionResult InfiniteScrolling()
        {
            ViewBag.datasource = VirtualDataFormat.GetVirtualData();
            return View();
        }
    }
}