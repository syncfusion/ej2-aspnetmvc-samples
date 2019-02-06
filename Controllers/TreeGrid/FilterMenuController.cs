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
        public ActionResult FilterMenu()
        {
            var treeData = TreeGridItems.GetTreeData();
            ViewBag.datasource = treeData;

            List<Object> dropData = new List<object>() {
                new { id = "Parent", mode = "Parent" },
                new { id = "Child", mode = "Child" },
                new { id = "Both", mode = "Both" },
                new { id = "None", mode = "None" }
            };
            ViewBag.dropdata = dropData;
            List<Object> typedropData = new List<object>() {
				new { id = "Menu", type = "Menu" },
                new { id = "Excel", type = "Excel" }
            };
            ViewBag.typedropdata = typedropData;
            return View();
        }
    }
}