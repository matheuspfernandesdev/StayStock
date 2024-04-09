using System.Web.Optimization;

namespace UI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/BundlesBase/js")
                .Include(
                //"~/Content/js/jquery.min.js",
                "~/Content/js/nprogress.js",
                "~/Content/js/bootstrap.min.js",
                "~/Content/js/progressbar/bootstrap-progressbar.min.js",
                "~/Content/js/nicescroll/jquery.nicescroll.min.js",
                "~/Content/js/moment/moment.min.js",
                "~/Content/js/icheck/icheck.min.js",
                "~/Content/js/custom.js",
                "~/Content/js/jquery.mask.js",
                "~/Content/js/validator/validator.js",
                "~/Content/js/validator/multifield.js",
                "~/Content/js/parsley/parsley.min.js",
                "~/Scripts/paginaDefault.js"
            ));

            bundles.Add(new StyleBundle("~/BundlesBase/css")
                .Include(
                "~/Content/bootstrap.min.css",
                "~/Content/fonts/css/font-awesome.min.css",
                "~/Content/css/animate.min.css",
                "~/Content/css/custom.css",
                "~/Content/css/icheck/flat/green.css",
                "~/Content/css/floatexamples.css"
            ));
        }
    }
}
