using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Chips
{
    public partial class ChipsController : Controller
    {
        public ActionResult Default()
        {

            int[] choiceSelected = { 1 };
            int[] filterSelected = { 1, 3 };
            ViewBag.choiceSelected = choiceSelected;
            ViewBag.filterSelected = filterSelected;
            return View();

        }
    }
}