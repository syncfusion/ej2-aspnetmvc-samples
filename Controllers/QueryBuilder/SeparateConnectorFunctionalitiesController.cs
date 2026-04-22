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
        public ActionResult SeparateConnectorFunctionalities()
        {
            ViewData["ImportBtn"] = new ButtonModel() { isPrimary = true, cssClass = "e-flat", content = "Import" };
            ViewData["CancelBtn"] = new ButtonModel() { content = "Cancel", cssClass = "e-flat" };
            QueryBuilderRule rule = new QueryBuilderRule()
            {
                Condition = "",
                Rules = new List<QueryBuilderRule>()
                {
                    new QueryBuilderRule { Label="First Name", Field="FirstName", Type="string", Operator="startswith", Value="Andre", Condition = "and" },
                    new QueryBuilderRule { Label="Last Name", Field="LastName", Type="string", Operator="in", Value = new List<string> { "Davolio", "Buchanan" }, Condition = "or" },
                    new QueryBuilderRule { Label="Age", Field="Age", Type ="number", Operator="greaterthan", Value=30, Condition = "and" },
                    new QueryBuilderRule { Condition="or", Rules = new List<QueryBuilderRule>()
                    {
                        new QueryBuilderRule { Label="Is Developer", Field="IsDeveloper", Type="boolean", Operator = "equal", Value=true, Condition = "and" },
                        new QueryBuilderRule { Label="Primary Framework", Field="PrimaryFramework", Type="string", Operator="equal", Value="React" }
                    }},
                    new QueryBuilderRule { Label="Hire Date", Field="HireDate", Type="date", Operator="between", Value = new List<string> { "11/28/2023", "11/30/2023" } }
                    
                }
            };
            ViewData["rule"] = rule;

            List<object> items = new List<object>();
            items.Add(new
            {
                text = "Import Inline Sql"
            });
            items.Add(new
            {
                text = "Import Parameter Sql"
            });
            items.Add(new
            {
                text = "Import Named Parameter Sql"
            });
            ViewData["items"] = items;

            ViewData["rule"] = rule;
            ViewData["dataSource"] = EmployeeData.GetAllRecords();

            return View();
        }
    }

}
