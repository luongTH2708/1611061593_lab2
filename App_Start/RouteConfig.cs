using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _1611061593_lab2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "list categories",
                url: "list-categories",
                defaults: new { controller = "Categories", action = "Index"}
            );
            routes.MapRoute(
                name: "list news",
                url: "list-news",
                defaults: new { controller = "News", action = "Index"}
            );
            routes.MapRoute(
                name: "category details get by id",
                url: "category-details-{id}",
                defaults: new { controller = "Categories", action = "Details", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "News details",
                url: "news-details-{id}",
                defaults: new { controller = "News", action = "Details", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "Home", action = "Index"}
            );
        }
    }
}
