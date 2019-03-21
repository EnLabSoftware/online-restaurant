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
    public class ImageData
    {
        [DataMember]
        public string FileName { get; set; }

        [DataMember]
        public byte[] FileData { get; set; }
       

    }
}
