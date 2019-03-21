using Enterprise.Logic.Entities;
using Enterprise.Logic.Exceptions;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Enterprise.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CartService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CartService.svc or CartService.svc.cs at the Solution Explorer and start debugging.
    public class CartService : ICartService
    {
        private readonly Logic.Services.ICartService _cartService;
        public CartService()
        {
            _cartService = ObjectFactory.GetInstance<Logic.Services.ICartService>();
        }
        public bool RemoveFromCart(string cartId, int menuItemId)
        {
            try
            {
                return _cartService.RemoveFromCart(cartId, menuItemId);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }

        public bool AddToCart(string cartId, int menuItemId, int count, bool isGridUpdate)
        {
            try
            {
                return _cartService.AddToCart(cartId, menuItemId, count, isGridUpdate);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }

        public IList<Logic.Entities.Cart> GetCart(string cartId)
        {
            try
            {
                return _cartService.GetCart(cartId);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }

        public void EmptyCart(string cartId)
        {
            try
            {
                _cartService.EmptyCart(cartId);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }

        public decimal GetTotal(string cartId)
        {
            try
            {
                return _cartService.GetTotal(cartId);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }

        public void MigrateCart(string cartId, string userId)
        {
            try
            {
                _cartService.MigrateCart(cartId, userId);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }


        public bool CheckOut(Order order)
        {
            try
            {
                return _cartService.Checkout(order);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }


        public List<OrderModel> GetOrderModel()
        {
            try
            {
                return _cartService.GetListOrderModel();
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }


        public List<OrderDetailModel> GetListOrderDetail(int orderId)
        {
            try
            {
                return _cartService.GetListOrderDetail(orderId);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }


        public OrderDetail UpdateOrderDetailQuantity(int orderDetailsId, int quantity)
        {
            try
            {
                return _cartService.UpdateOrderDetailQuantity(orderDetailsId, quantity);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }

        public IList<OrderStatus> GetOrderStatuses()
        {
            try
            {
                return _cartService.GetOrderStatuses();
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }


        public IList<Order> GetOrders()
        {
            try
            {
                return _cartService.GetOrders();
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }


        public Order UpdateOrder(Order order)
        {
            try
            {
                return _cartService.UpdateOrder(order);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }

        public bool DeleteOrder(int orderId)
        {
            try
            {
                return _cartService.DeleteOrder(orderId);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }


        public bool DeleteOrderDetails(int orderDetailsId)
        {
            try
            {
                return _cartService.DeleteOrderDetails(orderDetailsId);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }


        public Order GetOrder(int orderId)
        {
            try
            {
                return _cartService.GetOrder(orderId);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }
    }
}
