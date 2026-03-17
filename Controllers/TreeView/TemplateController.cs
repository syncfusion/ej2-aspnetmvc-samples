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
using Syncfusion.EJ2.Navigations;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.TreeView
{
    public partial class TreeViewController : Controller
    {
        TreeViewFieldsSettings templateFields = new TreeViewFieldsSettings();
        public ActionResult Template()
        {
            TreeviewTemplate treeviewTemplate = new TreeviewTemplate();
            templateFields.DataSource = treeviewTemplate.getTreeviewTemplate();
            templateFields.HasChildren = "HasChild";
            templateFields.Expanded = "Expanded";
            templateFields.Selected = "Selected";
            templateFields.Id = "id";
            templateFields.ParentID = "pid";
            templateFields.Text = "name";
            ViewData["templateFields"] = templateFields;
            return View();
        }

    }
}