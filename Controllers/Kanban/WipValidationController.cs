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
        public ActionResult WipValidation()
        {
            ViewData["data"] = new KanbanDataModels().KanbanTasks();
            ViewData["ColumnDropDowns"] = new KanbanDataModels().ColumnDropDowns();
            ViewData["StatusData"] = new KanbanDataModels().StatusData();
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "dlgButtonClick", ButtonModel = new DefaultButtonModel() { content = "OK", isPrimary = true } });
            ViewData["DefaultButtons"] = buttons;
            return View();
        }
    }
    public class DefaultButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
}