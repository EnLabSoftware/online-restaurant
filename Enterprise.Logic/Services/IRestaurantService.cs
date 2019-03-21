using System.Collections.Generic;
using Enterprise.Logic.Entities;

namespace Enterprise.Logic.Services
{
    public interface IRestaurantService
    {
        /// <summary>
        /// Gets the restaurant.
        /// </summary>
        /// <param name="id">The restaurant identifier.</param>
        /// <returns></returns>
        Restaurant GetRestaurant(int id);

        /// <summary>
        /// Gets the restaurants.
        /// </summary>
        /// <returns></returns>
        IList<Restaurant> GetRestaurants();

        /// <summary>
        /// Adds the restaurant.
        /// </summary>
        /// <param name="restaurant">The restaurant.</param>
        /// <returns></returns>
        Restaurant AddRestaurant(Restaurant restaurant);

        /// <summary>
        /// Updates the restaurant.
        /// </summary>
        /// <param name="restaurant">The restaurant.</param>
        /// <returns></returns>
        bool UpdateRestaurant(Restaurant restaurant);

        /// <summary>
        /// Deletes the restaurant.
        /// </summary>
        /// <param name="id">The restaurant identifier.</param>
        /// <returns></returns>
        bool DeleteRestaurant(int id);

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

        bool IsRestaurantHaveMenu(int restaurantId);
    }
}