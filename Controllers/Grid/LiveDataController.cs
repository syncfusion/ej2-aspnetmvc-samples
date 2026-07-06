using EJ2MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        // GET: LiveData
        public ActionResult LiveData()
        {
            ViewData["Data"] = EJ2MVCSampleBrowser.Models.LiveData.GetLiveDatas(100);
            return View();
        }
    }
}