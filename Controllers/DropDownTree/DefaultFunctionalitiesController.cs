#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.DropDowns;

namespace EJ2MVCSampleBrowser.Controllers.DropDownTree
{
    public partial class DropDownTreeController : Controller
    {
        DropDownTreeFields fields = new DropDownTreeFields();
        public ActionResult DefaultFunctionalities()
        {
            DropDownTreeDefaultData dropDownTreeData = new DropDownTreeDefaultData();
            fields.DataSource = dropDownTreeData.getDropDownTreeDefaultData();
            fields.Value = "Id";
            fields.Text = "Name";
            fields.Expanded = "Expanded";
            fields.Child = "SubChild";
            ViewData["fields"] = fields;
            return View();
        }
    }
}