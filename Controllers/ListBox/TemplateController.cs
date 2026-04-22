#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.ListBox
{
    public partial class ListBoxController : Controller
    {
        public ActionResult Template()
        {
            List<object> data = new List<object>();
            data.Add(new { text= "JavaScript", pic = "javascript", description = "It is a lightweight interpreted or JIT-compiled programming language." });
            data.Add(new { text= "TypeScript", pic = "typescript", description = "It is a typed superset of JavaScript that compiles to plain JavaScript." });
            data.Add(new { text= "Angular", pic = "angular", description = "It is a TypeScript-based open-source web application framework." });
            data.Add(new { text= "React", pic = "react", description = "A JavaScript library for building user interfaces. It can also render on the server using Node." });
            data.Add(new { text= "Vue", pic = "vue", description = "A progressive framework for building user interfaces. it is incrementally adoptable." });
            ViewData["data"] = data;
            return View();
        }
    }

}