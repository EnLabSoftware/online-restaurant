using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Logic.Entities
{
    [DataContract]
    public class OrderDetailModel
    {
        public OrderDetailModel()
        {
            MenuItemId = 0;
            RestaurantId = 0;
        }
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int MenuItemId { get; set; }

        [DataMember]
        public string MenuItemName { get; set; }

        [DataMember]
        public int RestaurantId { get; set; }

        [DataMember]
        public string RestaurantName { get; set; }

        [DataMember]
        public int MenuId { get; set; }

        [DataMember]
        public string MenuName { get; set; }

        [DataMember]
        public decimal UnitPrice { get; set; }

        [DataMember]
        public decimal SalesValues { get; set; }

        [DataMember]
        public string CustomerSummary { get; set; }

        [DataMember]
        public decimal TotalMenuItem { get; set; }

        [DataMember]
        public int Quantity { get; set; }

        [DataMember]
        public decimal UnitCost { get; set; }
    }
}
