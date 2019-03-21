using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CuttingEdge.Conditions;
using Enterprise.Logic.Entities;
using Enterprise.Logic.Repositories;
using Enterprise.Logic.Exceptions;
using Enterprise.Logic.Services;

namespace Enterprise.Application.Services
{
    public class MenuService : BaseService<Menu>, IMenuService
    {

        private readonly IMenuRepository _menuRepository;
        private readonly IMenuItemRepository _menuItemRepository;
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IRestaurantCategoryRepository _restaurantCategoryRepository;

        public MenuService(IMenuRepository menuRepository,
            IMenuItemRepository menuItemRepository,
            IRestaurantRepository restaurantRepository,
            IRestaurantCategoryRepository restaurantCategoryRepository)
            : base(menuRepository)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(menuRepository, "menuRepository")
                .IsNotNull();
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(menuItemRepository, "menuItemRepository")
                .IsNotNull();
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(restaurantRepository, "restaurantRepository")
                .IsNotNull();
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(restaurantCategoryRepository, "restaurantCategoryRepository")
                .IsNotNull();

            _menuRepository = menuRepository;
            _menuItemRepository = menuItemRepository;
            _restaurantRepository = restaurantRepository;
            _restaurantCategoryRepository = restaurantCategoryRepository;
        }

        public Menu GetMenu(int id)
        {
            //Condition.WithExceptionOnFailure<InvalidParameterException>()
            //    .Requires(id, "menuID")
            //    .IsNotNullOrEmpty();

            return GetEntity(id);
        }

        public Menu GetCompleteMenu(int id)
        {
            //Condition.WithExceptionOnFailure<InvalidParameterException>()
            //    .Requires(id, "menuId")
            //    .IsNotNullOrEmpty();
            return null;
            //return GetEntity(id, _=>_.MenuItems, _=>_.Restaurant);
        }


        public IList<Menu> GetMenus()
        {
            return _menuRepository.GetAll();
        }

        public Menu AddMenu(Menu menu)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(menu, "menu")
                .IsNotNull();

            var resultAdd = _menuRepository.Add(menu);
            _menuRepository.Save();
            return menu;

            // return _menuRepository.Add(menu);
        }

        public bool UpdateMenu(Menu menu)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(menu, "menu")
                .IsNotNull();

            _menuRepository.Update(menu);
            return _menuRepository.Save();
        }

        public bool DeleteMenu(int id)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(_menuRepository, "_menuRepository")
                .IsNotNull();

            _menuRepository.Delete(_menuRepository.Get(id));
            return _menuItemRepository.Save();
        }

        public MenuItem GetMenuItem(int id)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(_menuItemRepository, "_menuItemRepository")
                .IsNotNull();

            return _menuItemRepository.Get(id);
        }

        public MenuItem AddMenuItem(MenuItem menuItem)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(menuItem, "menuItem")
                .IsNotNull();

            _menuItemRepository.Add(menuItem);
            _menuItemRepository.Save();
            return menuItem;
        }

        public MenuItem UpdateMenuItem(MenuItem menuItem)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(menuItem, "menuItem")
                .IsNotNull();

            _menuItemRepository.Update(menuItem);
            _menuItemRepository.Save();
            return menuItem;
        }

        public bool DeleteMenuItem(int id)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(_menuRepository, "menuItemId")
                .IsNotNull();

            _menuItemRepository.Delete(_menuItemRepository.Get(id));

            return _menuRepository.Save();
        }

        public RestaurantCategory GetRestaurantCategory(int id)
        {
            //Condition.WithExceptionOnFailure<InvalidParameterException>()
            //    .Requires(id, "restaurantCategoryID")
            //    .IsNotNullOrEmpty();

            return _restaurantCategoryRepository.Get(id);
        }

        public IList<RestaurantCategory> GetRestaurantCategories()
        {
            return _restaurantCategoryRepository.GetAll();
        }

        public bool AddRestaurantCategory(RestaurantCategory restaurantCategory)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(restaurantCategory, "restaurantCategory")
                .IsNotNull();

            return _restaurantCategoryRepository.Add(restaurantCategory);
        }

        public bool UpdateRestaurantCategory(RestaurantCategory restaurantCategory)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(restaurantCategory, "restaurantCategory")
                .IsNotNull();

            return _restaurantCategoryRepository.Update(restaurantCategory);
        }

        public bool DeleteRestaurantCategory(int id)
        {
            //Condition.WithExceptionOnFailure<InvalidParameterException>()
            //    .Requires(id, "restaurantCategoryId")
            //    .IsNotNullOrEmpty();

            return _restaurantCategoryRepository.Delete(_restaurantCategoryRepository.Get(id));
        }

        public IList<MenuItem> GetMenuItemByMenu(int menuID)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(_menuItemRepository, "_menuItemRepository")
                .IsNotNull();
            return _menuItemRepository.GetByMenu(menuID);
        }

        public IList<MenuItem> GetMenuItemByRestaurant(int restaurantID, int menuId, int page)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(_menuItemRepository, "_menuItemRepository")
                .IsNotNull();
            return _menuItemRepository.GetByRestaurant(restaurantID, menuId, page);
        }

        public IList<Menu> GetMenusByRestaurant(int restaurantID)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(_menuRepository, "_menuRepository")
                .IsNotNull();

            return _menuRepository.GetMenuByRestaurant(restaurantID);
        }


        public IList<MenuItem> GetMenuItemsByPage(int page)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(_menuItemRepository, "_menuItemRepository")
                .IsNotNull();
            return _menuItemRepository.GetMenuItemsByPage(page);
        }

        public int GetTotalMenuItemCount()
        {
            return _menuItemRepository.GetTotalCount();
        }


        public IList<MenuItem> GetBestSeller()
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(_menuItemRepository, "_menuItemRepository")
                .IsNotNull();
            return _menuItemRepository.GetBestSeller();
        }


        public IList<MenuItem> GetRelatedMenuItem(int menuItemId)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                 .Requires(_menuItemRepository, "_menuItemRepository")
                 .IsNotNull();
            return _menuItemRepository.GetRelatedMenuItem(menuItemId);
        }


        public int GetByRestaurantTotalCount(int restaurantID, int menuId, int page)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                  .Requires(_menuItemRepository, "_menuItemRepository")
                  .IsNotNull();
            return _menuItemRepository.GetByRestaurantTotalCount(restaurantID, menuId, page);
        }


        public IList<MenuItem> GetMenuItems()
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                  .Requires(_menuItemRepository, "_menuItemRepository")
                  .IsNotNull();
            return _menuItemRepository.GetAll();
        }

        public IList<MenuItemModel> GetMenuItemsModels()
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                  .Requires(_menuItemRepository, "_menuItemRepository")
                  .IsNotNull();
            return _menuItemRepository.GetMenuItemModels();
        }

        public bool HaveMenuItem(int menuId)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                   .Requires(_menuRepository, "_menuItemRepository")
                   .IsNotNull();
            return _menuRepository.HaveMenuItem(menuId);
        }


        public IList<MenuItemModel> GetMenuItemModelByMenu(int menuId)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                 .Requires(_menuItemRepository, "_menuItemRepository")
                 .IsNotNull();
            return _menuItemRepository.GetMenuItemModels(menuId);
        }
    }
}
