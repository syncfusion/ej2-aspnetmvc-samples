using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class DashboardLayoutController : Controller
    {
        // GET: PredefinedLayouts
        public ActionResult PredefinedLayouts()
        {
            spacingModel modelValue = new spacingModel();
            modelValue.cellSpacing = new double[] { 5, 5 };
            return View(modelValue);
        }
    }
}