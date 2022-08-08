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
        public ActionResult ShowHide()
        {
            var treeData = TreeGridItems.GetTreeData();
            ViewBag.datasource = treeData;
            List<object> dd = new List<object>();
            dd.Add(new { text = "Task ID", value = "TaskId" });
            dd.Add(new { text = "Start Date", value = "StartDate" });
            dd.Add(new { text = "Duration", value = "Duration" });
            dd.Add(new { text = "Progress", value = "Progress" });
            ViewBag.columns = dd;

            return View();
        }
    }
}