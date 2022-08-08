using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.QueryBuilder;

namespace EJ2MVCSampleBrowser.Controllers.QueryBuilder
{
    public partial class QueryBuilderController : Controller
    {
        // GET= DefaultFunctionalities
        public ActionResult DefaultFunctionalities()
        {
            QueryBuilderRule rule = new QueryBuilderRule()
            {
                Condition = "and",
                Rules = new List<QueryBuilderRule>()
                {
                    new QueryBuilderRule { Label="Employee ID", Field="EmployeeID", Type="number", Operator="equal", Value = 1 },
                    new QueryBuilderRule { Label="Title", Field="Title", Type="string", Operator="equal", Value = "Sales Manager" }
                }
            };

            ViewBag.rule = rule;
            ViewBag.dataSource = EmployeeView.GetAllRecords();
            return View();
        }
    }
}