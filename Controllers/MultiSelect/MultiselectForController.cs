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
using EJ2MVCSampleBrowser.Models;
using System.ComponentModel.DataAnnotations;
using Syncfusion.EJ2.DropDowns;

namespace EJ2MVCSampleBrowser.Controllers
{
    public class MultiselectModel
    {
        [Required(ErrorMessage = "Value is required")]
        public string[] val { get; set; }
        public string[] data { get; set; }
    }
    public partial class MultiSelectController : Controller
    {
        public string[] datasource = new string[] { "American Football", "Badminton", "Basketball", "Cricket", "Football", "Golf", "Hockey", "Rugby", "Snooker", "Tennis" };

        public ActionResult MultiselectFor()
        {
            MultiselectModel model = new MultiselectModel();
            model.data = datasource;
            return View(model);
        }
        [HttpPost]
        public ActionResult MultiselectFor(MultiselectModel model)
        {
            //posted value is obtained from the model
            model.data = datasource;
            model.val = model.val;
            return View(model);
        }
    }
}
