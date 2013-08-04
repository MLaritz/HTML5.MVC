using System.Web.Optimization;

namespace Html5.Mvc
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Scripts

            bundles.Add(new ScriptBundle("~/bundles/html5shiv")
                .Include("~/Scripts/html5shiv.js"));

            bundles.Add(new ScriptBundle("~/bundles/html5shiv-printshiv")
                .Include("~/Scripts/html5shiv-printshiv.js"));

            //Styles

            bundles.Add(new StyleBundle("~/content/css")
                            .Include("~/Content/normailize.css",
                                     "~/Content/site.css"));
        }
    }
}