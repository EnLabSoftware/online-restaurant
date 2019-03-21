using Enterprise.Logic.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Enterprise.Logic.Utility;
using Enterprise.WebUI.ViewModels;
namespace Enterprise.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? page)
        {
            if (!page.HasValue)
            {
                page = 1;
            }
            var homePage = new HomePageViewModel();
            var listMenuItem = JsonUltility<List<MenuItem>>.GetJsonResult(string.Format(ServiceUrl.MenuAPI.GetMenuItemsByPage, page));
            var totalCount = JsonUltility<int>.GetJsonResult(string.Format(ServiceUrl.MenuAPI.GetTotalMenuItemCount));

            homePage.ListMenuItems = listMenuItem;
            homePage.TotalPage = (int)Math.Ceiling((double)totalCount / Constants.PageNumber);
            homePage.CurrentPage = page.Value;
            return View(homePage);
        }

        public ActionResult MenuItemDetail(string menuItemName, int menuItemId)
        {
            var menuItem = JsonUltility<MenuItem>.GetJsonResult(string.Format(ServiceUrl.MenuAPI.GetMenuItem, menuItemId));
            var listMenuItem = JsonUltility<List<MenuItem>>.GetJsonResult(string.Format(ServiceUrl.MenuAPI.GetRelatedMenuItem, menuItemId));
            var viewModel = new MenuItemDetailViewModel() { MenuItem = menuItem, RelatedMenuItems = listMenuItem };
            return View(viewModel);
        }

        public ActionResult RestaurantDetails(string restaurantName, int id, string menuType, int? menuId, int? page)
        {
            var viewModel = new RestaurantDetailsViewModel();
            var currentRestaurant = JsonUltility<Restaurant>.GetJsonResult(string.Format(ServiceUrl.RestaurantAPI.GetRestaurant, id.ToString()));
            var listMenu = JsonUltility<List<Menu>>.GetJsonResult(string.Format(ServiceUrl.MenuAPI.GetMenusByRestaurant, id.ToString()));

            //first page case
            if (!page.HasValue)
            {
                page = 1;
            }
            //select all case
            if (!menuId.HasValue || menuId <= 0)
            {
                menuId = -1;
            }

            var listMenuItem = JsonUltility<List<MenuItem>>.GetJsonResult(string.Format(ServiceUrl.MenuAPI.GetMenuItemByRestaurant, id, menuId.Value, page.Value));
            var totalCount = JsonUltility<int>.GetJsonResult(string.Format(ServiceUrl.MenuAPI.GetByRestaurantTotalCount, id, menuId.Value, page.Value));

            viewModel.Restaurant = currentRestaurant;
            viewModel.ListMenu = listMenu;
            viewModel.ListMenuItems = listMenuItem;
            viewModel.TotalPage = (int)Math.Ceiling((double)totalCount / Constants.PageNumber);
            viewModel.CurrentPage = page.Value;
            return View(viewModel);
        }
        [ChildActionOnly]
        public ActionResult GetListRestaurant()
        {
            var listProduct = JsonUltility<List<Restaurant>>.GetJsonResult(ServiceUrl.RestaurantAPI.GetRestaurants);
            return PartialView(listProduct);
        }

        [ChildActionOnly]
        public ActionResult GetBestSeller()
        {
            var listBestSeller = JsonUltility<List<MenuItem>>.GetJsonResult(ServiceUrl.MenuAPI.GetBestSeller);
            return PartialView("_GetBestSeller", listBestSeller);
        }
    }
}