using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
namespace EJ2MVCSampleBrowser.Controllers.Sparkline
{
    public partial class SparklineController : Controller
    {
        // GET: Sparkgrid
        public ActionResult Sparkgrid()
        {
            ViewBag.dataSource = this.getDataSource("OrderData");
            return View();
        }
        public object getDataSource(string filename)
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/OrderData.js"));
            return JsonConvert.DeserializeObject(allText);
        }
    }
}