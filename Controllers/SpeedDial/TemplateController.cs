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
using Syncfusion.EJ2.Buttons;
namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class SpeedDialController : Controller
    {
        public ActionResult Template()
        {
            List<SpeedDialItem> items = new List<SpeedDialItem>();
            items.Add(new SpeedDialItem
                {
                Text = "Cut",
                IconCss = "speeddial-icons speeddial-icon-cut"
            });
            items.Add(new SpeedDialItem
                {
                Text = "Copy",
                IconCss = "speeddial-icons speeddial-icon-copy"
            });
            items.Add(new SpeedDialItem
                {
                Text = "Paste",
                IconCss = "speeddial-icons speeddial-icon-paste"
            });
            items.Add(new SpeedDialItem
                {
                Text = "Delete",
                IconCss = "speeddial-icons speeddial-icon-delete"
            });

            ViewData["datasource"] = items;
            return View();
        }
    }

}