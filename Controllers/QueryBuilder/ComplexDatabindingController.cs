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
        public ActionResult ComplexDatabinding()
        {
            QueryBuilderRule rule = new QueryBuilderRule()
            {
                Condition = "and",
                Rules = new List<QueryBuilderRule>()
                {
                   new QueryBuilderRule { Label="ID", Field="Employee.ID", Type="number", Operator="equal", Value = 1001 },
                    new QueryBuilderRule { Label="First Name", Field="Name.FirstName", Type="string", Operator="equal", Value = "Mark" },
                    new QueryBuilderRule { Condition="or", Rules = new List<QueryBuilderRule>() {
                        new QueryBuilderRule { Label="State", Field="Country.State", Type="string", Operator="equal", Value = "Jersey" },
                        new QueryBuilderRule { Label="Date of birth", Field="Employee.DOB", Type="date", Operator="equal", Value = "7/7/96" }
                    }}
                }
            };
            ViewData["rule"] = rule;
            return View();
        }
    }
}