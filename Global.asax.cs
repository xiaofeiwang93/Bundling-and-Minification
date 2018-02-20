namespace YourNameSpace
{
    using System;
    using System.Web.Optimization;
    using YourNameSpace.App_Start;

    public class Global : UmbracoApplication
    {
        protected override void Application_Start()
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}