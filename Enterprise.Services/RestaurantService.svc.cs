using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Enterprise.Logic.Entities;
using Enterprise.Logic.Exceptions;
using StructureMap;

namespace Enterprise.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly Logic.Services.IRestaurantService _restaurantService;
        private readonly Logic.Services.IMenuService _menuService;

        public RestaurantService()
        {
            _restaurantService = ObjectFactory.GetInstance<Logic.Services.IRestaurantService>();
            _menuService = ObjectFactory.GetInstance<Logic.Services.IMenuService>();
        }

        public Logic.Entities.Restaurant GetRestaurant(int id)
        {
            try
            {
                return _restaurantService.GetRestaurant(id);
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

        public IList<Logic.Entities.Restaurant> GetRestaurants()
        {
            try
            {
                return _restaurantService.GetRestaurants();
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

        public Restaurant AddRestaurant(Logic.Entities.Restaurant restaurant)
        {
            try
            {
                return _restaurantService.AddRestaurant(restaurant);
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

        public bool UpdateRestaurant(Restaurant restaurant)
        {
            try
            {
                return _restaurantService.UpdateRestaurant(restaurant);
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

        public bool DeleteRestaurant(int id)
        {
            try
            {
                var menus = _menuService.GetMenusByRestaurant(id);

                foreach(var menu in menus)
                {
                    //delete menuItem
                    var menuItems = _menuService.GetMenuItemByMenu(menu.Id);
                    foreach(var menuItem in menuItems)
                    {
                        _menuService.DeleteMenuItem(menuItem.Id);
                    }
                    //delete menu
                    _menuService.DeleteMenu(menu.Id);
                }
                //delete restaurant
                return _restaurantService.DeleteRestaurant(id);
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

        public RestaurantCategory GetRestaurantCategory(int id)
        {
            try
            {
                return _restaurantService.GetRestaurantCategory(id);
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

        public IList<RestaurantCategory> GetRestaurantCategories()
        {
            try
            {
                return _restaurantService.GetRestaurantCategories();
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

        public bool AddRestaurantCategory(RestaurantCategory restaurantCategory)
        {
            try
            {
                return _restaurantService.AddRestaurantCategory(restaurantCategory);
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

        public bool UpdateRestaurantCategory(RestaurantCategory restaurantCategory)
        {
            try
            {
                return _restaurantService.UpdateRestaurantCategory(restaurantCategory);
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

        public bool DeleteRestaurantCategory(int id)
        {
            try
            {
                return _restaurantService.DeleteRestaurantCategory(id);
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


        public bool IsRestaurantHaveMenu(int restaurantId)
        {
            try
            {
                return _restaurantService.IsRestaurantHaveMenu(restaurantId);
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