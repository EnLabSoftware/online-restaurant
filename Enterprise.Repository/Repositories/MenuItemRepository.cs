using Enterprise.Logic.Entities;
using Enterprise.Logic.Repositories;
using Enterprise.Logic.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Repository.Repositories
{
    public class MenuItemRepository : Repository<MenuItem>, IMenuItemRepository
    {
        public MenuItemRepository(EnterpriseEntities session)
            : base(session)
        {
        }

        public IList<MenuItem> GetByMenu(int menuId)
        {
            return Session.MenuItems.Where(t => t.MenuId == menuId).ToList();
        }

        public IList<MenuItem> GetByRestaurant(int restaurantId, int menuId, int page)
        {
            IList<int> listMenuID = Session.Menus.Where(t => t.RestaurantId == restaurantId).Select(t => t.Id).ToList();
            var skipPage = (page - 1) * Constants.PageNumber;
            //in case menuId
            if (menuId != -1)
            {
                //check if a restaurant has this menu
                if (listMenuID.Contains(menuId))
                {

                    return Session.MenuItems.Where(t => t.MenuId == menuId).OrderByDescending(t => t.Id).Skip(skipPage).Take(Constants.PageNumber).ToList(); ;
                }
            }

            return Session.MenuItems.Where(t => listMenuID.Contains(t.MenuId.Value)).OrderByDescending(t => t.Id).Skip(skipPage).Take(Constants.PageNumber).ToList(); ;
        }

        public int GetByRestaurantTotalCount(int restaurantId, int menuId, int page)
        {
            IList<int> listMenuID = Session.Menus.Where(t => t.RestaurantId == restaurantId).Select(t => t.Id).ToList();
            var skipPage = (page - 1) * Constants.PageNumber;
            //in case menuId
            if (menuId != -1)
            {
                //check if a restaurant has this menu
                if (listMenuID.Contains(menuId))
                {

                    return Session.MenuItems.Where(t => t.MenuId == menuId).Count();
                }
            }

            return Session.MenuItems.Where(t => listMenuID.Contains(t.MenuId.Value)).Count();
        }

        public IList<MenuItem> GetMenuItemsByPage(int page)
        {
            var skipPage = (page - 1) * Constants.PageNumber;
            return Session.MenuItems.OrderByDescending(t => t.Id).Skip(skipPage).Take(Constants.PageNumber).ToList();
        }

        public int GetTotalCount()
        {
            return Session.MenuItems.Count();
        }

        public IList<MenuItem> GetBestSeller()
        {
            var listmenuID = Session.OrderDetails.GroupBy(p => p.MenuItemId).OrderByDescending(pi => pi.Sum(pii => pii.Quantity)).Select(p => p.Key).Take(2);
            return Session.MenuItems.Where(t => listmenuID.Contains(t.Id)).Take(2).ToList();
        }


        public IList<MenuItem> GetRelatedMenuItem(int menuItemId)
        {
            return Session.MenuItems.Where(t => t.Id != menuItemId).OrderBy(t => t.Id).Take(3).ToList();
        }

        public IList<MenuItemModel> GetMenuItemModels()
        {
            var results = (from menuItem in Session.MenuItems
                       join menu in Session.Menus on menuItem.MenuId equals menu.Id
                       join restaurant in Session.Restaurants on menu.RestaurantId equals restaurant.Id
                       select new MenuItemModel
                       {
                           Id = menuItem.Id,
                           Description = menuItem.Description,
                           ImageLocation = menuItem.ImageLocation,
                           MenuId = menuItem.MenuId.HasValue? menuItem.MenuId.Value : 0,
                           Name = menuItem.Name,
                           PreparationTime = menuItem.PreparationTime.HasValue ? menuItem.PreparationTime.Value : 0,
                           Price = menuItem.Price.HasValue ? menuItem.Price.Value : 0,
                           RestaurantId = restaurant.Id,
                           Menu = menu.MenuType,
                       }).ToList();
            return results;
        }

        public IList<MenuItemModel> GetMenuItemModels(int menuId)
        {
            var results = (from menuItem in Session.MenuItems
                           join menu in Session.Menus.Where(t=>t.Id == menuId) on menuItem.MenuId equals menu.Id
                           join restaurant in Session.Restaurants on menu.RestaurantId equals restaurant.Id
                           select new MenuItemModel
                           {
                               Id = menuItem.Id,
                               Description = menuItem.Description,
                               ImageLocation = menuItem.ImageLocation,
                               MenuId = menuItem.MenuId.HasValue ? menuItem.MenuId.Value : 0,
                               Name = menuItem.Name,
                               PreparationTime = menuItem.PreparationTime.HasValue ? menuItem.PreparationTime.Value : 0,
                               Price = menuItem.Price.HasValue ? menuItem.Price.Value : 0,
                               RestaurantId = restaurant.Id,
                               Menu = menu.MenuType,
                           }).ToList();
            return results;
        }

    }
}
