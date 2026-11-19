using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Syncfusion.EJ2.Inputs;

namespace EJ2MVCSampleBrowser.Controllers

{
    public class TextAreaModal
    {
        [Required(ErrorMessage = "Value is required")]
        public string comments { get; set; }
    }
    public partial class TextAreaController : Controller
    {
        TextAreaModal textarea = new TextAreaModal();
        // GET: TextAreaFor
        public ActionResult TextAreaFor()
        {
            textarea.comments = "";
            return View(textarea);
        }
        [HttpPost]
        public ActionResult TextAreaFor(TextAreaModal model)
        {
            //posted value is obtained from the model
            textarea.comments = model.comments;
            return View(textarea);
        }
    }
}