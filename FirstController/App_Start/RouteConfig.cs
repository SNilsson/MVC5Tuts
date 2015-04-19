using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FirstController
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //product/cpu/11

            routes.MapMvcAttributeRoutes();

           // routes.MapRoute(
           //    name: "Products",
           //    url: "products/{products}/{id}",
           //    defaults: new { 
           //        controller = "products", 
           //        action = "Index", 
           //        catagory = UrlParameter.Optional,
           //        id = 0
           //    },
           //    constraasdasdasdasdasdasdasdasdasdints: new {id = @"\d+"}
           //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
