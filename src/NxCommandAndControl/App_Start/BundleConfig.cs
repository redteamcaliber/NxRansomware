﻿using System.Web;
using System.Web.Optimization;

namespace NxCommandAndControl
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/footerscripts").Include(
                "~/Static/plugins/jQuery/jQuery-2.2.0.min.js",
                "~/Static/bootstrap/js/bootstrap.min.js",
                "~/Static/plugins/iCheck/icheck.min.js"
            ));


            bundles.Add(new StyleBundle("~/bundles/topcss").Include(
                "~/Static/dist/css/AdminLTE.min.css",
                "~/Static/plugins/iCheck/square/blue.css"
            ));


            BundleTable.EnableOptimizations = true;
        }
    }
}
