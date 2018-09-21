using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Uploader
{
    public partial class UploaderController : Controller
    {
        // GET: ChunkUpload
        public ActionResult ChunkUpload()
        {
            ViewBag.data = new chunkValues().UploaderModel();
            return View();
        }
    }
}