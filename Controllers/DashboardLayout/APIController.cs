using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class DashboardLayoutController : Controller
    {
        // GET: API
        public ActionResult API()
        {
            spacingModel modelValue = new spacingModel();
            modelValue.cellSpacing = new double[] { 10, 10 };
            return View(modelValue);
        }
    }
}