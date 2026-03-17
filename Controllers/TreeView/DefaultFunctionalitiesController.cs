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
   
        TreeViewFieldsSettings fields = new TreeViewFieldsSettings();
      
        public ActionResult DefaultFunctionalities()
        {
            TreeviewModel treevireModel = new TreeviewModel();
            fields.DataSource = treevireModel.getTreeviewModel();
            fields.HasChildren = "HasChild";
            fields.Expanded = "Expanded";
            fields.Id = "Id";
            fields.ParentID = "PId";
            fields.Text = "Name";
            ViewData["fields"] = fields;
            return View();
        }
       
    }
}