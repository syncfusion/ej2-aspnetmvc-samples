using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Popups;

namespace EJ2MVCSampleBrowser.Controllers.TreeGrid
{
    public partial class TreeGridController : Controller
    {
        // GET: Adaptive
        public ActionResult Adaptive()
        {
            var treeData = TreeGridItems.GetTreeData();
            ViewBag.datasource = treeData;
            return View();
        }
    }
}