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
        public ActionResult Selection()
        {
            var treeData = TreeGridItems.GetTreeData();
            ViewBag.datasource = treeData;            
            ViewBag.typedata = new List<object>() {
               new { id= "Single", type= "Single" },
               new { id= "Multiple", type= "Multiple" }
            };
            ViewBag.modedata = new List<object>() {
               new { id= "Row", mode= "Row" },
               new { id= "Cell", mode= "Cell" }
            };
            ViewBag.cellmodedata = new List<object>() {
               new { id= "Flow", cellmode= "Flow" },
               new { id= "Box", cellmode= "Box" }
            };

            return View();
        }
    }
}