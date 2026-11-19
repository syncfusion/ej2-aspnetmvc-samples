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
        public ActionResult EmployeeMgmt()
        {
            ViewBag.data1 = EmployeeManagement.GetData();
            ViewBag.data = new string[] { "HR", "Employee", "Help Desk", "Project Management" };
            ViewBag.value = "HR";
            return View();
        }
    }
}
