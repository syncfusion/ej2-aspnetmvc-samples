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
namespace EJ2MVCSampleBrowser.Controllers.QueryBuilder
{
    public partial class QueryBuilderController : Controller
    {
        // GET= DefaultFunctionalities
        public ActionResult Template()
        {
            QueryBuilderRule rule = new QueryBuilderRule()
            {
                Condition = "and",
                Rules = new List<QueryBuilderRule>()
                {
                    new QueryBuilderRule { Label="Category", Field="Category", Type="string", Operator="equal", Value = new string[] { "Clothing" } },
                    new QueryBuilderRule { Condition="or", Rules = new List<QueryBuilderRule>() {
                        new QueryBuilderRule { Label="Transaction Type", Field="TransactionType", Type="boolean", Operator="equal", Value = "Income" },
                        new QueryBuilderRule { Label="Payment Mode", Field="PaymentMode", Type="string", Operator="equal", Value = "Cash" }
                    } },
                    new QueryBuilderRule { Label="Amount", Field="Amount", Type="number", Operator="equal", Value = 10 }
                }
            };

            List<object> paymentOperator = new List<object> {
                new { key = "Equal", value = "equal" },
                new { key = "Not Equal", value = "notequal" }
            };

            List<object> transactionOperator = new List<object> {
                new { key = "Equal", value = "equal" },
                new { key = "Not Equal", value = "notequal" }
            };

            List<object> amountOperator = new List<object> {
                new { key = "Equal", value = "equal" },
                new { key = "Greater than", value = "greaterthan" },
                new { key = "Less than", value = "lessthan" },
                new { key = "Less than or equal", value = "lessthanorequal" },
                new { key = "Greater than or equal", value = "greaterthanorequal" },
                new { key = "Not equal", value = "notequal" }
            };

            ViewData["rule"] = rule;
            ViewData["paymentOperator"] = paymentOperator;
            ViewData["transactionOperator"] = transactionOperator;
            ViewData["amountOperator"] = amountOperator;
            ViewData["dataSource"] = QueryBuilderData.expenseData;
            return View();
        }
    }
}