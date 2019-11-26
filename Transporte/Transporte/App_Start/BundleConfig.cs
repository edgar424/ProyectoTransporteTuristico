using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Transporte
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

                                            

             bundles.Add(new StyleBundle("~/bundles/css").Include(
             "~/Component/bower_components/bootstrap/dist/css/bootstrap.min.css",
             "~/Component/bower_components/font-awesome/css/font-awesome.min.css",
             "~/Component/bower_components/Ionicons/css/ionicons.min.css",
             "~/Component/bower_components/jvectormap/jquery-jvectormap.css",
             "~/Component/dist/css/AdminLTE.min.css",
             "~/Component/dist/css/skins/_all-skins.min.css"));
                       

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
           "~/Component/bower_components/jquery/dist/jquery.min.js",
           "~/Component/bower_components/bootstrap/dist/js/bootstrap.min.js",
           "~/Component/bower_components/fastclick/lib/fastclick.js",
           "~/Component/dist/js/adminlte.min.js",
           "~/Component/bower_components/jquery-sparkline/dist/jquery.sparkline.min.js",
           "~/Component/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
           "~/Component/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
           "~/Component/bower_components/jquery-slimscroll/jquery.slimscroll.min.js",
           "~/Component/bower_components/chart.js/Chart.js",
           "~/Component/dist/js/pages/dashboard2.js",
           "~/Component/dist/js/demo.js"));

        }
    }
}