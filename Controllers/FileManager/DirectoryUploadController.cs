using Syncfusion.EJ2.FileManager;
using Syncfusion.EJ2.Navigations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class FileManagerController : Controller
    {
        // GET: DirectoryUpload
        public ActionResult DirectoryUpload()
        {
            return View();
        }

        public ActionResult UploadButtonTemplate()
        {
            return PartialView();
        }
    }
}
