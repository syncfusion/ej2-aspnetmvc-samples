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
        public ActionResult InlineEditing()
        {
            var treeData = TreeGridItems.GetTreeData();
            ViewBag.datasource = treeData;

            List<Object> dropData = new List<object>() {
                new { value = "Row", text = "Row Editing" },
                new { value = "Cell", text = "Cell Editing" },
            };
            ViewBag.dropdata = dropData;
            return View();
        }
    }
}