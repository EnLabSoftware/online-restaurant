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
    public class CartService : BaseService<Cart>, ICartService
    {
        private readonly ICartRepository _cartRepository;

        private readonly IMenuItemRepository _menuItemRepository;

        private readonly IOrderRepository _orderRepository;

        private readonly IOrderDetailsRepository _orderDetailsRepository;

        private readonly IOrderStatusRepository _orderStatusRepository;
        public CartService(ICartRepository cartRepository, IMenuItemRepository menuItemRepository, IOrderRepository orderRepository, IOrderDetailsRepository orderDetailsRepository, IOrderStatusRepository orderStatusRepository)
            : base(cartRepository)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(cartRepository, "cartRepository")
                .IsNotNull();

            _cartRepository = cartRepository;
            _menuItemRepository = menuItemRepository;
            _orderDetailsRepository = orderDetailsRepository;
            _orderRepository = orderRepository;
            _orderStatusRepository = orderStatusRepository;
        }

        public bool RemoveFromCart(string cartId, int menuItemId)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(_cartRepository, "_iCartRepository")
                .IsNotNull();
            return _cartRepository.RemoveFromCart(cartId, menuItemId);
        }

        public bool AddToCart(string cartId, int menuItemId, int count, bool isGridUpdate)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(_cartRepository, "_cartRepository")
                .IsNotNull();
            Condition.WithExceptionOnFailure<InvalidParameterException>()
               .Requires(_menuItemRepository, "_menuItemRepository")
               .IsNotNull();

            return _cartRepository.AddToCart(cartId, menuItemId, count, isGridUpdate);
        }

        public IList<Cart> GetCart(string cartId)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
               .Requires(_cartRepository, "_iCartRepository")
               .IsNotNull();
            return _cartRepository.GetCart(cartId);
        }

        public bool EmptyCart(string cartId)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
              .Requires(_cartRepository, "_cartRepository")
              .IsNotNull();
            _cartRepository.EmptyCart(cartId);
            return true;
        }

        public decimal GetTotal(string cartId)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
             .Requires(_cartRepository, "_cartRepository")
             .IsNotNull();
            return _cartRepository.GetTotal(cartId);
        }

        public void MigrateCart(string cartId, string userID)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
            .Requires(_cartRepository, "_cartRepository")
            .IsNotNull();
            _cartRepository.MigrateCart(cartId, userID);
        }


        public bool Checkout(Order order)
        {
            var listCart = _cartRepository.GetCart(order.CustomerID);
            order.OrderStatusId = _orderStatusRepository.GetByName("Pending").Id;
            if (listCart.Count == 0)
            {
                return false;
            }

            _orderRepository.Add(order);
            if (!_orderRepository.Save())
            {
                return false;
            }
            decimal totalCost = 0;
            foreach (var cart in listCart)
            {
                var menuItem = _menuItemRepository.Get(cart.MenuItemId.Value);
                var orderDetail = new OrderDetail()
                    {
                        OrderId = order.Id,
                        MenuItemId = menuItem.Id,
                        UnitCost = menuItem.Price.Value,
                        Quantity = cart.Count.Value,
                    };
                totalCost += menuItem.Price.Value * cart.Count.Value;
                _cartRepository.Delete(cart);
                _orderDetailsRepository.Add(orderDetail);
            }
            order.Total = totalCost;

            _cartRepository.Save();
            _orderDetailsRepository.Save();
            order.Total = totalCost;
            return _orderRepository.Update(order);
        }

        public List<OrderModel> GetListOrderModel()
        {
            return _orderRepository.GetListOrderModel();
        }

        public List<OrderDetailModel> GetListOrderDetail(int orderId)
        {
            return _orderRepository.GetListOrderDetail(orderId);
        }

        public OrderDetail UpdateOrderDetailQuantity(int orderDetailsId, int quantity)
        {
            var orderDetail = _orderDetailsRepository.UpdateOrderDetailQuantity(orderDetailsId, quantity);
            RefreshOrderTotal(orderDetail.OrderId);
            return orderDetail;
        }

        public IList<OrderStatus> GetOrderStatuses()
        {
            return _orderStatusRepository.GetAll();
        }

        public IList<Order> GetOrders()
        {
            return _orderRepository.GetAll();
        }

        public Order UpdateOrder(Order order)
        {
            _orderRepository.Update(order);
            _orderRepository.Save();
            return order;
        }

        public bool DeleteOrder(int orderId)
        {
            //delete all order detail first
            var listOrderDetails = _orderDetailsRepository.GetByOrder(orderId);
            foreach (var item in listOrderDetails)
            {
                _orderDetailsRepository.Delete(item);
            }
            _orderDetailsRepository.Save();
            //delete order
            var order = _orderRepository.Get(orderId);
            _orderRepository.Delete(order);
            return _orderRepository.Save();
        }

        public bool DeleteOrderDetails(int orderDetailsId)
        {
            var orderDetail = _orderDetailsRepository.Get(orderDetailsId);
            _orderDetailsRepository.Delete(orderDetail);
            _orderDetailsRepository.Save();
            RefreshOrderTotal(orderDetail.OrderId);
            return true;
        }

        public Order RefreshOrderTotal(int orderId)
        {
            var orderDetails = _orderDetailsRepository.GetByOrder(orderId);
            decimal total = 0;
            foreach (var orderDetail in orderDetails)
            {
                total += orderDetail.UnitCost * orderDetail.Quantity;
            }
            var order = _orderRepository.Get(orderId);
            order.Total = total;
            _orderRepository.Update(order);
            _orderRepository.Save();
            return order;
        }


        public Order GetOrder(int orderId)
        {
            return _orderRepository.Get(orderId);
        }
    }
}
