using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Button
{
    public partial class ButtonController : Controller
    {
        public ActionResult SwitchFor()
        {
            SwitchModel model = new SwitchModel();
            model.check = true;
            return View(model);
        }

        [HttpPost]
        public ActionResult SwitchFor(SwitchModel model)
        {
            return View(model);
        }
    }

}