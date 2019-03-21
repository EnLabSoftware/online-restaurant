using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Enterprise.Logic.Utility
{
    public class JsonUltility<T>
    {
        public static T GetJsonResult(string url)
        {
            var client = new HttpClient();
            var result = client.GetStringAsync(url).Result;
            return JsonConvert.DeserializeObject<T>(result);
        }

    }

    public class PostData<TRequest, TResult>
    {
        public static TResult PostDataToWebService(TRequest requestData, string requestUrl)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-Type", "application/json");
                wc.Encoding = Encoding.UTF8;

                using (var ms = new MemoryStream())
                {
                    var jSrz = new  DataContractJsonSerializer(typeof (TRequest));
                    jSrz.WriteObject(ms, requestData);

                    var res1 = wc.UploadData(requestUrl, "POST", ms.ToArray());
                    using (var ms1 = new MemoryStream(res1))
                    {
                        jSrz = new DataContractJsonSerializer(typeof(TResult));
                        var result = (TResult)jSrz.ReadObject(ms1);

                        return result;
                    }
                }
            }
        }
    }
}
