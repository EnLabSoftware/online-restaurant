using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise.Logic.Entities;

namespace Enterprise.Logic.Repositories
{
    public interface IOrderDetailsRepository : IRepository<OrderDetail>
    {
        OrderDetail UpdateOrderDetailQuantity(int orderDetailsId, int quantity);

        IList<OrderDetail> GetByOrder(int orderId);
    }
}
