#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.EJ2.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.SpeechToText
{
    public partial class SpeechToTextController : Controller
    {
        public ActionResult DefaultFunctionalities()
        {
            List<object> color = new List<object>();
            color.Add( new { text="Normal", value=""});
            color.Add( new { text="Primary", value="e-primary"});
            color.Add( new { text="Success", value="e-success"});
            color.Add( new { text="Warning", value="e-warning"});
            color.Add( new { text="Danger", value="e-danger"});
            color.Add( new { text="Flat", value="e-flat"});
            color.Add( new { text="Info", value="e-info"});
            ViewData["color"] = color;

            List<object> language = new List<object>();
            language.Add( new { text="English, US", value="en-US" });
            language.Add( new { text="German, DE", value="de-DE" });
            language.Add( new { text="Chinese, CN", value="zh-CN" });
            language.Add( new { text="French, FR", value="fr-FR" });
            language.Add( new { text="Arabic, SA", value="ar-SA" });
            ViewData["language"] = language;
            return View();
        }
    }
}