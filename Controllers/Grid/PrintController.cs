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
            ViewData["Datasource"] = order;
            ViewData["EmpDataSource"] = EmployeeView.GetAllRecords();
            ViewData["CustomerDataSource"] = Customer.GetAllRecords();
            ViewData["data"] = new List<string>() { "Expanded", "All", "None" };

            return View();
        }
    }
}