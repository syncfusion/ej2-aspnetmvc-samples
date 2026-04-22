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
        DropDownTreeFields iconsFields = new DropDownTreeFields();
        public ActionResult IconsAndImages()
        {
            DropDownTreeIcons dropdownTreeIconsAndImages = new DropDownTreeIcons();
            iconsFields.DataSource = dropdownTreeIconsAndImages.getIconsData();
            iconsFields.Value = "nodeId";
            iconsFields.Text = "nodeText";
            iconsFields.IconCss = "icon";
            iconsFields.ImageUrl = "image";
            iconsFields.Expanded = "expanded";
            iconsFields.Child = "child";
            ViewData["iconsFields"] = iconsFields;
            return View();
        }
    }
}