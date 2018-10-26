using System.Web;
using System.Web.Optimization;

namespace Library
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/assets/plugins/bootstrap-toastr/toastr.min.js",
                        "~/assets/plugins/bootstrap-sweetalert/sweetalert.min.js",
                        "~/assets/plugins/jstree/dist/jstree.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/font-awesome/css/font-awesome.min.css",
                      "~/assets/plugins/bootstrap-toastr/toastr-rtl.min.css",
                      "~/assets/plugins/bootstrap-sweetalert/sweetalert.css",
                      "~/assets/plugins/jstree/dist/themes/default/style.min.css"
                      //"~/Content/site.css"
                      ));
        }
    }
}
