using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Enterprise.Logic.Entities;
using System.ServiceModel.Web;

namespace Enterprise.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRestaurantService" 
    // in both code and config file together.
    [ServiceContract]
    public interface IRestaurantService
    {
        [OperationContract]
        [WebGet(UriTemplate = "getrestaurant/?id={id}",ResponseFormat= WebMessageFormat.Json)]
        Restaurant GetRestaurant(int id);

        [OperationContract]
        [WebGet(UriTemplate = "getrestaurants", ResponseFormat = WebMessageFormat.Json)]
        IList<Restaurant> GetRestaurants();
        
        [OperationContract]
        Restaurant AddRestaurant(Restaurant restaurant);

        [OperationContract]
        bool UpdateRestaurant(Restaurant restaurant);

        [OperationContract]
        [WebGet(UriTemplate = "deleterestaurant/?id={id}")]
        bool DeleteRestaurant(int id);

        [OperationContract]
        [WebGet(UriTemplate = "getrestaurantcategory/?id={id}")]
        RestaurantCategory GetRestaurantCategory(int id);

        [OperationContract]
        IList<RestaurantCategory> GetRestaurantCategories();

        [OperationContract]
        bool AddRestaurantCategory(RestaurantCategory restaurantCategory);

        [OperationContract]
        bool UpdateRestaurantCategory(RestaurantCategory restaurantCategory);

        [OperationContract]
        [WebGet(UriTemplate = "deleterestaurantcategory/?id={id}")]
        bool DeleteRestaurantCategory(int id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "IsRestaurantHaveMenu/?restaurantId={restaurantId}")]
        bool IsRestaurantHaveMenu(int restaurantId);
    }
}
