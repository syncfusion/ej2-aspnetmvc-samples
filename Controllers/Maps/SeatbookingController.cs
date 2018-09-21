using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: Seatbooking
        public ActionResult Seatbooking()
        {
            ViewBag.shapeData = this.SeatData();
            return View();
        }
        public object SeatData()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MapData/Seat.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
    }
}