using Enterprise.Logic.Entities;
using Enterprise.Logic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Repository.Repositories
{
    public class RestaurantCategoryRepository : Repository<RestaurantCategory>, IRestaurantCategoryRepository
    {
        public RestaurantCategoryRepository(EnterpriseEntities session)
            :base(session)
        {
        }
    }
}
