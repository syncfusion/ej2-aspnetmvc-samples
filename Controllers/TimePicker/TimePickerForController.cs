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
using Syncfusion.EJ2.Calendars;
namespace EJ2MVCSampleBrowser.Controllers
{
    public class TimePickerModel
    {
        [Required(ErrorMessage = "Value is required")]
        public DateTime? objectValue { get; set; }
    }
    public partial class TimePickerController : Controller
    {
        TimePickerModel timepicker = new TimePickerModel();
        public ActionResult TimePickerFor()
        {
            // GET: TimePickerFor
            timepicker.objectValue = DateTime.Now;
            return View(timepicker);
        }
        [HttpPost]
        public ActionResult TimePickerFor(TimePickerModel model)
        {
            //posted value is obtained from the model
            timepicker.objectValue = model.objectValue;
            return View(timepicker);
        }
    }
}