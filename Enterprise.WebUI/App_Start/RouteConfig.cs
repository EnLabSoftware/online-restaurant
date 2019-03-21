using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Enterprise.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            #region Restaurant Config
            
            routes.MapRoute(
                name: "RestaurantDetails",
                url: "restaurant-{restaurantName}-{id}",
                defaults: new { controller = "Home", action = "RestaurantDetails", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "RestaurantDetailsWithPage",
                url: "restaurant-{restaurantName}-{id}/page-{page}",
                defaults: new { controller = "Home", action = "RestaurantDetails", id = UrlParameter.Optional }
            );
          
            routes.MapRoute(
                name: "RestaurantDetailsWithMenu",
                url: "restaurant-{restaurantName}-{id}/{menuType}-{menuId}",
                defaults: new { controller = "Home", action = "RestaurantDetails", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "RestaurantDetailsWithMenuWithPage",
                url: "restaurant-{restaurantName}-{id}/{menuType}-{menuId}/page-{page}",
                defaults: new { controller = "Home", action = "RestaurantDetails", id = UrlParameter.Optional }
            );

            #endregion

            routes.MapRoute(
                name: "HomePage",
                url: "page-{page}",
                defaults: new { controller = "Home", action = "Index", page = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ViewCart",
                url: "ViewCart",
                defaults: new { controller = "Cart", action = "ViewCart", page = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "MenuItem",
            url: "MenuItem-{menuItemName}-{menuItemId}",
            defaults: new { controller = "Home", action = "MenuItemDetail", page = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
