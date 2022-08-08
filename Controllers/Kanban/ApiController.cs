using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Popups;
namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class KanbanController : Controller
    {
        public ActionResult Api()
        {
            ViewBag.data = new KanbanDataModels().KanbanTasks();
            ViewBag.ApiDropDown = new KanbanDataModels().ApiData();
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "dlgButtonClick", ButtonModel = new CustomButtonModel() { content = "OK", isPrimary = true } });
            ViewBag.DefaultButtons = buttons;
            return View();
        }
    }
    public class CustomButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
}