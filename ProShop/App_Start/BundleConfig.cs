using System.Web;
using System.Web.Optimization;

namespace ProShop
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Public/vendor/jquery/jquery.min.js"));
         

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Public/vendor/bootstrap/js/bootstrap.bundle.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Public/vendor/bootstrap/css/bootstrap.css",
                      "~/Public/css/Site.css",
                      "~/Public/css/shop-homepage.css"));
        }
    }
}
