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
    public class OrderModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public System.DateTime SubmittedDate { get; set; }

        [DataMember]
        public string CustomerID { get; set; }
        [DataMember]
        public decimal Total { get; set; }
        [DataMember]
        public string ContactTelephone { get; set; }
        [DataMember]
        public string PostalCode { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public string StreetAddress { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string FulllName { get; set; }

        [DataMember]
        public int OrderStatusId { get; set; }

        [DataMember]
        public string OrderStatus { get; set; }
    }
}
