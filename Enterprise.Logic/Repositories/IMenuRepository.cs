using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise.Logic.Entities;

namespace Enterprise.Logic.Repositories
{
    public interface IMenuRepository: IRepository<Menu>
    {
        IList<Menu> GetMenuByRestaurant(int restaurantId);

        bool HaveMenuItem(int menuId);
    }
}
