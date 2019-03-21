using Enterprise.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Services
{
    [ServiceContract]
    public interface IMenuService
    {
        [OperationContract]
        [WebGet(UriTemplate = "getmenus")]
        IList<Menu> GetMenus();

        [OperationContract]
        [WebGet(UriTemplate = "getmenu/?id={id}")]
        Menu GetMenu(int id);

        [OperationContract]
        [WebGet(UriTemplate = "getcompletemenu/?id={id}")]
        Menu GetCompleteMenu(int id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "addmenu")]
        Menu AddMenu(Menu menu);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "updatemenu")]
        bool UpdateMenu(Menu menu);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "deletemenu/?id={id}")]
        bool DeleteMenu(int id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetMenusByRestaurant/?restaurantId={restaurantId}", ResponseFormat = WebMessageFormat.Json)]
        IList<Menu> GetMenusByRestaurant(int restaurantId);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetMenuItemByRestaurant/?restaurantId={restaurantId}&menuId={menuId}&page={page}", ResponseFormat = WebMessageFormat.Json)]
        IList<MenuItem> GetMenuItemByRestaurant(int restaurantId,int menuId, int page);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetByRestaurantTotalCount/?restaurantId={restaurantId}&menuId={menuId}&page={page}", ResponseFormat = WebMessageFormat.Json)]
        int GetByRestaurantTotalCount(int restaurantId, int menuId, int page);
        
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetMenuItemByMenu/?menuID={menuID}", ResponseFormat = WebMessageFormat.Json)]
        IList<MenuItem> GetMenuItemByMenu(int menuID);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetMenuItemsByPage/?page={page}", ResponseFormat = WebMessageFormat.Json)]
        IList<MenuItem> GetMenuItemsByPage(int page);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetTotalMenuItemCount", ResponseFormat = WebMessageFormat.Json)]
        int GetTotalMenuItemCount();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetBestSeller", ResponseFormat = WebMessageFormat.Json)]
        IList<MenuItem> GetBestSeller();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetMenuItem/?menuItemId={menuItemId}", ResponseFormat = WebMessageFormat.Json)]
        MenuItem GetMenuItem(int menuItemId);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetRelatedMenuItem/?menuItemId={menuItemId}", ResponseFormat = WebMessageFormat.Json)]
        IList<MenuItem> GetRelatedMenuItem(int menuItemId);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        IList<MenuItem> GetMenuItems();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        IList<MenuItemModel> GetMenuItemModels();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "addmenuitem")]
        MenuItem AddMenuItem(MenuItem menu);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "updatemenuitem")]
        MenuItem UpdateMenuItem(MenuItem menu);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "DeleteMenuItem/?menuItemId={menuItemId}")]
        bool DeleteMenuItem(int menuItemId);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "HaveMenuItem/?menuId={menuId}")]
        bool IsMenuHaveMenuItem(int menuId);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetMenuItemModelByMenu/?menuId={menuId}")]
        IList<MenuItemModel> GetMenuItemModelByMenu(int menuId);
    }
}
