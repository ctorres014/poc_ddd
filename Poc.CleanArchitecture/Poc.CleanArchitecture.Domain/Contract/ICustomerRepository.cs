using Poc.CleanArchitecture.Entities.Aggregates.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.CleanArchitecture.Domain.Contract
{
    public interface ICustomerRepository :  IRepository<Customer>
    {
        Task<Customer> GetCustomerByID(string customerID);

    }
}
