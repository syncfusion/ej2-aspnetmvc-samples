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

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class SidebarController : Controller
    {
        // GET: DefaultFunctionalities
        public ActionResult DefaultFunctionalities()
        {
            List<ToolbarItem> popItems = new List<ToolbarItem>();
            var folderTemplate = "<div class='e-folder'>"
                             + "<div class='e-folder-name'>Webmail</div>"
                             + "</div>";
            var userNameTemplate = "<div><div class='e-user-name'>John</div></div>";
            var userImageTemplate = "<div class='image-container'>"
                                + "<img height='36px' src='../Content/Sidebar/sidebar/images/user.svg' alt='John' />"
                                + "</div>";
            var listTemplate = "<div class='e-list-wrapper e-list-avatar e-list-multi-line'>"
                          + "<span class='e-avatar e-avatar-circle e-icon sf-icon-profile'></span>"
                          + "<span class='e-list-item-header'>${Text}</span>"
                          + "<span class='e-list-content'>${Subject}</span>"
                          + "<span class='e-list-text'>${Message}</span>"
                          + "</div>";
            popItems.Add(new ToolbarItem { PrefixIcon = "e-tbar-menu-icon tb-icons", TooltipText = "Menu" });
            popItems.Add(new ToolbarItem { Template = folderTemplate });
            popItems.Add(new ToolbarItem { Align = ItemAlign.Right, Template = userNameTemplate });
            popItems.Add(new ToolbarItem { CssClass = "e-custom", Template = userImageTemplate, Align = ItemAlign.Right });
            List<listData> InboxData = new List<listData>
            {
                new listData {Id="1", Text = "Albert Lives", Subject = "Business dinner invitation", Message = "Hello Uta Morgan," },
                new listData {Id="2",Text = "Ila Russo", Subject = "Opening for Sales Manager", Message = "Hello Jelani Moreno," },
                new listData {Id="3",Text = "Garth Owen", Subject = "Application for Job Title", Message = "Hello Ila Russo," },
                new listData {Id="4", Text = "Ursula Patterson", Subject = "Programmer Position Application", Message = "Hello Kerry Best," },
                new listData {Id="5", Text = "Nichole Rivas", Subject = "Annual Conference", Message = "Hi Igor Mccoy," }
            };
            Dictionary<string, object> HtmlAttribute = new Dictionary<string, object>()
            {   {"class", "default-sidebar" } };
            List<TreeData> LocalData = new List<TreeData>();
            LocalData.Add(new TreeData
            {
                Id = "1",
                Name = "Favorites",
                HasChild = true,
                Expanded = true
            });
            LocalData.Add(new TreeData
            {
                Id = "2",
                Pid = "1",
                Selected = true,
                Name = "Inbox",
            });
            LocalData.Add(new TreeData
            {
                Id = "3",
                Pid = "1",
                Name = "Sent Items"
            });
            LocalData.Add(new TreeData
            {
                Id = "5",
                HasChild = true,
                Name = "John",
                Expanded = true
            });
            LocalData.Add(new TreeData
            {
                Id = "6",
                Pid = "5",
                Name = "Inbox"
            });
            LocalData.Add(new TreeData
            {
                Id = "7",
                Pid = "5",
                Name = "Drafts",
            });
            LocalData.Add(new TreeData
            {
                Id = "8",
                Pid = "5",
                Name = "Deleted Items"
            });
            LocalData.Add(new TreeData
            {
                Id = "9",
                Pid = "5",
                Name = "Sent Items"
            });
            LocalData.Add(new TreeData
            {
                Id = "12",
                Pid = "5",
                Name = "Outbox"
            });
            ViewData["LocalData"] = LocalData;
            ViewData["ListData"] = InboxData;
            ViewData["ListTemplate"] = listTemplate;
            ViewData["HtmlAttributes"] = HtmlAttribute;
            ViewData["DefToolItems"] = popItems;
            return View();
        }
        public class listData
        {
            public string Id { get; set; }
            public string Text { get; set; }
            public string Subject { get; set; }
            public string Message { get; set; }
        }
        public class TreeData
        {
            public string Id { get; set; }
            public string Pid { get; set; }
            public string Name { get; set; }
            public bool HasChild { get; set; }
            public bool Expanded { get; set; }
            public bool Selected { get; set; }
        }
    }
}