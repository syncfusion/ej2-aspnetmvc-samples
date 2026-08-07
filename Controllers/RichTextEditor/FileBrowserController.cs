using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class RichTextEditorController : Controller
    {
        public ActionResult FileBrowser()
        {
            string hostUrl = "https://services.syncfusion.com/aspnet/production/";
            ViewData["Items"] = new[] { "FileManager", "Image" };
            ViewData["AjaxSettings"] = new
            {
                url = hostUrl + "api/RichTextEditor/FileOperations",
                getImageUrl = hostUrl + "api/RichTextEditor/GetImage",
                uploadUrl = hostUrl + "api/RichTextEditor/Upload",
                downloadUrl = hostUrl + "api/RichTextEditor/Download"
            };
            return View();
        }
    }
}
