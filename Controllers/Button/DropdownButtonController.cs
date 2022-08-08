using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Button
{
    public partial class ButtonController : Controller
    {
        public ActionResult DropdownButton()
        {
            List<object> items = new List<object>();
            items.Add(new
            {
                text = "Dashboard",
                iconCss = "e-ddb-icons e-dashboard"
            });
            items.Add(new
            {
                text = "Notifications",
                iconCss = "e-ddb-icons e-notifications"
            });
            items.Add(new
            {
                text = "User Settings",
                iconCss = "e-ddb-icons e-settings"
            });
            items.Add(new
            {
                text = "Log Out",
                iconCss = "e-ddb-icons e-logout"
            });

            ViewBag.datasource = items;
            return View();
        }

    }
}