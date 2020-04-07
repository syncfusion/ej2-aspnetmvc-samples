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
        // GET: DefaultFunctionalities
        public ActionResult HeaderTemplate()
        {
            ViewBag.data = new KanbanDataModels().KanbanTasks();
            return View();
        }
    }
}