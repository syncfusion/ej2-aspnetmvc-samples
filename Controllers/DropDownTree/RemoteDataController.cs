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
using Syncfusion.EJ2.DropDowns;
using Syncfusion.EJ2;

namespace EJ2MVCSampleBrowser.Controllers.DropDownTree
{
    public partial class DropDownTreeController : Controller
    {
        DropDownTreeFields parentData = new DropDownTreeFields();
        DropDownTreeFields childData = new DropDownTreeFields();
        public ActionResult RemoteData()
        {
            object data = new DataManager
            {
                Url = "https://services.odata.org/V4/Northwind/Northwind.svc",
                Adaptor = "ODataV4Adaptor",
                CrossDomain = true
            };
            // Parent data mapping
            parentData.Query = "new ej.data.Query().from('Employees').select('EmployeeID,FirstName,Title').take(5)";
            parentData.Value = "EmployeeID";
            parentData.Text = "FirstName";
            parentData.HasChildren = "EmployeeID";
            parentData.Child = childData;
            parentData.DataSource = data;
            // Child data mapping  
            childData.Query = "new ej.data.Query().from('Orders').select('OrderID,EmployeeID,ShipName').take(5)";
            childData.Value = "OrderID";
            childData.Text = "ShipName";
            childData.ParentValue = "EmployeeID";
            childData.DataSource = data;
            ViewData["remoteFields"] = parentData;
            return View();
        }
    }
}