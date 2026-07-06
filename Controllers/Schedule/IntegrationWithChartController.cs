#region Copyright Syncfusion®
#endregion

using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult IntegrationWithChart()
        {
            // ✅ ALL DRIVERS – FULL LIST
            var drivers = new List<object>
            {
                new { driver="Ben Smith", id=1, color="#ea7a57", truck="Volvo FH16", capacity="325 t" },
                new { driver="Sarah Johnson", id=2, color="#7fa900", truck="Scania R730", capacity="310 t" },
                new { driver="Mike Chen", id=3, color="#5978ee", truck="Mercedes Actros", capacity="290 t" },
                new { driver="Emma Davis", id=4, color="#fec200", truck="MAN TGX", capacity="280 t" },
                new { driver="Carlos Rodriguez", id=5, color="#df5286", truck="DAF XF", capacity="300 t" },
                new { driver="Olivia Wilson", id=6, color="#00bdae", truck="Kenworth T680", capacity="315 t" },
                new { driver="James Taylor", id=7, color="#865fcf", truck="Peterbilt 579", capacity="305 t" },
                new { driver="Sophia Martinez", id=8, color="#1aaa55", truck="Freightliner Cascadia", capacity="295 t" },
                new { driver="Daniel Lee", id=9, color="#df5286", truck="Mack Anthem", capacity="285 t" },
                new { driver="Ava Thompson", id=10, color="#710193", truck="International LT", capacity="275 t" }
            };

            // ✅ ALL EVENTS – FULL LIST
            var events = new List<object>
            {
                new { Id=1,  Subject="Long haul trip",        StartTime=new DateTime(2026,1,14,2,30,0), EndTime=new DateTime(2026,1,14,7,30,0), DriverID=1 },
                new { Id=2,  Subject="Delivery to New York", StartTime=new DateTime(2026,1,12,18,30,0),EndTime=new DateTime(2026,1,13,6,30,0), DriverID=2 },
                new { Id=3,  Subject="Cross-country route", StartTime=new DateTime(2026,1,13,0,40,0), EndTime=new DateTime(2026,1,13,4,30,0), DriverID=3 },
                new { Id=4,  Subject="Refrigerated goods",  StartTime=new DateTime(2026,1,13,8,30,0), EndTime=new DateTime(2026,1,13,19,30,0),DriverID=4 },
                new { Id=5,  Subject="Container transport", StartTime=new DateTime(2026,1,12,20,30,0),EndTime=new DateTime(2026,1,13,3,30,0), DriverID=5 },
                new { Id=6,  Subject="Food products",       StartTime=new DateTime(2026,1,12,12,30,0),EndTime=new DateTime(2026,1,13,9,30,0), DriverID=7 },
                new { Id=7,  Subject="Medical supplies",    StartTime=new DateTime(2026,1,13,1,30,0), EndTime=new DateTime(2026,1,13,7,30,0), DriverID=9 },
                new { Id=8,  Subject="Delivery to India",   StartTime=new DateTime(2026,1,14,18,30,0),EndTime=new DateTime(2026,1,15,6,30,0), DriverID=2 },
                new { Id=9,  Subject="Delivery to UK",      StartTime=new DateTime(2026,1,15,8,30,0), EndTime=new DateTime(2026,1,15,19,30,0),DriverID=4 },
                new { Id=10, Subject="Delivery to Germany", StartTime=new DateTime(2026,1,16,8,30,0), EndTime=new DateTime(2026,1,16,19,30,0),DriverID=4 },
                new { Id=11, Subject="Delivery to Japan",   StartTime=new DateTime(2026,1,15,12,30,0),EndTime=new DateTime(2026,1,15,19,30,0),DriverID=7 }
            };

            // ✅ PASS TO VIEW (JSON)
            ViewData["Drivers"] = JsonConvert.SerializeObject(drivers);
            ViewData["Events"] = JsonConvert.SerializeObject(events);

            return View();
        }
    }
}