using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Syncfusion.Licensing;
using System.IO;

namespace EJ2MVCSampleBrowser
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            if (File.Exists(Server.MapPath("SyncfusionLicense.txt")))
            {
                string licenseKey = System.IO.File.ReadAllText(Server.MapPath("SyncfusionLicense.txt"), Encoding.UTF8);
                SyncfusionLicenseProvider.RegisterLicense(licenseKey);
            }
        }
    }
}
