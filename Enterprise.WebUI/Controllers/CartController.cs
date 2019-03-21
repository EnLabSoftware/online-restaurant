using Enterprise.Logic.Entities;
using Enterprise.Logic.Utility;
using Enterprise.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Enterprise.WebUI.Controllers
{
    public class CartController : BaseController
    {
        //
        // GET: /Cart/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AddToCart(int menuItemId, int count, bool isGridUpdate)
        {
            var cartId = GetCartId(this.HttpContext);
            var cart = new Cart() { CartId = cartId, MenuItemId = menuItemId, Count = count };
            //bool result = PostData<Cart, bool>.PostDataToWebService(cart, ServiceUrl.CartAPI.AddToCart);
            var result = JsonUltility<bool>.GetJsonResult(string.Format(ServiceUrl.CartAPI.AddToCart, cartId, menuItemId, count, isGridUpdate));
            if (result)
            {
                dynamic objectReturn = new ExpandoObject();
                var cartSummary = RenderRazorViewToString(this, "_CartSummary", GetCartSummaryViewModel());
                objectReturn.CartSummary = cartSummary;
                return GetJsonResult(objectReturn, result, "Adding OK");
            }

            return GetJsonResult(result, result, "There was a problem when adding cart");
        }

        [HttpPost]
        public ActionResult RemoveFromCart(int menuItemId, bool isRefreshPage)
        {
            var cartId = GetCartId(this.HttpContext);
            var isRemoveSuccess = JsonUltility<bool>.GetJsonResult(string.Format(ServiceUrl.CartAPI.RemoveFromCart, cartId, menuItemId));
            if (isRemoveSuccess)
            {

                dynamic objectReturn = new ExpandoObject();
                if (!isRefreshPage)
                {
                    var cartSummary = RenderRazorViewToString(this, "_CartSummary", GetCartSummaryViewModel());
                    objectReturn.CartSummary = cartSummary;
                }
                return GetJsonResult(objectReturn, isRemoveSuccess, "Removing OK");
            }
            return GetJsonResult(isRemoveSuccess, isRemoveSuccess, "There was a problem when removing cart");

        }

        [ChildActionOnly]
        public ActionResult CartSummary()
        {
            return PartialView("_CartSummary", GetCartSummaryViewModel());
        }
        public ActionResult ViewCart()
        {
            return View(GetCartSummaryViewModel());
        }

        private CartSummaryViewModel GetCartSummaryViewModel()
        {
            var cartId = GetCartId(this.HttpContext);
            var total = JsonUltility<decimal>.GetJsonResult(string.Format(ServiceUrl.CartAPI.GetTotal, cartId));
            var listCart = new List<Cart>();
            if (total > 0)
            {
                listCart = JsonUltility<List<Cart>>.GetJsonResult(string.Format(ServiceUrl.CartAPI.GetCart, cartId));
            }
            var viewModel = new CartSummaryViewModel();
            viewModel.ListCart = listCart;
            viewModel.Total = total;
            return viewModel;
        }


    }
}