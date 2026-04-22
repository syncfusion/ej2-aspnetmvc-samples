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
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Popups;
using EJ2MVCSampleBrowser.Controllers.Dialog;

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        // GET: Grouping
        public ActionResult Grouping()
        {
            var order = OrdersDetails.GetAllRecords();
            ViewData["datasource"] = order;
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "alertBtnClick", ButtonModel = new customButtonModel() { content = "OK", isPrimary = true } });
            ViewData["alertbutton"] = buttons;
            return View();
        }
    }
}
