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
        DropDownTreeFields filteringData = new DropDownTreeFields();
        public ActionResult Filtering()
        {
            DropDownTreeFiltering dropdownTreeFiltering = new DropDownTreeFiltering();
            filteringData.DataSource = dropdownTreeFiltering.Filtering();
            filteringData.Value = "id";
            filteringData.Text = "name";
            filteringData.Expanded = "expanded";
            filteringData.HasChildren = "hasChild";
            filteringData.ParentValue = "pid";
            ViewData["filteringdata"] = filteringData;
            return View();
        }
    }
}