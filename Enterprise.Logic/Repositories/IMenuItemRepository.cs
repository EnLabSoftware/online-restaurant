using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise.Logic.Entities;

namespace Enterprise.Logic.Repositories
{
    public interface IMenuItemRepository: IRepository<MenuItem>
    {
        IList<MenuItem> GetByMenu(int menuId);

        IList<MenuItem> GetByRestaurant(int restaurantId, int menuId, int page);

        int GetByRestaurantTotalCount(int restaurantId, int menuId, int page);

        IList<MenuItem> GetMenuItemsByPage(int page);

        int GetTotalCount();

        IList<MenuItem> GetBestSeller();

        IList<MenuItem> GetRelatedMenuItem(int menuItemId);

        IList<MenuItemModel> GetMenuItemModels();

        IList<MenuItemModel> GetMenuItemModels(int menuId);
    }
}
