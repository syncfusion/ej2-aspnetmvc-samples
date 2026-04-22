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
using EJ2MVCSampleBrowser.Controllers.Schedule;
using Syncfusion.EJ2.InteractiveChat;
using static EJ2MVCSampleBrowser.Controllers.ChatUI.ChatUIController;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class RichTextEditorController : Controller
    {
        public ChatUIUser CurrentUser { get; set; }
        public List<ChatUIMessage> ChatMessagesData { get; set; } = new List<ChatUIMessage>();
        public ChatUIUser CurrentUserModel { get; set; } = new ChatUIUser() { Id = "user1", User = "Albert" };
        public ChatUIUser MichaleUserModel { get; set; } = new ChatUIUser() { Id = "user2", User = "Michale Suyama", AvatarUrl = "./../Content/chatui/images/andrew.png" };
        public List<ToolbarItemModel> MessageToolbarItems { get; set; }

        public ActionResult BottomToolbar()
        {
            ViewData["Tools"] = new object[] { "Bold", "Italic", "Underline", "InlineCode", "|", "FontColor", "BackgroundColor", "|", "Alignments", "Blockquote", "|", "Orderedlist", "UnOrderedlist", "|", "CreateLink", "Image", "CreateTable", "EmojiPicker" };
            CurrentUser = CurrentUserModel;
            ChatMessagesData.Add(new ChatUIMessage()
            {
                Text = "Hi Michale, are we on track for the deadline?",
                Author = CurrentUserModel
            });
            ChatMessagesData.Add(new ChatUIMessage()
            {
                Text = "Yes, the design phase is complete.",
                Author = MichaleUserModel
            });
            ChatMessagesData.Add(new ChatUIMessage()
            {
                Text = "I will review it and send feedback by today.",
                Author = CurrentUserModel
            });
            ChatMessagesData.Add(new ChatUIMessage()
            {
                Text = "Okay.",
                Author = MichaleUserModel
            });
            MessageToolbarItems = new List<ToolbarItemModel>()
            {
                new ToolbarItemModel { iconCss = "e-icons e-chat-copy", tooltipText = "Copy" },
                new ToolbarItemModel { iconCss = "e-icons e-chat-trash", tooltipText = "Delete" }
            };
            ViewBag.ChatMessagesData = ChatMessagesData;
            ViewBag.CurrentUser = CurrentUser;
            ViewData["MessageToolbarItems"] = MessageToolbarItems;
            ViewBag.FooterTemplate = "<div class='custom-footer'>" +
            "<div id='editor'></div>" +
            "<button id='sendMessage' class='e-btn e-primary e-icons e-send e-send-1 e-icon-btn e-small' style='float: right; margin: 4px;'></button>" +
            "<button id='cancelMessage' class='e-trash e-btn e-secondary e-icons e-delete-3 e-icon-btn e-small' style='float: right; margin: 4px;'></button>" +
            "</div>";
            return View();
        }
    }
}



