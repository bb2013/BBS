using System.Web.Optimization;

namespace Presentation.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            ScriptBundle thirdPartyScripts = new ScriptBundle("~/Scripts");
            thirdPartyScripts.Include("~/Scripts/jquery-{version}.js",
                                "~/Scripts/bootstrap.min.js");

            bundles.Add(thirdPartyScripts);
            BundleTable.EnableOptimizations = true;
        }
    }
}