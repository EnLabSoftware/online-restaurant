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
    public class RestaurantService : BaseService<Restaurant>, IRestaurantService
    {

        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IRestaurantCategoryRepository _restaurantCategoryRepository;

        public RestaurantService(IRestaurantRepository restaurantRepository,
            IRestaurantCategoryRepository restaurantCategoryRepository)
            : base(restaurantRepository)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(restaurantRepository, "restaurantRepository").IsNotNull();

            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(restaurantCategoryRepository, "restaurantCategoryRepository").IsNotNull();

            _restaurantRepository = restaurantRepository;
            _restaurantCategoryRepository = restaurantCategoryRepository;
        }

        public Restaurant GetRestaurant(int id)
        {
            //Condition.WithExceptionOnFailure<InvalidParameterException>()
            //    .Requires(id, "restaurantID")
            //    .IsNotNullOrEmpty();

            return GetEntity(id);
        }

        public IList<Restaurant> GetRestaurants()
        {
            return _restaurantRepository.GetAll();
        }

        public Restaurant AddRestaurant(Restaurant restaurant)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(restaurant, "restaurant")
                .IsNotNull();

            var resultAdd = _restaurantRepository.Add(restaurant);
            _restaurantRepository.Save();

            return restaurant;
        }

        public bool UpdateRestaurant(Restaurant restaurant)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(restaurant, "restaurant")
                .IsNotNull();

            _restaurantRepository.Update(restaurant);
            return _restaurantRepository.Save();
        }

        public bool DeleteRestaurant(int id)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(_restaurantRepository, "_restaurantRepository")
                .IsNotNull();

            _restaurantRepository.Delete(_restaurantRepository.Get(id));
            return _restaurantRepository.Save();
        }

        public RestaurantCategory GetRestaurantCategory(int id)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(_restaurantCategoryRepository, "_restaurantCategoryRepository")
                .IsNotNull();

            return _restaurantCategoryRepository.Get(id);
        }

        public IList<RestaurantCategory> GetRestaurantCategories()
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(_restaurantCategoryRepository, "_restaurantCategoryRepository")
                .IsNotNull();
            return _restaurantCategoryRepository.GetAll();
        }

        public bool AddRestaurantCategory(RestaurantCategory restaurantCategory)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(restaurantCategory, "restaurantCategory")
                .IsNotNull();

            var resultAdd = _restaurantCategoryRepository.Add(restaurantCategory);
            _restaurantCategoryRepository.Save();

            return resultAdd;
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

        public bool IsRestaurantHaveMenu(int restaurantId)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(_restaurantRepository, "_restaurantRepository")
                .IsNotNull();

            return _restaurantRepository.IsRestaurantHaveMenu(restaurantId);
        }
    }
}
