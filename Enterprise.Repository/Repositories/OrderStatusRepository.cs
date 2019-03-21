using Enterprise.Logic.Entities;
using Enterprise.Logic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Repository.Repositories
{
    public class OrderStatusRepository : Repository<OrderStatus>, IOrderStatusRepository
    {
        public OrderStatusRepository(EnterpriseEntities session)
            :base(session)
        {
        }

        public OrderStatus GetByName(string name)
        {
            return Session.OrderStatuses.FirstOrDefault(t => t.Name == name);
        }
    }
}
