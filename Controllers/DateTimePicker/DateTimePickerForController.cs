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
    public class DateTimePickerModel
    {
        [Required(ErrorMessage = "Value is required")]
        public DateTime? objectValue { get; set; }
    }
    public partial class DateTimePickerController : Controller
    {
        DateTimePickerModel datetimepicker = new DateTimePickerModel();
        public ActionResult DateTimePickerFor()
        {
            // GET: DateTimePickerFor
            datetimepicker.objectValue = DateTime.Now;
            return View(datetimepicker);
        }
        [HttpPost]
        public ActionResult DateTimePickerFor(DateTimePickerModel model)
        {
            //posted value is obtained from the model
            datetimepicker.objectValue = model.objectValue;
            return View(datetimepicker);
        }
    }
}