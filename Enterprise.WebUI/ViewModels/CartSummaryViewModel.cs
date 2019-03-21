using Enterprise.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Enterprise.WebUI.ViewModels
{
    public class CartSummaryViewModel
    {
        public IList<Cart> ListCart { get; set; }

        public decimal Total { get; set; }

    }
}