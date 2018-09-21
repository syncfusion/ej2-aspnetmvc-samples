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
    public class DatePickerModel
    {
        [Required(ErrorMessage = "Value is required")]
        public DateTime? objectValue { get; set; }
    }
    public partial class DatePickerController : Controller
    {
        DatePickerModel datepicker = new DatePickerModel();
        public ActionResult DatePickerFor()
        {
            // GET: DatePickerFor
            datepicker.objectValue = DateTime.Now;
            return View(datepicker);
        }
        [HttpPost]
        public ActionResult DatePickerFor(DatePickerModel model)
        {
            //posted value is obtained from the model
            datepicker.objectValue = model.objectValue;
            return View(datepicker);
        }
    }
}