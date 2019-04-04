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
            QueryBuilderRules rule = new QueryBuilderRules()
            {
                Condition = "and",
                Rules = new List<QueryBuilderRules>()
                {
                    new QueryBuilderRules { Label="Employee ID", Field="EmployeeID", Type="number", Operator="equal", Value = 1 },
                    new QueryBuilderRules { Label="Title", Field="Title", Type="string", Operator="equal", Value = "Sales Manager" }
                }
            };

            ViewBag.rule = rule;
            ViewBag.dataSource = EmployeeView.GetAllRecords();
            return View();
        }
    }
}