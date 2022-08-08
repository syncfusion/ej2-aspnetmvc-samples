using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EJ2MVCSampleBrowser.Controllers.Button
{
    public partial class ButtonController : Controller
    {
        public ActionResult RadioButtonFor()
        {
            RadioButtonModel model = new RadioButtonModel();
            model.gender = "female";
            return View(model);
        }

        [HttpPost]
        public ActionResult RadioButtonFor(RadioButtonModel model)
        {
            return View(model);
        }
    }

    public class RadioButtonModel
    {
        [RegularExpression("male", ErrorMessage = "Male gender is required.")]
        public string gender { get; set; }
    }

}