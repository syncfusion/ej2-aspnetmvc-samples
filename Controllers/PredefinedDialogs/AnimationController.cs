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