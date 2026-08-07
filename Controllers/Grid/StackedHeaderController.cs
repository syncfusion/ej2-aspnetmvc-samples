using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        // GET: StackedHeader
        public ActionResult StackedHeader()
        {
            ViewData["StackedHeaderData"] = EJ2MVCSampleBrowser.Models.StackedHeader.GetStackedHeaders(830);
            return View();
        }
    }
}