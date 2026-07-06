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
        // GET: MasterDetailsExport
        public ActionResult MasterDetailsExport()
        {
            var order = OrdersDetails.GetAllRecords();
            ViewData["Datasource"] = order;
            ViewData["EmpDataSource"] = EmployeeView.GetAllRecords();
            ViewData["CustomerDataSource"] = Customer.GetAllRecords();
            return View();
        }
    }
}