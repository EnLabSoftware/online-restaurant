using Enterprise.Logic.Entities;
using Enterprise.Logic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Repository.Repositories
{
    public class OrderDetailsRepository : Repository<OrderDetail>, IOrderDetailsRepository
    {
        public OrderDetailsRepository(EnterpriseEntities session)
            : base(session)
        {
        }

        public OrderDetail UpdateOrderDetailQuantity(int orderDetailsId, int quantity)
        {
            if (quantity > 0)
            {
                var orderDetail = Get(orderDetailsId);
                orderDetail.Quantity = quantity;
                Update(orderDetail);
                Save();
                return orderDetail;
            }
            return null;
        }

        public IList<OrderDetail> GetByOrder(int orderId)
        {
            return Session.OrderDetails.Where(t => t.OrderId == orderId).ToList();
        }

    }
}
