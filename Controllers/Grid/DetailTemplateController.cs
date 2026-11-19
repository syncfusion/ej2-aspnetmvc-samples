using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        // GET: DetailTemplate
        public ActionResult DetailTemplate()
        {
            var DataSource = EmployeeDetails.GetAllRecords();
            ViewData["dataSource"] = DataSource;
            var taskDetail = TaskDetail.GetAllRecords();
            ViewData["taskData"] = taskDetail;
            return View();
        }
    }
}