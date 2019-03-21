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
    public class MenuItemModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int MenuId { get; set; }

        [DataMember]
        public string Menu { get; set; }

        [DataMember]
        public int RestaurantId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string ImageLocation { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public int PreparationTime { get; set; }
       

    }
}
