using Enterprise.Logic.Entities;
using Enterprise.Logic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Repository.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(EnterpriseEntities session)
            : base(session)
        {
        }

        public List<OrderModel> GetListOrderModel()
        {
            var results = (from order in Session.Orders
                           join status in Session.OrderStatuses on order.OrderStatusId equals status.Id
                           select new OrderModel
                           {
                               Id = order.Id,
                               SubmittedDate = order.SubmittedDate,
                               CustomerID = order.CustomerID,
                               Total = order.Total.Value,
                               ContactTelephone = order.ContactTelephone,
                               PostalCode = order.PostalCode,
                               State = order.State,
                               StreetAddress = order.StreetAddress,
                               City = order.City,
                               Email = order.Email,
                               FulllName = order.FulllName,
                               OrderStatusId = status.Id,
                               OrderStatus = status.Name,
                           }).ToList();
            return results;
        }

        public List<OrderDetailModel> GetListOrderDetail(int orderId)
        {
            var results = (from order in Session.Orders where order.Id == orderId
                           join orderDetails in Session.OrderDetails on order.Id equals orderDetails.OrderId
                           join menuItem in Session.MenuItems on orderDetails.MenuItemId equals menuItem.Id
                           join menu in Session.Menus on menuItem.MenuId equals menu.Id
                           join restaurant in Session.Restaurants on menu.RestaurantId equals restaurant.Id
                           select new OrderDetailModel
                           {
                               Id = orderDetails.Id,
                               MenuItemId = orderDetails.MenuItemId,
                               MenuItemName = menuItem.Name,
                               MenuId = menu.Id,
                               MenuName = menu.MenuType,
                               RestaurantId = restaurant.Id,
                               RestaurantName = restaurant.Name,
                               UnitPrice = menuItem.Price.HasValue ? menuItem.Price.Value : 0,
                               SalesValues = menuItem.Price.HasValue ? menuItem.Price.Value : 0,
                               Quantity = orderDetails.Quantity,
                               TotalMenuItem = orderDetails.Quantity * orderDetails.UnitCost,
                               UnitCost = orderDetails.UnitCost,
                               CustomerSummary = order.FulllName + "Tel: " + order.ContactTelephone + ". Address: " + order.StreetAddress + ", " + order.State + ", " + order.PostalCode + ".",
                           }).ToList();
            return results;
        }
    }
}
