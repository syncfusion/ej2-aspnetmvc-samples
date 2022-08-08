using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Syncfusion.EJ2.Inputs;

namespace EJ2MVCSampleBrowser.Controllers

{
    public class TextBoxModal
    {
        [Required(ErrorMessage = "Value is required")]
        public string firstname { get; set; }
    }
    public partial class TextboxesController : Controller
    {
        TextBoxModal textbox = new TextBoxModal();
        // GET: TextboxFor
        public ActionResult TextboxFor()
        {
            textbox.firstname = "John";
            return View(textbox);
        }
        [HttpPost]
        public ActionResult TextboxFor(TextBoxModal model)
        {
            //posted value is obtained from the model
            textbox.firstname = model.firstname;
            return View(textbox);
        }
    }
}