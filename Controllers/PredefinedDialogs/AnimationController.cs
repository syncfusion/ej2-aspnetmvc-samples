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

namespace EJ2MVCSampleBrowser.Controllers.PredefinedDialogs
{
    public partial class PredefinedDialogsController : Controller
    {
        // GET: Animation
        public ActionResult Animation()
        {
            ViewData["Data"] = EffectList.EffectLists();
            return View();
        }
        public class EffectList
        {
            public string Id { get; set; }
            public string Effect { get; set; }

            public static List<EffectList> EffectLists()
            {
                List<EffectList> effect = new List<EffectList>();
                effect.Add(new EffectList { Id = "FadeZoom", Effect = "Fade zoom" });
                effect.Add(new EffectList { Id = "SlideBottom", Effect = "Slide bottom" });
                effect.Add(new EffectList { Id = "SlideTop", Effect = "Slide top" });
                effect.Add(new EffectList { Id = "Zoom", Effect = "Zoom" });
                effect.Add(new EffectList { Id = "Fade", Effect = "Fade" });
                return effect;
            }
        }
    }
}