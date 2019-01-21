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
        public ActionResult LockRow()
        {
            var treeData = TreeGridItems.GetTreeData();
            ViewBag.datasource = treeData;

            List<Object> dropdata = new List<Object>();
            for(var i = 1; i <= 36; i++) {
                dropdata.Add(new { text = i.ToString(), value = i });
            }
            ViewBag.dropdata = dropdata;

            return View();
        }
    }
}