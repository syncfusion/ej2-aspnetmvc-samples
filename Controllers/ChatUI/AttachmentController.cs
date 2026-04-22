#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.InteractiveChat;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.ChatUI
{
    public partial class ChatUIController : Controller
    {
        public List<AttachmentToolbarItemModel> AttachmentHeaderToolbar { get; set; } = new List<AttachmentToolbarItemModel>();
        public ActionResult Attachment()
        {
            AttachmentHeaderToolbar.Add(new AttachmentToolbarItemModel { iconCss = "e-icons e-refresh", align = "Right", tooltipText = "Clear Chat" });
            ViewData["AttachmentHeaderToolbar"] = AttachmentHeaderToolbar;
            return View();
        }

        public class AttachmentToolbarItemModel
        {
            public string align { get; set; }
            public string tooltipText { get; set; }
            public string iconCss { get; set; }
        }

    }
}