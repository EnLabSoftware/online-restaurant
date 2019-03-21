using Enterprise.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Logic.Services
{
    public interface ICustomerService
    {
        /// <summary>
        /// Register a new customer with the system
        /// </summary>
        /// <param name="newCustomer"></param>
        /// <returns></returns>
        Customer Register(Customer customer);


        Customer GetCustomer(int customerID);
        /// <summary>
        /// Login to the system by the given credential
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool Login(string userName, string password);


        IList<Customer> GetCustomers();

        IList<Customer> SearchCustomers(string searchKey);

        bool UpdateCustomer(Customer customer);


    }
}
