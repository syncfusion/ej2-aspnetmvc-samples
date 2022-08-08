using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.TreeGrid
{
    public partial class TreeGridController : Controller
    {
        // GET: DefaultFunctionalities
        public ActionResult ColumnTemplate()
        {
            var treeData = TreeGridItems.GetTemplateData();
            ViewBag.datasource = treeData;
            return View();
        }
    }
}