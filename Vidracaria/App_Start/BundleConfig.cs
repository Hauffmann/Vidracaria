using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Vidracaria
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/angular.js",
                        "~/Scripts/angular-route.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                        "~/Scripts/DataTables/jquery.dataTables.min.js",
                        "~/Scripts/DataTables/dataTables.bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/datatables").Include(
                      "~/Content/DataTables/css/dataTables.bootstrap.css"));

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                        "~/Scripts/kendo/2017.1.223/kendo.all.min.js",
                        "~/Scripts/kendo/2017.1.223/kendo.ui.core.min.js",
                        "~/Scripts/kendo/2017.1.223/kendo.angular.min.js"));

            bundles.Add(new StyleBundle("~/Content/kendo").Include(
                      "~/Content/kendo/2017.1.223/kendo.common.min.css",
                      "~/Content/kendo/2017.1.223/kendo.default.min.css",
                      "~/Content/kendo/2017.1.223/kendo.mobile.all.min.css",
                      "~/Content/kendo/2017.1.223/kendo.silver.min.css",
                      "~/Content/kendo/2017.1.223/kendo.silver.mobile.min",
                      "~/Content/kendo/2017.1.223/kendo.dataviz.min.css",
                      "~/Content/kendo/2017.1.223/kendo.dataviz.default.min.css"));



            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/bootstrap-hover-dropdown.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}