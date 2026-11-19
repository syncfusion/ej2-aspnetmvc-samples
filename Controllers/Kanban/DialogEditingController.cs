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
        public ActionResult DialogEditing()
        {
            ViewData["data"] = new KanbanDataModels().KanbanTasks();
            ViewData["status"] = new KanbanDataModels().DialogStatus();
            ViewData["assignee"] = new KanbanDataModels().AssigneeData();
            ViewData["priority"] = new KanbanDataModels().PriorityData();
            return View();
        }
    }
}