#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.EJ2.InteractiveChat;
using System.Collections.Generic;
using EJ2MVCSampleBrowser.Models;
using System.Web.Mvc;
using System.Linq;

namespace EJ2MVCSampleBrowser.Controllers.ChatUI
{
    public partial class ChatUIController
    {
        public List<object> TimeStampFormatOptions { get; set; }
        public List<object> TypingUserOptions { get; set; }
        public List<object> MentionUserOptions { get; set; }
        public object DDBListValue = "MM/dd hh:mm a";
        public string[] MentionUserValues { get; set; }
        public List<ChatUIUser> MentionUsers { get; set; }
        public List<ChatUIMessage> CommunityMessagedata { get; set; }
        public List<ToolbarItemModel> MessageToolbarItems { get; set; }
        public ActionResult API()
        {
            MessageToolbarItems = new List<ToolbarItemModel>()
            {
                new ToolbarItemModel { iconCss = "e-icons e-chat-forward", tooltipText = "Forward" },
                new ToolbarItemModel { iconCss = "e-icons e-chat-copy", tooltipText = "Copy" },
                new ToolbarItemModel { iconCss = "e-icons e-chat-reply", tooltipText = "Reply" },
                new ToolbarItemModel { iconCss = "e-icons e-chat-pin", tooltipText = "Pin" },
                new ToolbarItemModel { iconCss = "e-icons e-chat-trash", tooltipText = "Delete" }
            };
            CommunityMessagedata = new ChatMessagesData().GetCommunityMessageData();
            TimeStampFormatOptions = new List<object>
            {
                new { text = "MM/dd hh:mm a", value = "MM/dd hh:mm a" },
                new { text = "dd/MM/yy hh:mm a", value = "dd/MM/yy hh:mm a" },
                new { text = "hh:mm a", value = "hh:mm a" },
                new { text = "MMMM hh:mm a", value = "MMMM hh:mm a" }
            };
            TypingUserOptions = new List<object>
            {
                new { text = "Michale", value = "Michale" },
                new { text = "Laura", value = "Laura" },
                new { text = "Charlie", value = "Charlie" },
                new { text = "Jordan", value = "Jordan"}
            };
            MentionUserOptions = new List<object>
            {
                 new { text = "Alice Brown", value = "Alice Brown" },
                 new { text = "Michale Suyama", value = "Michale Suyama" },
                 new { text = "Charlie", value = "Charlie" },
                 new { text = "Janet", value = "Janet" },
                 new { text = "Jordan Peele", value = "Jordan Peele" }
            };

            MentionUserValues = new string[] { "Alice Brown", "Michale Suyama", "Charlie", "Janet", "Jordan Peele" };

            var userModels = new ChatMessagesData().GetMentionUsers();

            MentionUsers = userModels.Select(u => new ChatUIUser
            {
                Id = u.id,
                User = u.user,
                AvatarUrl = u.avatarUrl,
                AvatarBgColor = u.avatarBgColor,
                StatusIconCss = u.statusIconCss
            }).ToList();


            ViewData["MessageToolbarItems"] = MessageToolbarItems;
            ViewData["CommunityMessagedata"] = CommunityMessagedata;
            ViewData["TimeStampFormatOptions"] = TimeStampFormatOptions;
            ViewData["TypingUserOptions"] = TypingUserOptions;
            ViewData["MentionUserOptions"] = MentionUserOptions;
            ViewData["DDBListValue"] = DDBListValue;
            ViewData["MentionUsers"] = MentionUsers;
            ViewData["MentionUserValues"] = MentionUserValues;
            return View();
        }
    }
}