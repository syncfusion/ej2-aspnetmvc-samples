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