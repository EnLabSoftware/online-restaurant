using Enterprise.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Logic.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMenuService
    {
        #region Menu
        /// <summary>
        /// Gets the menu.
        /// </summary>
        /// <param name="id">The menu identifier.</param>
        /// <returns></returns>
        Menu GetMenu(int id);

        /// <summary>
        /// Gets the complete menu.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Menu GetCompleteMenu(int id);

        /// <summary>
        /// Gets the menus.
        /// </summary>
        /// <returns></returns>
        IList<Menu> GetMenus();

        IList<MenuItem> GetMenuItemsByPage(int page);

        int GetTotalMenuItemCount();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="restaurantID">The restaurantID identifier.</param>
        /// <returns></returns>
        IList<Menu> GetMenusByRestaurant(int restaurantID);

        IList<MenuItem> GetMenuItemByMenu(int menuID);

        IList<MenuItem> GetMenuItemByRestaurant(int restaurantID,int menuId, int page);
        int GetByRestaurantTotalCount(int restaurantID, int menuId, int page);

        IList<MenuItem> GetBestSeller();

        /// <summary>
        /// Adds the menu.
        /// </summary>
        /// <param name="menu">The menu.</param>
        /// <returns></returns>
        Menu AddMenu(Menu menu);

        /// <summary>
        /// Updates the menu.
        /// </summary>
        /// <param name="menu">The menu.</param>
        /// <returns></returns>
        bool UpdateMenu(Menu menu);

        /// <summary>
        /// Deletes the menu.
        /// </summary>
        /// <param name="menuID">The menu identifier.</param>
        /// <returns></returns>
        bool DeleteMenu(int id);


        /// <summary>
        /// Adds the menu item.
        /// </summary>
        /// <param name="menuItem">The menu item.</param>
        /// <returns></returns>
        MenuItem AddMenuItem(MenuItem menuItem);

        /// <summary>
        /// Updates the menu item.
        /// </summary>
        /// <param name="menuItem">The menu item.</param>
        /// <returns></returns>
        MenuItem UpdateMenuItem(MenuItem menuItem);

        /// <summary>
        /// Deletes the menu item.
        /// </summary>
        /// <param name="id">The menu item identifier.</param>
        /// <returns></returns>
        bool DeleteMenuItem(int id);

        #endregion

        #region Restaurant

        /// <summary>
        /// Gets the restaurant category.
        /// </summary>
        /// <param name="restaurantCategoryID">The restaurant category identifier.</param>
        /// <returns></returns>
        RestaurantCategory GetRestaurantCategory(int id);

        /// <summary>
        /// Gets the restaurant categories.
        /// </summary>
        /// <returns></returns>
        IList<RestaurantCategory> GetRestaurantCategories();

        /// <summary>
        /// Adds the restaurant category.
        /// </summary>
        /// <param name="restaurantCategory">The restaurant category.</param>
        /// <returns></returns>
        bool AddRestaurantCategory(RestaurantCategory restaurantCategory);

        /// <summary>
        /// Updates the restaurant category.
        /// </summary>
        /// <param name="restaurantCategory">The restaurant category.</param>
        /// <returns></returns>
        bool UpdateRestaurantCategory(RestaurantCategory restaurantCategory);

        /// <summary>
        /// Deletes the restaurant category.
        /// </summary>
        /// <param name="id">The restaurant category identifier.</param>
        /// <returns></returns>
        bool DeleteRestaurantCategory(int id);
        #endregion

        #region MenuItem
        MenuItem GetMenuItem(int menuItemId);
        IList<MenuItem> GetRelatedMenuItem(int menuItemId);

        IList<MenuItem> GetMenuItems();


        IList<MenuItemModel> GetMenuItemsModels();

        bool HaveMenuItem(int menuId);

       
        #endregion

        IList<MenuItemModel> GetMenuItemModelByMenu(int menuId);
    }
}
