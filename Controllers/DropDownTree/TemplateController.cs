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
        DropDownTreeFields templateData = new DropDownTreeFields();
        public ActionResult Template()
        {
            DropDownTreeTemplate dropdownTreeTemplate = new DropDownTreeTemplate();
            templateData.DataSource = dropdownTreeTemplate.Template();
            templateData.Value = "id";
            templateData.Text = "name";
            templateData.Expanded = "expanded";
            templateData.HasChildren = "hasChild";
            templateData.ParentValue = "pid";
            ViewData["templateData"] = templateData;
            return View();
        }
    }
}