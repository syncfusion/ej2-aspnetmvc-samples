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
        public ActionResult Image()
        {
            return View();
        }

        public ActionResult ImageOpen(OpenRequest openRequest)
        {
            return Content(Workbook.Open(openRequest));
        }

        public void ImageSave(SaveSettings saveSettings)
        {
            Workbook.Save(saveSettings);
        }
    }
}