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
            dataList.Add(new { Type = "Over", value = "Over" });
            dataList.Add(new { Type = "Push", value = "Push" });
            dataList.Add(new { Type = "Slide", value = "Slide" });
            dataList.Add(new { Type = "Auto", value = "Auto" });
            Dictionary<string, object> HtmlAttribute = new Dictionary<string, object>()
            {   {"class", "default-sidebar" } };
            ViewBag.HtmlAttribute = HtmlAttribute;
            ViewBag.Types = dataList;
            return View();
        }
    }
}