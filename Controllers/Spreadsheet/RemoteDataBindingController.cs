using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Spreadsheet;

namespace EJ2MVCSampleBrowser.Controllers.Spreadsheet
{
    public partial class SpreadsheetController : Controller
    {
        public ActionResult RemoteDataBinding()
        {
            return View();
        }

        public ActionResult RemoteDataOpen(OpenRequest openRequest)
        {
            return Content(Workbook.Open(openRequest));
        }

        public void RemoteDataSave(SaveSettings saveSettings)
        {
            Workbook.Save(saveSettings);
        }
    }
}