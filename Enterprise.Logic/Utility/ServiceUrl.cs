using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Enterprise.Logic.Utility
{
    public class Constants
    {
        public const int PageNumber = 9;
    }
    public class ServiceUrl
    {
        public const string SERVICE_URL = "http://localhost:23618/";

        public class MenuAPI
        {
            private static string MenuService = "MenuService.svc/";
            public static string GetMenusByRestaurant { get { return SERVICE_URL + MenuService + "GetMenusByRestaurant/?restaurantId={0}"; } }
            public static string GetMenuItemByRestaurant { get { return SERVICE_URL + MenuService + "GetMenuItemByRestaurant/?restaurantId={0}&menuId={1}&page={2}"; } }

            public static string GetByRestaurantTotalCount { get { return SERVICE_URL + MenuService + "GetByRestaurantTotalCount/?restaurantId={0}&menuId={1}&page={2}"; } }

            public static string GetMenuItemByMenu { get { return SERVICE_URL + MenuService + "GetMenuItemByMenu/?menuID={0}"; } }

            public static string GetMenuItemsByPage { get { return SERVICE_URL + MenuService + "GetMenuItemsByPage/?page={0}"; } }
            public static string GetTotalMenuItemCount { get { return SERVICE_URL + MenuService + "GetTotalMenuItemCount"; } }

            public static string GetBestSeller { get { return SERVICE_URL + MenuService + "GetBestSeller"; } }

            public static string GetMenuItem { get { return SERVICE_URL + MenuService + "GetMenuItem/?menuItemId={0}"; } }
            public static string GetRelatedMenuItem { get { return SERVICE_URL + MenuService + "GetRelatedMenuItem/?menuItemId={0}"; } }

        }

        public class RestaurantAPI
        {
            private static string RestaurantService = "RestaurantService.svc/";
            public static string GetRestaurants { get { return SERVICE_URL + RestaurantService + "GetRestaurants"; } }
            public static string GetRestaurant { get { return SERVICE_URL + RestaurantService + "getrestaurant/?id={0}"; } }
        }

        public class CartAPI
        {
            private static string CartService = "CartService.svc/";

            public static string RemoveFromCart { get { return SERVICE_URL + CartService + "RemoveFromCart/?cartId={0}&menuItemId={1}"; } }

            public static string AddToCart { get { return SERVICE_URL + CartService + "AddToCart/?cartId={0}&menuItemId={1}&count={2}&isGridUpdate={3}"; } }

            public static string CheckOut { get { return SERVICE_URL + CartService + "CheckOut"; } }

            public static string GetCart { get { return SERVICE_URL + CartService + "GetCart/{0}"; } }

            public static string EmptyCart { get { return SERVICE_URL + CartService + "EmptyCart"; } }

            public static string GetTotal { get { return SERVICE_URL + CartService + "GetTotal/{0}"; } }

            public static string MigrateCart { get { return SERVICE_URL + CartService + "RemoveFromCart"; } }
        }
    }
}
