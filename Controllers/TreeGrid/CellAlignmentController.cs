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
        // GET: CellAlignment
        public ActionResult CellAlignment()
        {
            var treeData = TreeGridItems.GetTreeData();
            ViewBag.datasource = treeData;

             List<object> dd = new List<object>();
            dd.Add(new { name = "Task ID", id = "TaskId" });
            dd.Add(new { name = "Start Date", id = "StartDate" });
            dd.Add(new { name = "Duration", id = "Duration" });
            dd.Add(new { name = "Progress", id = "Progress" });
            ViewBag.dd = dd;

            List<object> index = new List<object>();
            index.Add(new { name = "Right", id = "Right" });
            index.Add(new { name = "Left", id = "Left" });
            index.Add(new { name = "Center", id = "Center" });
            index.Add(new { name = "Justify", id = "Justify" });
            ViewBag.index = index;
            return View();
        }
    }
}