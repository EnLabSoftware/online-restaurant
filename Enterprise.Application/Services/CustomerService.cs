using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CuttingEdge.Conditions;
using Enterprise.Logic.Entities;
using Enterprise.Logic.Repositories;
using Enterprise.Logic.Exceptions;
using Enterprise.Logic.Services;
using Enterprise.Logic.Utility;

namespace Enterprise.Application.Services
{
    public class CustomerService : BaseService<Customer>, ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
            : base(customerRepository)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                .Requires(customerRepository, "customerRepository")
                .IsNotNull();

            _customerRepository = customerRepository;
        }

        public Customer Register(Customer customer)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                        .Requires(customer, "customer")
                        .IsNotNull();
            if(!ValidateCommon.IsValidEmail(customer.Email))
            {
                return null;
            }
            if(!ValidateCommon.IsValidState(customer.State))
            {
                return null;
            }
            //customer.Id = Guid.NewGuid().ToString();
            _customerRepository.Add(customer);
            _customerRepository.Save();
            return customer;
        }

        public bool Login(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public IList<Customer> GetCustomers()
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                        .Requires(_customerRepository, "_customerRepository")
                        .IsNotNull();
            return _customerRepository.GetAll();
        }

        public bool UpdateCustomer(Customer customer)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                        .Requires(customer, "customer")
                        .IsNotNull();
            return _customerRepository.Update(customer);
        }


        public Customer GetCustomer(int customerID)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                        .Requires(_customerRepository, "_customerRepository")
                        .IsNotNull();

            return _customerRepository.Get(customerID);
        }


        public IList<Customer> SearchCustomers(string searchKey)
        {
            Condition.WithExceptionOnFailure<InvalidParameterException>()
                        .Requires(_customerRepository, "_customerRepository")
                        .IsNotNull();
            return _customerRepository.GetAll().Where(t=>t.FullName.Contains(searchKey) || t.ContactTelephone.Contains(searchKey)).ToList() ;
        }
    }
}
