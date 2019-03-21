using Enterprise.Logic.Entities;
using Enterprise.Logic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Repository.Repositories
{
    public class RestaurantRepository : Repository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(EnterpriseEntities session)
            :base(session)
        {
        }

        public bool IsRestaurantHaveMenu(int restaurantId)
        {
            return Session.Menus.Any(t => t.RestaurantId == restaurantId);
        }
    }
}
