using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.StockChart
{
    public partial class StockChartController : Controller
    {
        // GET: Default
        public ActionResult Default()
        {
            //ViewBag.datasource = this.GetChartData();
            return View();
        }
        //public DataStock[] GetChartData()
        //{
        //    string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/StockChartData/aapl.js"));
        //    return JsonConvert.DeserializeObject<DataStock[]>(allText);
        //}
    }
    //public class DataStock
    //{
    //    private DateTime x;
    //    private double open;
    //    private double high;
    //    private double low;
    //    private double close;
    //    private double volume;
    //}
}