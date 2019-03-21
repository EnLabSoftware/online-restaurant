using Enterprise.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Enterprise.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICartService" in both code and config file together.
    [ServiceContract]
    public interface ICartService
    {


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "RemoveFromCart/?cartId={cartId}&menuItemId={menuItemId}", ResponseFormat = WebMessageFormat.Json)]
        bool RemoveFromCart(string cartId, int menuItemId);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "AddToCart/?cartId={cartId}&menuItemId={menuItemId}&count={count}&isGridUpdate={isGridUpdate}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool AddToCart(string cartId, int menuItemId, int count, bool isGridUpdate);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "CheckOut", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool CheckOut(Order order);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetCart/{cartId}", ResponseFormat = WebMessageFormat.Json)]
        IList<Cart> GetCart(string cartId);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "EmptyCart/{cartId}", ResponseFormat = WebMessageFormat.Json)]
        void EmptyCart(string cartId);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetTotal/{cartId}", ResponseFormat = WebMessageFormat.Json)]
        decimal GetTotal(string cartId);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "MigrateCart/{cartId}/{userId}", ResponseFormat = WebMessageFormat.Json)]
        void MigrateCart(string cartId, string userId);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetOrderModel", ResponseFormat = WebMessageFormat.Json)]
        List<OrderModel> GetOrderModel();


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetListOrderDetail/?orderId={orderId}", ResponseFormat = WebMessageFormat.Json)]
        List<OrderDetailModel> GetListOrderDetail(int orderId);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "UpdateOrderDetailQuantity/?orderDetailsId={orderDetailsId}&quantity={quantity}", ResponseFormat = WebMessageFormat.Json)]
        OrderDetail UpdateOrderDetailQuantity(int orderDetailsId, int quantity);



        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetOrderStatuses", ResponseFormat = WebMessageFormat.Json)]
        IList<OrderStatus> GetOrderStatuses();


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetOrders", ResponseFormat = WebMessageFormat.Json)]
        IList<Order> GetOrders();


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "UpdateOrder", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Order UpdateOrder(Order order);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "DeleteOrder/?orderId={orderId}", ResponseFormat = WebMessageFormat.Json)]
        bool DeleteOrder(int orderId);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "DeleteOrderDetails/?orderDetailsId={orderDetailsId}", ResponseFormat = WebMessageFormat.Json)]
        bool DeleteOrderDetails(int orderDetailsId);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetOrder/?orderId={orderId}", ResponseFormat = WebMessageFormat.Json)]
        Order GetOrder(int orderId);

    }
}
