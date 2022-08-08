using EJ2MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        // GET: Print
        public ActionResult Print()
        {
            var order = OrdersDetails.GetAllRecords();
            ViewBag.Datasource = order;
            ViewBag.EmpDataSource = EmployeeView.GetAllRecords();
            ViewBag.CustomerDataSource = Customer.GetAllRecords();
            ViewBag.data = new List<string>() { "Expanded", "All", "None" };

            return View();
        }
    }
}