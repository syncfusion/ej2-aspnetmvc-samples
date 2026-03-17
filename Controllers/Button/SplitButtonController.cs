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

namespace EJ2MVCSampleBrowser.Controllers.Button
{
    public partial class ButtonController : Controller
    {
        public ActionResult SplitButton()
        {
            List<object> items = new List<object>();
            items.Add(new
            {
                text = "Paste",
                iconCss = "e-btn-icons e-paste"
            });
            items.Add(new
            {
                text = "Paste Special",
                iconCss = "e-btn-icons e-paste-special"
            });
            items.Add(new
            {
                text = "Paste as Formula",
                iconCss = "e-btn-icons e-paste-formula"
            });
            items.Add(new
            {
                text = "Paste as Hyperlink",
                iconCss = "e-btn-icons e-paste-hyperlink"
            });
            ViewData["datasource"] = items;
            return View();
        }
    }

}