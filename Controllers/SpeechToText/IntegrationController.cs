#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.EJ2.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.SpeechToText
{
    public partial class SpeechToTextController : Controller
    {
        public List<ToolbarItemModel> Items = new List<ToolbarItemModel>();
        public ActionResult Integration()
        {
            Items.Add(new ToolbarItemModel { align = "Right", iconCss = "e-icons e-refresh" });
            ViewBag.ToolbarItems = Items;
            return View();
        }
        public class ToolbarItemModel
        {
            public string type { get; set; }
            public string align { get; set; }
            public string iconCss { get; set; }
        }
    }
}