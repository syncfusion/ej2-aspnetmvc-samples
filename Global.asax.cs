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
using System.Web.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Syncfusion.Licensing;
using System.IO;
using System.Net;

namespace EJ2MVCSampleBrowser
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            if (File.Exists(Server.MapPath("SyncfusionLicense.txt")))
            {
                string licenseKey = System.IO.File.ReadAllText(Server.MapPath("SyncfusionLicense.txt"), Encoding.UTF8).Trim();
                SyncfusionLicenseProvider.RegisterLicense(licenseKey);
                if (File.Exists(Server.MapPath("Scripts/index.js")))
                {
                    string regexPattern = "ej.base.registerLicense(.*);";
                    string jsContent = File.ReadAllText(Server.MapPath("Scripts/index.js"), Encoding.UTF8);
                    MatchCollection matchCases = Regex.Matches(jsContent, regexPattern);
                    foreach (Match matchCase in matchCases)
                    {
                        var replaceableString = matchCase.ToString();
                        jsContent = jsContent.Replace(replaceableString, "ej.base.registerLicense('" + licenseKey + "');");
                    }
                    File.WriteAllText(Server.MapPath("Scripts/index.js"), jsContent);
                }
            }
        }
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (Request.Url.AbsolutePath.Contains("/Content/") || Request.Url.AbsolutePath.Contains("/Scripts/") || Request.HttpMethod == "POST")
            {
                return;
            }

            // Check for uppercase characters
            if (Regex.IsMatch(Request.Url.ToString(), @"[A-Z]"))
            {
                var url = Request.Url.ToString().ToLower();
                Response.Clear();
                Response.Status = "301 Moved Permanently";
                Response.StatusCode = (int)HttpStatusCode.MovedPermanently;
                Response.AddHeader("Location", url);
                Response.End();
            }
        }

        protected void Application_AcquireRequestState(object sender, EventArgs e)
        {
#if RELEASE && STAGING
            HttpContext.Current.Items["BuildConfig"] = "Release";
#else
            HttpContext.Current.Items["BuildConfig"] = "Debug";
#endif
        }


    }

}
