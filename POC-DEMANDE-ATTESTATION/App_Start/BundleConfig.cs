using System.Web;
using System.Web.Optimization;

namespace POC_DEMANDE_ATTESTATION
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.UseCdn = true;
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery/dist/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
                        "~/Scripts/popper.js/dist/umd/popper.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap/dist/js/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                      "~/Scripts/js/custom.js"));

            bundles.Add(new ScriptBundle("~/bundles/datePicker").Include(
                      "~/Scripts/bootstrap/dist/js/bootstrap-datepicker.min.js"));

          

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Content/cerulean/bootstrap.css",
                      "~/Content/custom.min.css",
                      "~/Content/Site.css",
                      "~/Content/nav.css",
                      "~/Content/cerulean/bootstrap-datepicker3.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
