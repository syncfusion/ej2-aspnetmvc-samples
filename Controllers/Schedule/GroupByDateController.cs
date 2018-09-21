using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Schedule;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult GroupByDate()
        {
            ViewBag.datasource = new ScheduleData().GetResourceData();

            List<ResourceDataSourceModel> owners = new List<ResourceDataSourceModel>();
            owners.Add(new ResourceDataSourceModel { text = "Alice", id = 1, color = "#df5286" });
            owners.Add(new ResourceDataSourceModel { text = "Smith", id = 2, color = "#7fa900" });
            ViewBag.Owners = owners;

            string[] resources = new string[] { "Owners" };
            ViewBag.Resources = resources;
            return View();
        }
    }
}