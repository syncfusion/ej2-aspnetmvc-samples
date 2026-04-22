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
    public class DateRangePickerModel
    {
        [Required(ErrorMessage = "Value is required")]
        public DateTime[] objectValue { get; set; }
    }
    public partial class DateRangePickerController : Controller
    {
        DateRangePickerModel daterangepicker = new DateRangePickerModel();
        public ActionResult DateRangePickerFor()
        {
            // GET: DateRangePickerFor
            daterangepicker.objectValue = new DateTime[] { new DateTime(2020, 05, 23, 10, 05, 05), new DateTime(2020, 06, 03, 15, 10, 35) };
            return View(daterangepicker);
        }
        [HttpPost]
        public ActionResult DateRangePickerFor(DateRangePickerModel model)
        {
            //posted value is obtained from the model
            daterangepicker.objectValue = model.objectValue;
            return View(daterangepicker);
        }
    }
}