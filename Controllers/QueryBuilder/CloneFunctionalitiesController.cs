#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
        public ActionResult CloneFunctionalities()
        {
            QueryBuilderRule rule = new QueryBuilderRule()
            {
                Condition = "and",
                Rules = new List<QueryBuilderRule>()
                {
                    new QueryBuilderRule { Label="Employee ID", Field="EmployeeID", Type="number", Operator="greaterthanorequal", Value = 1 },
                    new QueryBuilderRule { Label="Title", Field="Title", Type="string", Operator="startswith", Value = "Sales Manager" },
                     new QueryBuilderRule { Condition="or", Rules = new List<QueryBuilderRule>() {
                        new QueryBuilderRule { Label="First Name", Field="FirstName", Type="string", Operator="equal", Value = "Jersey" },
                        new QueryBuilderRule { Label="Country", Field="Country", Type="string", Operator="notequal", Value = "USA" }
                    }}
                }
            };

            ViewData["rule"] = rule;
            ViewData["dataSource"] = EmployeeView.GetAllRecords();
            return View();
        }
    }
}