using Clean.Architecture.Application.Contract;
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
        public Task<Customer> CustomerSearchByID(string customerID)
        {
            throw new NotImplementedException();
        }
    }
}
