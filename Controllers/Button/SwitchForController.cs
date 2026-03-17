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
using System.ComponentModel.DataAnnotations;

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

    public class SwitchModel
    {
        [Range(typeof(bool), "true", "true", ErrorMessage = "You need to agree to receive newsletter")]
        public bool check { get; set; }
    }

}