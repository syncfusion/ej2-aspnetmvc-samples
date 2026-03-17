#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
            //ViewData["datasource"] = this.GetChartData();
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