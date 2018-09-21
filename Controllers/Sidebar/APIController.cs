using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class SidebarController : Controller
    {
        // GET: API
        public ActionResult API()
        {
            List<object> dataList = new List<object>();
            dataList.Add(new { text = "over" });
            dataList.Add(new { text = "push" });
            dataList.Add(new { text = "slide" });
            dataList.Add(new { text = "auto" });
            ViewBag.dataSource = dataList;
            object fields = new { type = "text" };
            return View();
        }
    }
}