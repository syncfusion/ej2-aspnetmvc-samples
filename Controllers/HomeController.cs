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
using System.Reflection;
using System.Text;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace EJ2MVCSampleBrowser.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("gridoverview", "grid");
        }
        public ActionResult SitemapXml()
        {
            string xml = GetSiteMapdocument();
            return this.Content(xml, System.Net.Mime.MediaTypeNames.Text.Xml, Encoding.UTF8);
        }

        [HttpGet]
        public string GetHtml(string path)
        {
            var localPath = Server.MapPath("~/"+ path);                       
            return System.IO.File.ReadAllText(localPath);
        }

        private string GetSiteMapdocument()
        {
            XNamespace xmlns = "http://www.sitemaps.org/schemas/sitemap/0.9";
            XElement root = new XElement(xmlns + "urlset");
            var controllers = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => typeof(Controller).IsAssignableFrom(type)
                || type.Name.EndsWith("controller")).ToList();
            string path = Request.Url.ToString().Replace("sitemap.xml", "");
            if (Request.Url.ToString().IndexOf("aspnetmvc.syncfusion.com") > -1)
            {
                path = "https://ej2.syncfusion.com/aspnetmvc/demos/";
            }

            foreach (var controller in controllers)
            {
                if (controller.Name.Replace("Controller", "").IndexOf("Views") == -1 && controller.Name.Replace("Controller", "").IndexOf("Home") == -1)
                {
                    var methods = controller.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                        .Where(method => typeof(ActionResult).IsAssignableFrom(method.ReturnType));
                    foreach (var method in methods)
                    {
                        string url = path + controller.Name.Replace("Controller", "") + "/" + method.Name;
                        XElement urlElement = new XElement(
                xmlns + "url",
                new XElement(xmlns + "loc", Uri.EscapeUriString(url)),
                 new XElement(
                    xmlns + "lastmod",
                    DateTime.UtcNow.ToString("yyyy-MM-dd")));
                        root.Add(urlElement);
                    }
                }
            }

            XDocument document = new XDocument(root);
            return document.ToString();
        }
    }
}
