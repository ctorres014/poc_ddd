using Poc.CleanArchitecture.Domain.Contract;
using Poc.CleanArchitecture.Entities.Aggregates.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.CleanArchitecture.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer GetCustomerByID(string customerID)
        {
            throw new NotImplementedException();
        }
    }
}
