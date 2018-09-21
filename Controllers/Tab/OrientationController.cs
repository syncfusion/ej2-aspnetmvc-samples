using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Navigations;
using Syncfusion.EJ2.Lists;

namespace EJ2MVCSampleBrowser.Controllers.Tab
{
    public partial class TabController : Controller
    {
        List<TabTabItem> orientationItems = new List<TabTabItem>();
        public ActionResult Orientation()
        {
            List<object> rome = new List<object>();
            rome.Add(new { Id = "1", Name = "Anne Dodsworth", Role = "Product Manager", imgSrc = Url.Content("~/Content/tab/1.png") });
            rome.Add(new { Id = "2", Name = "Laura Callahan", Role = "Team Lead", imgSrc = Url.Content("~/Content/tab/2.png") });
            rome.Add(new { Id = "3", Name = "Andrew Fuller", Role = "Developer", imgSrc = Url.Content("~/Content/tab/3.png") });
            ViewBag.romeData = rome;

            List<object> paris = new List<object>();
            paris.Add(new { Id = "4", Name = "Robert King", Role = "Team Lead", imgSrc = Url.Content("~/Content/tab/4.png") });
            paris.Add(new { Id = "5", Name = "Michael Suyama", Role = "Developer", imgSrc = Url.Content("~/Content/tab/5.png") });
            paris.Add(new { Id = "6", Name = "Margaret Peacock", Role = "Developer", imgSrc = Url.Content("~/Content/tab/6.png") });
            ViewBag.parisData = paris;

            List<object> london = new List<object>();
            london.Add(new { Id = "7", Name = "Janet Leverling", Role = "CEO", imgSrc = Url.Content("~/Content/tab/7.png") });
            london.Add(new { Id = "8", Name = "Steven Buchanan", Role = "HR", imgSrc = Url.Content("~/Content/tab/8.png") });
            london.Add(new { Id = "9", Name = "Nancy Davolio", Role = "Product Manager", imgSrc = Url.Content("~/Content/tab/9.png") });
            ViewBag.londonData = london;

            orientationItems.Add(new TabTabItem { Header = new TabHeader { Text = "Rome" }, Content = "#rome" });
            orientationItems.Add(new TabTabItem { Header = new TabHeader { Text = "Paris" }, Content = "#paris" });
            orientationItems.Add(new TabTabItem { Header = new TabHeader { Text = "London" }, Content = "#london" });
            ViewBag.orientationItems = orientationItems;

            ViewBag.styleData = new string[] { "Default", "Fill", "Accent" };
            ViewBag.orientationData = new string[] { "Top", "Bottom" };

            return View();
        }
    }

}