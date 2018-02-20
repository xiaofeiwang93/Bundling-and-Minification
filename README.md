# Bundling-and-Minification
First thing to do before doing any programming: Install-Package Microsoft.AspNet.Web.Optimization

Go to App_Start, create a new class and name it Bundle.Config. Then edit the file as shown in the BundleConfig.cs.

Next, go to Global.asax.cs and add Bundle reference (using System.Web.Optimization; using YourNameSpace.App_Start;).

Finally, go to Master.cs, copy and paste virtual path from BundleConfig.cs.

It will only work under release mode.