using Enterprise.Logic.Entities;
using Enterprise.Logic.Exceptions;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Services
{
    public class MenuService : IMenuService
    {
        private readonly Logic.Services.IMenuService _menuService;

        public MenuService()
        {
            _menuService = ObjectFactory.GetInstance<Logic.Services.IMenuService>();
        }

        public IList<Menu> GetMenus()
        {
            try
            {
                return _menuService.GetMenus();
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }

        public Logic.Entities.Menu GetMenu(int id)
        {
            //int _id = Int32.Parse(id);
            try
            {
                return _menuService.GetMenu(id);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }

        public Logic.Entities.Menu GetCompleteMenu(int id)
        {
            try
            {
                return _menuService.GetCompleteMenu(id);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }

        public Menu AddMenu(Logic.Entities.Menu menu)
        {
            try
            {
                return _menuService.AddMenu(menu);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }

        public bool UpdateMenu(Logic.Entities.Menu menu)
        {
            try
            {
                return _menuService.UpdateMenu(menu);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }

        public bool DeleteMenu(int id)
        {
            try
            {
                //delete all menu item first
                var menuItems = _menuService.GetMenuItemByMenu(id);
                foreach (var menuItem in menuItems)
                {
                    _menuService.DeleteMenuItem(menuItem.Id);
                }

                //delete menu
                return _menuService.DeleteMenu(id);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }


        public IList<Menu> GetMenusByRestaurant(int restaurantId)
        {
            try
            {
                return _menuService.GetMenusByRestaurant(restaurantId);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }

        public IList<MenuItem> GetMenuItemByMenu(int menuID)
        {
            try
            {
                return _menuService.GetMenuItemByMenu(menuID);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }


        public IList<MenuItem> GetMenuItemByRestaurant(int restaurantId,int menuId, int page)
        {
            try
            {
                return _menuService.GetMenuItemByRestaurant(restaurantId, menuId , page);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }


        public IList<MenuItem> GetMenuItemsByPage(int page)
        {
            try
            {
                return _menuService.GetMenuItemsByPage(page);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }

        public int GetTotalMenuItemCount()
        {
            try
            {
                return _menuService.GetTotalMenuItemCount();
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }


        public IList<MenuItem> GetBestSeller()
        {
            try
            {
                return _menuService.GetBestSeller();
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }


        public MenuItem GetMenuItem(int menuItemId)
        {
            try
            {
                return _menuService.GetMenuItem(menuItemId);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }

        public IList<MenuItem> GetRelatedMenuItem(int menuItemId)
        {
            try
            {
                return _menuService.GetRelatedMenuItem(menuItemId);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }


        public int GetByRestaurantTotalCount(int restaurantId, int menuId, int page)
        {
            try
            {
                return _menuService.GetByRestaurantTotalCount(restaurantId,menuId,page);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }


        public IList<MenuItem> GetMenuItems()
        {
            try
            {
                return _menuService.GetMenuItems();
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }


        public IList<MenuItemModel> GetMenuItemModels()
        {
            try
            {
                return _menuService.GetMenuItemsModels();
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }


        public MenuItem AddMenuItem(MenuItem menu)
        {
            try
            {
                return _menuService.AddMenuItem(menu);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }

        public MenuItem UpdateMenuItem(MenuItem menu)
        {
            try
            {
                return _menuService.UpdateMenuItem(menu);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }

        public bool DeleteMenuItem(int menuItemId)
        {
            try
            {
                return _menuService.DeleteMenuItem(menuItemId);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }

        public bool IsMenuHaveMenuItem(int menuId)
        {
            try
            {
                return _menuService.HaveMenuItem(menuId);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }


        public IList<MenuItemModel> GetMenuItemModelByMenu(int menuId)
        {
            try
            {
                return _menuService.GetMenuItemModelByMenu(menuId);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }
    }
}
