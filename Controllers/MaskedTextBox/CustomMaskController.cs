using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class MaskedTextBoxController : Controller
    {
        public ActionResult CustomMask()
        {

            CustomCharacters customObj = new CustomCharacters();
            customObj.P = "P,A,a,p";
            customObj.M = "M,m";
            ViewBag.cusObj = customObj;

            return View();
        }

        public class CustomCharacters
        {
            public string P { get; set; }
            public string M { get; set; }
        }
    }

}