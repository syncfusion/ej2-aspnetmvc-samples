using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.ListView
{
    public partial class ListViewController : Controller
    {
        // GET: ListView
        public ActionResult RemoteData()
        {           
            return View();
        }
    }
}