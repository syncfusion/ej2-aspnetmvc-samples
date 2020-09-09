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
        List<sortData> sortData = new List<sortData>();
        // GET: Sorting
        public ActionResult Sorting()
        {
            ViewBag.data = new KanbanDataModels().KanbanTasks();
            sortData.Add(new sortData { Id = "DataSourceOrder", Sort = "Data Source Order" });
            sortData.Add(new sortData { Id = "Index", Sort = "Index" });
            sortData.Add(new sortData { Id = "Custom", Sort = "Custom" });
            ViewBag.SortByData = sortData;
            ViewBag.FieldData = new string[] { "None" };
            ViewBag.DirectionData = new string[] { "Ascending", "Descending" };
            return View();
        }
    }
    public class sortData
    {
        public string Id { get; set; }
        public string Sort { get; set; }

    }
}