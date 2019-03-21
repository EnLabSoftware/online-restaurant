using Enterprise.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Logic.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICartService
    {
        bool RemoveFromCart(string cartId, int menuItemId);

        bool AddToCart(string cartId, int menuItemId, int count, bool isGridUpdate);

        IList<Cart> GetCart(string cartId);

        bool EmptyCart(string cartId);


        decimal GetTotal(string cartId);

        void MigrateCart(string cartId, string userID);

        bool Checkout(Order order);

        List<OrderModel> GetListOrderModel();

        List<OrderDetailModel> GetListOrderDetail(int orderId);

        OrderDetail UpdateOrderDetailQuantity(int orderDetailsId, int quantity);

        IList<OrderStatus> GetOrderStatuses();
        IList<Order> GetOrders();

        Order UpdateOrder(Order order);
        bool DeleteOrder(int orderId);

        bool DeleteOrderDetails(int orderDetailsId);
        Order RefreshOrderTotal(int orderId);

        Order GetOrder(int orderId);
    }
}
