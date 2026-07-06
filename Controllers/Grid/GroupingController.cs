using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Popups;

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
            buttons.Add(new DialogDialogButton() { Click = "alertBtnClick", ButtonModel = new DefaultButtonModel() { content = "OK", isPrimary = true } });
            ViewData["alertbutton"] = buttons;
            return View();
        }
    }
}
