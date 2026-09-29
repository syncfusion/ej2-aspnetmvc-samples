using System.Web;
using System.Web.Optimization;

namespace EJ2MVCSampleBrowser
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/dependencies").Include(
                      "~/Scripts/samplelist.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            var cssBundle = new StyleBundle("~/Content/css");
            #if RELEASE
                cssBundle.Include("~/Content/site.min.css");    
            #else
                cssBundle.Include("~/Content/site.css");
            #endif
            
            bundles.Add(cssBundle);
        }
    }
}
