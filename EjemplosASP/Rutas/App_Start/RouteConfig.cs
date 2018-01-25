using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Rutas
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //IMPORTANTE: Las rutas se leen de arriba a abajo, si se encuentra la ruta que 
            //aplica, no se ejecutan las demas

            //creo mi ruta personalizada
            routes.MapRoute(
                name: "MiRuta",
                url: "contactame",
                defaults: new { controller = "Home", action = "Contact" }
            );

            //creo mi ruta personalizada
            routes.MapRoute(
                name: "MiRuta2",
                url: "contactame/guapa",
                defaults: new { controller = "Home", action = "About" }
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            
        }
    }
}
