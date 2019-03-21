using Enterprise.Logic.Entities;
using Enterprise.Logic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Repository.Repositories
{
    public class MenuRepository: Repository<Menu>, IMenuRepository
    {
        public MenuRepository(EnterpriseEntities session)
            :base(session)
        {
        }


        public IList<Menu> GetMenuByRestaurant(int restaurantId)
        {
            return Session.Menus.Where(t => t.RestaurantId == restaurantId).ToList();
        }

        public bool HaveMenuItem(int menuId)
        {
            return Session.MenuItems.Any(t => t.MenuId == menuId);
        }
    }
}
