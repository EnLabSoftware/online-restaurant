using Enterprise.Logic.Entities;
using Enterprise.Logic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Repository.Repositories
{
    public class CartRepository : Repository<Cart>, ICartRepository
    {
        public CartRepository(EnterpriseEntities session)
            : base(session)
        {
        }

        public bool RemoveFromCart(string cartId, int menuItemId)
        {
            var cart = Session.Carts.FirstOrDefault(t => t.CartId == cartId && t.MenuItemId == menuItemId);
            this.Delete(cart);
            return this.Save();
        }

        public bool AddToCart(string cartId, int menuItemId, int count, bool isGridUpdate)
        {

            var cartItem = Session.Carts.FirstOrDefault(
                                         c => c.CartId == cartId
                                         && c.MenuItemId == menuItemId);
            var menuItem = Session.MenuItems.FirstOrDefault(t => t.Id == menuItemId);
            if (menuItem == null)
            {
                return false;
            }
            if (count < 1)
            {
                return false;
            }
            if (cartItem == null)
            {
                // Create a new cart item if no cart item exists
                cartItem = new Cart
                {
                    MenuItemId = menuItemId,
                    CartId = cartId,
                    Count = count,
                    UnitPrice = menuItem.Price,
                    DateCreated = DateTime.Now,
                    ImageLocation = menuItem.ImageLocation,
                    Name = menuItem.Name,
                };

                this.Add(cartItem);
            }
            else
            {
                // If the item does exist in the cart, then add one to the quantity
                if (isGridUpdate)
                {
                    cartItem.Count = count;
                }
                else
                {
                    cartItem.Count += count;
                }

                cartItem.UnitPrice = menuItem.Price;
                cartItem.ImageLocation = menuItem.ImageLocation;
                cartItem.Name = menuItem.Name;
                this.Update(cartItem);
            }

            return this.Save();
            // Save changes
        }

        public IList<Cart> GetCart(string cartId)
        {
            return Session.Carts.Where(t => t.CartId == cartId).ToList();
        }

        public void EmptyCart(string cartId)
        {
            IList<Cart> carts = Session.Carts.Where(t => t.CartId == cartId).ToList();
            foreach (var cart in carts)
            {
                Session.Carts.Remove(cart);

            }
            Session.SaveChanges();
        }


        public decimal GetTotal(string cartId)
        {
            var total = (from cartItems in Session.Carts
                              where cartItems.CartId == cartId
                              select (int?)cartItems.Count * cartItems.UnitPrice).Sum();
            if (total.HasValue == false)
            {
                total = 0;
            }
            return total.Value;
        }

        public void MigrateCart(string cartId, string userID)
        {
            var shoppingCart = Session.Carts.Where(c => c.CartId == cartId);

            foreach (var item in shoppingCart)
            {
                item.CartId = userID;
            }
            Session.SaveChanges();

        }
    }
}
