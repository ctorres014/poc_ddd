using Clean.Architecture.Application.Contract;
using Poc.CleanArchitecture.Domain.Contract;
using Poc.CleanArchitecture.Entities.Aggregates.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.CleanArchitecture.Domain.Service
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Customer> CustomerSearchByID(string customerID)
        {
            if(customerID == null) { throw new ArgumentNullException("El customerID no puede ser nulo"); }

            return await _customerRepository.GetCustomerByID(customerID);

        }
    }
}
