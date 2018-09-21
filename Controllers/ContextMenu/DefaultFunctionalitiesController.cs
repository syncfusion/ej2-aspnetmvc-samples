using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Controllers.ContextMenu
{
    public partial class ContextMenuController : Controller
    {
        public ActionResult DefaultFunctionalities()
        {
            List<object> menuItems = new List<object>();
            menuItems.Add(new
            {
                text = "Cut",
                iconCss = "e-cm-icons e-cut"
            });
            menuItems.Add(new
            {
                text = "Copy",
                iconCss = "e-cm-icons e-copy"
            });
            menuItems.Add(new
            {
                text = "Paste",
                iconCss = "e-cm-icons e-paste",
                items = new List<object>()
                {
                    new { text = "Paste Text", iconCss = "e-cm-icons e-pastetext" },
                    new { text = "Paste Special", iconCss = "e-cm-icons e-pastespecial" }
                }
            });
            menuItems.Add(new
            {
                separator = true
            });
            menuItems.Add(new
            {
                text = "Link",
                iconCss = "e-cm-icons e-link"
            });
            menuItems.Add(new
            {
                text = "New Comment",
                iconCss = "e-cm-icons e-comment"
            });

            ViewBag.menuItems = menuItems;
            return View();
        }
      }
    }