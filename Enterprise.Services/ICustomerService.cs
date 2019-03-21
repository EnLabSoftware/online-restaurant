using Enterprise.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Enterprise.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICustomerService" in both code and config file together.
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        [WebGet(UriTemplate = "getcustomers")]
        IList<Customer> GetCustomers();

        [OperationContract]
        [WebGet(UriTemplate = "searchcustomers")]
        IList<Customer> SearchCustomers(string searchKey);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "addcustomer")]
        Customer AddCustomer(Customer customer);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "updateCustomer")]
        bool UpdateCustomer(Customer customer);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "getcustomer")]
        Customer GetCustomer(int customerId);

        //[OperationContract]
        //[WebGet(UriTemplate = "getmenu/{id}")]
        //Menu GetMenu(string id);

        //[OperationContract]
        //[WebGet(UriTemplate = "getcompletemenu/{id}")]
        //Menu GetCompleteMenu(string id);

        //[OperationContract]
        //[WebInvoke(Method = "POST", UriTemplate = "addmenu")]
        //bool AddMenu(Menu menu);

        //[OperationContract]
        //[WebInvoke(Method = "POST", UriTemplate = "updatemenu")]
        //bool UpdateMenu(Menu menu);

        //[OperationContract]
        //[WebInvoke(Method = "POST", UriTemplate = "deletemenu/{id}")]
        //bool DeleteMenu(string id);
    }
}
