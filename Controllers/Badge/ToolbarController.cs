#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.EJ2.Navigations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Badge
{
    public partial class BadgeController : Controller
    {
        public ActionResult Toolbar()
        {
            List<ToolbarItem> alignItems = new List<ToolbarItem>();
            alignItems.Add(new ToolbarItem { Template = "<div class='e-toolbar-item'><div class='header e-toolbar-item'>Notification</div><div class='e-toolbar-item'><div class='badge-block'><div class='message icons'></div><span class='e-badge e-badge-primary e-badge-notification e-badge-overlap'>35</span></div></div><div class='e-toolbar-item'><div class='badge-block'><div class='user-profile icons'></div><span class='e-badge e-badge-success e-badge-notification e-badge-overlap'>28</span></div></div><div class='e-toolbar-item'><div class='badge-block'><div class='love icons'></div><span class='e-badge e-badge-info e-badge-notification e-badge-overlap'>98</span></div></div></div>" });
            ViewData["items"] = alignItems;
            return View();
        }
    }

}