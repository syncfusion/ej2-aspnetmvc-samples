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
using Syncfusion.EJ2.QueryBuilder;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.DropDowns;
using Syncfusion.EJ2.Base;

namespace EJ2MVCSampleBrowser.Controllers.QueryBuilder
{
    public partial class QueryBuilderController : Controller
    {
        public ActionResult RuleTemplate()
        {
            QueryBuilderRule rule = new QueryBuilderRule()
            {
                Condition = "and",
                Rules = new List<QueryBuilderRule>()
                {
                    new QueryBuilderRule { Label="First Name", Field="FirstName", Type="string", Operator="equal", Value="Nancy"  },
                    new QueryBuilderRule { Label="Country", Field="Country", Type="string", Operator="equal", Value = "USA" }
                }
            };
            ViewData["rule"] = rule;
            return View();
        }
        public ActionResult RuleTemplatePartial(QueryTemplateModel.ValueModel args)
        {
            List<Object> Items = new List<object>()
            {
                new {field = "USA", label ="USA" },
                new {field = "England", label ="England"},
                new {field = "India", label ="India" },
                new {field = "Spain", label ="Spain" }
            };
            ViewData["Items"] = Items;
            return PartialView("_RuleTemplatePartial", args.Value);
        }
        
    }
}