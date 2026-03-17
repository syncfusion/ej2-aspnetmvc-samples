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
        DropDownTreeFields selectionData = new DropDownTreeFields();
        public ActionResult MultipleSelection()
        {
            DropDownTreeMultiSelection dropdownTreeMultiSelection = new DropDownTreeMultiSelection();
            selectionData.DataSource = dropdownTreeMultiSelection.MultipleSelection();
            selectionData.Value = "id";
            selectionData.Text = "name";
            selectionData.Expanded = "expanded";
            selectionData.HasChildren = "hasChild";
            selectionData.ParentValue = "pid";
            ViewData["selectionData"] = selectionData;
            return View();
        }
    }
}