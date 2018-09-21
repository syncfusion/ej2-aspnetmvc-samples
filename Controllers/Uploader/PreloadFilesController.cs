using Syncfusion.EJ2.Inputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Uploader
{
    public partial class UploaderController : Controller
    {
        // GET: PreloadFiles
        List<UploaderUploadedFiles> list = new List<UploaderUploadedFiles>();
        public ActionResult PreloadFiles()
        {
            list.Add(new UploaderUploadedFiles { Name = "Nature", Size = 500000, Type = ".png" });
            list.Add(new UploaderUploadedFiles { Name = "TypeScript Succintly", Size = 12000, Type = ".pdf" });
            list.Add(new UploaderUploadedFiles { Name = "ASP.NET Webhooks", Size = 500000, Type = ".docx" });

            ViewBag.datasource = list;
            return View();
        }
    }
}