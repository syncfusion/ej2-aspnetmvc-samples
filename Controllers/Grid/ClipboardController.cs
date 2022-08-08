using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Controllers.Dialog;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Popups;

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        // GET: Clipboard
        public ActionResult Clipboard()
        {
            var order = OrdersDetails.GetAllRecords();
            ViewBag.datasource = order;
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "alertBtnClick", ButtonModel = new customButtonModel() { content = "OK", isPrimary = true } });
            ViewBag.alertbutton = buttons;
            return View();
        }
    }
}