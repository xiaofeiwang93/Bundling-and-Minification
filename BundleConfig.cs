namespace YourNameSpace.App_Start
{
    using System.Web.Optimization;

    using Umbraco.Core.Logging;

    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            var cssBundle = new StyleBundle("~/bundles/css")
                .Include("~/Content/screen.css", new CssRewriteUrlTransform()) 
                .Include("~/Content/print.css", new CssRewriteUrlTransform());
                //CssRewriteUrlTransform() Rewrites urls to be absolute so assets will still be found after bundling.

            bundles.Add(cssBundle);
            bundles.Add(new ScriptBundle("~/bundles/js").Include("~/scripts/script.js")); //new ScriptBundle(virtual path)

            LogHelper.Info<string>("Bundles Loaded");
        }
    }
}