using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise.Logic.Entities;

namespace Enterprise.Logic.Repositories
{
    public interface ICartRepository : IRepository<Cart>
    {
        bool RemoveFromCart(string cartId, int menuItemId);

        bool AddToCart(string cartId, int menuItemId,  int count, bool isGridUpdate);


        IList<Cart> GetCart(string cartId);

        void EmptyCart(string cartId);


        decimal GetTotal(string cartId);

        void MigrateCart(string cartId, string userID);

       
    }
}
