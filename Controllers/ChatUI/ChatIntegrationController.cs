#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.ChatUI
{
    public partial class ChatUIController
    {
        public List<MessageData> IntegrationMessagedata { get; set; }
        public List<MessageData> BotMessagedata { get; set; }
        public List<MessageData> WalterMessagedata { get; set; }
        public List<MessageData> LauraMessagedata { get; set; }
        public List<MessageData> TeamsMessagedata { get; set; }
        public List<MessageData> SuyamaMessagedata { get; set; }
        public List<TemplateData> IntegrationListTemplateData { get; set; }
        public List<ToolbarItemModel> HeaderToolbar { get; set; } = new List<ToolbarItemModel>();
        public List<BotDataModel> BotData = new List<BotDataModel>();
        public string[] ChatIntegrationSuggestions;

        public ActionResult ChatIntegration()
        {

            ChatIntegrationSuggestions = new string[] { "Bedroom", "Kitchen" };
            HeaderToolbar.Add(new ToolbarItemModel { tooltipText = "Audio call", align = "Right", iconCss = "sf-icon-phone-call" });

            BotData = new List<BotDataModel>
            {
                new BotDataModel
                {
                    text = "Bedroom",
                    reply = "For a bedroom, we can create a serene and calm atmosphere with neutral colors and comfortable bedding.",
                    suggestions = new List<string> { "Garden", "Balcony" }
                },
                new BotDataModel
                {
                    text = "Kitchen",
                    reply = "For a kitchen, we can go for a modern, sleek look with stainless steel appliances and minimalist cabinetry. </br> <p>Any other home decor suggestions you'd like to explore ?</p>",
                    suggestions = new List<string> { "Wall art", "Plants" }
                }
            };
            IntegrationListTemplateData = new List<TemplateData>
            {
                new TemplateData
                {
                    id = "01",
                    title = "Albert",
                    imgSrc = "andrew",
                    message = "Okay, I'll try that. Thanks for the help!"
                },
                new TemplateData
                {
                    id = "02",
                    title = "Bot",
                    imgSrc = "bot",
                    message = "Personal decor assistant"
                },
                new TemplateData
                {
                    id = "03",
                    title = "Charlie",
                    imgSrc = "charlie",
                    message = "Great! Let's finalize our plans this weekend."
                },
                new TemplateData
                {
                    id = "04",
                    title = "Laura",
                    imgSrc = "laura",
                    message = "10 AM works for me."
                },
                new TemplateData
                {
                    id = "05",
                    title = "New Dev Team",
                    imgSrc = "calendar",
                    message = "User added"
                },
                new TemplateData
                {
                    id = "06",
                    title = "Reena",
                    imgSrc = "reena",
                    message = "Hi, are you available ?"
                }
            };

            IntegrationMessagedata = new List<MessageData>
            {
                new MessageData
                {
                    author = new Author { id = "user1", user = "Reena", avatarUrl = "./../Content/chatui/images/reena.png" },
                    text = "Hey, I'm having trouble with my computer. It keeps freezing."
                },
                new MessageData
                {
                    author = new Author { id = "user2", user = "Albert", avatarUrl = "./../Content/chatui/images/andrew.png" },
                    text = "Oh, that's annoying. Have you tried restarting it?"
                },
                new MessageData
                {
                    author = new Author { id = "user1", user = "Reena", avatarUrl = "./../Content/chatui/images/reena.png" },
                    text = "Yeah, I did, but it didn't help."
                },
                new MessageData
                {
                    author = new Author { id = "user2", user = "Albert", avatarUrl = "./../Content/chatui/images/andrew.png" },
                    text = "Sometimes, outdated software or malware can cause issues."
                },
                new MessageData
                {
                    author = new Author { id = "user1", user = "Reena", avatarUrl = "./../Content/chatui/images/reena.png" },
                    text = "Okay, I'll try that. Thanks for the help!"
                }
            };

            BotMessagedata = new List<MessageData>
            {
                new MessageData
                {
                    author = new Author { id = "bot", user = "Bot", avatarUrl = "./../Content/chatui/images/bot.png" },
                    text = "Hello Sam, I am a virtual assistant."
                },
                new MessageData
                {
                    author = new Author { id = "bot", user = "Bot", avatarUrl = "./../Content/chatui/images/bot.png" },
                    text = "Which room are you looking to decorate?"
                }
            };

            WalterMessagedata = new List<MessageData>
            {
                new MessageData
                {
                    author = new Author { id = "user2", user = "Sam", avatarUrl = "./../Content/chatui/images/laura.png" },
                    text = "Hey Charlie, have you thought about where you want to go for our vacation?"
                },
                new MessageData
                {
                    author = new Author { id = "user5", user = "Charlie", avatarUrl = "./../Content/chatui/images/charlie.png" },
                    text = "Hi Sam! I was thinking about going to Bali. I've heard the beaches are beautiful and there's so much to do."
                },
                new MessageData
                {
                    author = new Author { id = "user2", user = "Sam", avatarUrl = "./../Content/chatui/images/laura.png" },
                    text = "Bali sounds amazing! I've always wanted to try surfing. Do you know any good places to stay?"
                },
                new MessageData
                {
                    author = new Author { id = "user5", user = "Charlie", avatarUrl = "./../Content/chatui/images/charlie.png" },
                    text = "Yes, I found a few nice resorts and some budget-friendly options too. I'll send you the links."
                },
                new MessageData
                {
                    author = new Author { id = "user2", user = "Sam", avatarUrl = "./../Content/chatui/images/laura.png" },
                    text = "Great! Let's finalize our plans this weekend."
                }
            };

            LauraMessagedata = new List<MessageData>
            {
                new MessageData
                {
                    author = new Author { id = "user1", user = "Laura Callahan", avatarUrl = "./../Content/chatui/images/laura.png" },
                    text = "Hey Sam, can we have a quick meeting tomorrow morning to discuss the new project?"
                },
                new MessageData
                {
                    author = new Author { id = "user3", user = "Sam", avatarUrl = "./../Content/chatui/images/laura.png" },
                    text = "Sure, what time works best for you?"
                },
                new MessageData
                {
                    author = new Author { id = "user1", user = "Laura Callahan", avatarUrl = "./../Content/chatui/images/laura.png" },
                    text = "10 AM?"
                },
                new MessageData
                {
                    author = new Author { id = "user3", user = "Sam", avatarUrl = "./../Content/chatui/images/laura.png" },
                    text = "10 AM works for me."
                }
            };

            TeamsMessagedata = new List<MessageData>
            {
                new MessageData
                {
                    author = new Author { id = "team", user = "Admin" },
                    text = "Hi, everyone! Welcome to the new web team."
                },
                new MessageData
                {
                    author = new Author { id = "user2", user = "Janet", avatarUrl = "./../Content/chatui/images/janet.png" },
                    text = "Hi Sir, excited about the new team."
                },
                new MessageData
                {
                    author = new Author { id = "user3", user = "Margaret Peacoc" },
                    text = "Good morning! Surprised with the new team message."
                },
                new MessageData
                {
                    author = new Author { id = "user2", user = "Charlie", avatarUrl = "./../Content/chatui/images/charlie.png" },
                    text = "Hi all, what's the purpose of this new team formation?"
                },
                new MessageData
                {
                    author = new Author { id = "team", user = "Admin" },
                    text = "Charlie, we are planning for a new portal launch, hence grouping all in one place."
                }
            };

            SuyamaMessagedata = new List<MessageData>
            {
                new MessageData
                {
                    author = new Author { id = "user4", user = "Reena" },
                    text = "Hi, are you available?"
                }
            };
            ViewBag.IntegrationMessagedata = IntegrationMessagedata;
            ViewBag.BotMessagedata = BotMessagedata;
            ViewBag.WalterMessagedata = WalterMessagedata;
            ViewBag.LauraMessagedata = LauraMessagedata;
            ViewBag.TeamsMessagedata = TeamsMessagedata;
            ViewBag.SuyamaMessagedata = SuyamaMessagedata;
            ViewBag.IntegrationListTemplateData = IntegrationListTemplateData;
            ViewBag.HeaderToolbar = HeaderToolbar;
            ViewBag.BotData = BotData;
            ViewBag.ChatIntegrationSuggestions = ChatIntegrationSuggestions;
            return View();
        }

        public class MessageData
        {
            public Author author { get; set; }
            public string text { get; set; }
        }

        public class Author
        {
            public string id { get; set; }
            public string user { get; set; }
            public string avatarUrl { get; set; }
        }

        public class TemplateData
        {
            public string id { get; set; }
            public string title { get; set; }
            public string imgSrc { get; set; }
            public string message { get; set; }
        }

        public class BotDataModel
        {
            public string text { get; set; }
            public string reply { get; set; }
            public List<string> suggestions { get; set; }
        }
    }
}