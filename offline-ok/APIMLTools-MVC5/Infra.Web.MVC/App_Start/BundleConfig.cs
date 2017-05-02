using System.Web;
using System.Web.Optimization;

namespace tools.App {
    public class BundleConfig {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      //"~/Scripts/bootstrap.js",
                      //"~/Scripts/bootstrap.min.js",
                      //"~/Scripts/jquery.dynamic.js",
                      //"~/Scripts/jResponde.min.js",
                      //"~/Scripts/main.js",
                      "~/tpl/js/bootstrap.js",
                      "~/tpl/vendor/jquery/jquery.js",
                      "~/tpl/vendor/common/common.js",
                      "~/tpl/js/views/view.home.js",
                      "~/tpl/js/views/view.contact.js",
                      "~/tpl/js/custom.js",                      
                      "~/tpl/js/theme.init.js",   
                      "~/tpl/js/theme.js",
                      "~/tpl/js/style.switcher.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      //"~/Content/bootstrap.css",
                      "~/Content/bootstrap.min.css",
                      //"~/Content/custom.css",
                      //"~/Content/main.css",
                      //"~/Content/plugins.css",
                      "~/tpl/css/bootstrap.css",
                      "~/tpl/css/theme.css",
                      "~/tpl/css/theme-elements.css",
                      "~/tpl/css/theme-blog.css",
                      "~/tpl/css/theme-shop.css",
                      "~/tpl/css/theme-animate.css",
                      "~/tpl/css/skins/default.css",
                      "~/tpl/css/custom.css"));
                      //"~/Content/site.css"));


        }
    }
}
