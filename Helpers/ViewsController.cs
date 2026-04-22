#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
