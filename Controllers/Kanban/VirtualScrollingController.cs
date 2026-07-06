using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class KanbanController : Controller
    {
        public ActionResult VirtualScrolling()
        {
            ViewData["data"] = new KanbanDataModels().VirtualScrollKanbanData();
            ViewData["dialogData"] = new KanbanDialogModels().VirtualScrollDialogCardField();
            return View();
        }
    }
}