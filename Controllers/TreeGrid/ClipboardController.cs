using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Controllers.Dialog;
using Syncfusion.EJ2.Popups;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.TreeGrid
{
    public partial class TreeGridController : Controller
    {
        // GET: Clipboard
        public ActionResult Clipboard()
        {
            var treeData = TreeGridItems.GetTreeData();
            ViewBag.datasource = treeData;
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "alertBtnClick", ButtonModel = new customButtonModel() { content = "OK", isPrimary = true } });
            ViewBag.alertbutton = buttons;
            List<Object> dropData = new List<object>() {
                new { id = "Parent", mode = "Parent" },
                new { id = "Child", mode = "Child" },
                new { id = "Both", mode = "Both" },
                new { id = "None", mode = "None" }
            };
            ViewBag.dropdata = dropData;
            return View();
        }
    }
}