using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EJ2MVCSampleBrowser.Helpers
{
    public class ViewsController : Controller
    {  
        public ContentResult Index(string path)
        {
            var localPath = Server.MapPath("~/" + path);
            var cont = System.IO.File.ReadAllText(localPath);
            return Content(cont);
        }
    }

    public class SampleHelpers
    {
#if DEBUG
        public static bool IsDebug = true;
#else
        public static bool IsDebug = false;
#endif
    }
}
