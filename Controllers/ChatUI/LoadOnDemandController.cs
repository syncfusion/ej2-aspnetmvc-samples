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
        public UserModel CurrentUserModel { get; set; }
        public UserModel MichaleUserModel { get; set; }

        public ActionResult LoadOnDemand()
        {
            CurrentUserModel = new UserModel() { id = "user1", user = "Albert" };
            MichaleUserModel = new UserModel() { id = "user2", user= "Michale Suyama", avatarUrl= "./../Content/chatui/images/andrew.png" };
            ViewBag.currentUserModel = CurrentUserModel;
            ViewBag.michaleUserModel = MichaleUserModel;             
            return View();
        }
    }

    public class UserModel
    {
        public string id { get; set; }
        public string user { get; set; }
    }
}