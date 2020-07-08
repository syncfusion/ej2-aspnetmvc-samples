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
        List<statusData> data = new List<statusData>();
        public ActionResult SearchFilter()
        {
            ViewBag.PriorityData = new string[] { "None", "High", "Normal", "Low" };
            data.Add(new statusData { Id = "None", Status = "None" });
            data.Add(new statusData { Id = "To Do", Status = "Open" });
            data.Add(new statusData { Id = "In Progress", Status = "InProgress" });
            data.Add(new statusData { Id = "Testing", Status = "Testing" });
            data.Add(new statusData { Id = "Done", Status = "Close" });
            ViewBag.StatusData = data;
            ViewBag.data = new KanbanDataModels().KanbanTasks();
            return View();
        }
    }
    public class statusData
    {
        public string Id { get; set; }
        public string Status { get; set; }

    }
}