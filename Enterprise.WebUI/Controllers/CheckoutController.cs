using Enterprise.Logic.Entities;
using Enterprise.Logic.Utility;
using Enterprise.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Enterprise.WebUI.Controllers
{
    public class CheckoutController : BaseController
    {
        //
        // GET: /CheckOut/
        public ActionResult Index()
        {
            var cartId = GetCartId(this.HttpContext);
            var total = JsonUltility<decimal>.GetJsonResult(string.Format(ServiceUrl.CartAPI.GetTotal, cartId));
            var viewModel = new CheckOutViewModel {Total = total};
            return View(viewModel);
        }

        [HttpPost]
        public JsonResult Checkout(CheckOutViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var cartId = GetCartId(this.HttpContext);
                var order = new Order()
                {
                    CustomerID = cartId,
                    ContactTelephone = viewModel.ContactTelephone,
                    FulllName = viewModel.FullName,
                    Email = viewModel.Email,
                    PostalCode = viewModel.PostalCode,
                    City = viewModel.City,
                    State = viewModel.State,
                    StreetAddress = viewModel.StreetAddress,
                    SubmittedDate = DateTime.Now,
                };
                var result = PostData<Order, bool>.PostDataToWebService(order, ServiceUrl.CartAPI.CheckOut);
                var message = "Your order is being processed!";
                if (!result)
                {
                    message = "There was a problem when checking out cart";
                }
                return GetJsonResult(true, true, message);

            }

            return GetJsonResult(false, false, "There was a problem when checking out cart");
        }
    }
}