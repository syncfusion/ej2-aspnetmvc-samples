using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Buttons;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class SpeedDialController : Controller
    {
        public ActionResult Position()
        {
            List<SpeedDialItem> items = new List<SpeedDialItem>();
            items.Add(new SpeedDialItem
                {
                Title = "Image",
                IconCss = "speeddial-icons speeddial-icon-image"
            });
            items.Add(new SpeedDialItem
                {
                Title = "Audio",
                IconCss = "speeddial-icons speeddial-icon-audio"
            });
            items.Add(new SpeedDialItem
                {
                Title = "Video",
                IconCss = "speeddial-icons speeddial-icon-video"
            });

            ViewData["datasource"] = items;
            return View();
        }
    }

}