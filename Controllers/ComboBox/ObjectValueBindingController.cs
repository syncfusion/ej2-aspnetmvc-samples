using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class ComboBoxController : Controller
    {
        public ActionResult ObjectValueBinding()
        {
            ComboBoxRecord model = new ComboBoxRecord();
            model.RecordList = new ComboBoxRecord().RecordModelList();
            return View(model);
        }
    }
}