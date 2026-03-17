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

namespace EJ2MVCSampleBrowser.Controllers.ColorPicker
{
    public partial class ColorPickerController : Controller
    {
        public ActionResult ColorPickerFor()
        {
            ColorPickerModel model = new ColorPickerModel();
            model.colorValue = "#000080";
            return View(model);
        }
        [HttpPost]
        public ActionResult ColorPickerFor(ColorPickerModel model)
        {
            return View(model);
        }
    }

    public class ColorPickerModel
    {
        [RegularExpression("^((?!#000080).)*$", ErrorMessage = "Please select color with value other than #000080.")]
        public string colorValue { get; set; }
    }

}
