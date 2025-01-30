#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
using Syncfusion.EJ2.Popups;

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        // GET: FrozenAPI
        public ActionResult FrozenAPI()
        {
            var order = OrdersDetails.GetAllRecords();
            ViewBag.datasource = order;
            List<object> dd = new List<object>();
            dd.Add(new { name = "Order ID", id = "OrderID" });
            dd.Add(new { name = "Freight", id = "Freight" });
            dd.Add(new { name = "Customer ID", id = "CustomerID" });
            dd.Add(new { name = "Order Date", id = "OrderDate" });
            dd.Add(new { name = "Ship Name", id = "ShipName" });
            dd.Add(new { name = "Ship Address", id = "ShipAddress" });
            dd.Add(new { name = "Ship City", id = "ShipCity" });
            dd.Add(new { name = "Ship Country", id = "ShipCountry" });
            ViewBag.columns = dd;
            List<object> direction = new List<object>();
            direction.Add(new { name = "Left", id = "Left" });
            direction.Add(new { name = "Right", id = "Right" });
            direction.Add(new { name = "Center", id = "Center" });
             direction.Add(new { name = "Fixed", id = "Fixed" });
            ViewBag.direction = direction;
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "alertDlgBtnClick", ButtonModel = new DefaultButtonModel() { content = "OK", isPrimary = true } });
            ViewBag.DefaultButtons = buttons;
            return View();
        }
        public class DefaultButtonModel
        {
            public string content { get; set; }
            public bool isPrimary { get; set; }
        }
    }
}