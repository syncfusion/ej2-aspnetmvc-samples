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
        DropDownTreeFields localFields = new DropDownTreeFields();
        DropDownTreeFields hierarchicalFields = new DropDownTreeFields();
        public ActionResult LocalData()
        {
            DropDownTreeLocalData dropDownTreeLocal = new DropDownTreeLocalData();
            DropDownTreeHierarchical dropDownTreeHierarchical = new DropDownTreeHierarchical();
            localFields.DataSource = dropDownTreeLocal.getDropDownTreeLocalData();  
            localFields.HasChildren = "HasChild";
            localFields.Expanded = "Expanded";
            localFields.Value = "Id";
            localFields.ParentValue = "PId";
            localFields.Text = "Name";
            ViewData["localFields"] = localFields;
            hierarchicalFields.DataSource = dropDownTreeHierarchical.getDropDownTreeHierarchical();
            hierarchicalFields.Value = "Code";
            hierarchicalFields.Text = "Name";
            hierarchicalFields.Child = "Child";
            ViewData["hierarchicalFields"] = hierarchicalFields;
            return View();
        }
    }
}