using Enterprise.Logic.Exceptions;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Enterprise.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CustomerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CustomerService.svc or CustomerService.svc.cs at the Solution Explorer and start debugging.
    public class CustomerService : ICustomerService
    {
        private readonly Logic.Services.ICustomerService _customerService;
        public CustomerService()
        {
            _customerService = ObjectFactory.GetInstance<Logic.Services.ICustomerService>();
        }
        public void DoWork()
        {
        }

       
        public Logic.Entities.Customer AddCustomer(Logic.Entities.Customer customer)
        {
            try
            {
                return _customerService.Register(customer);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }


        public IList<Logic.Entities.Customer> GetCustomers()
        {
            try
            {
                return _customerService.GetCustomers().ToList();
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }


        public Logic.Entities.Customer GetCustomer(int customerId)
        {
            try
            {
                return _customerService.GetCustomer(customerId);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }


        public IList<Logic.Entities.Customer> SearchCustomers(string searchKey)
        {
            try
            {
                return _customerService.SearchCustomers(searchKey);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }

        public bool UpdateCustomer(Logic.Entities.Customer customer)
        {
            try
            {
                return _customerService.UpdateCustomer(customer);
            }
            catch (EnterpriseException enterpriseException)
            {
                throw new FaultException<EnterpriseException>(enterpriseException, enterpriseException.Message, new FaultCode(enterpriseException.ErrorCode));
            }
            catch (Exception exception)
            {
                throw new FaultException<Exception>(exception, exception.Message);
            }
        }
    }
}
