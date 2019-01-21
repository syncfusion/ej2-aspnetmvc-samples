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
        public ActionResult CheckBoxFor()
        {
            CheckBoxModel model = new CheckBoxModel();
            model.check = true;
            return View(model);
        }
        
        [HttpPost]
        public ActionResult CheckBoxFor(CheckBoxModel model)
        {
            return View(model);
        }
    }

    public class CheckBoxModel
    {
        [Range(typeof(bool), "true", "true", ErrorMessage = "You need to agree to the Terms and Conditions")]
        public bool check { get; set; }
    }

}