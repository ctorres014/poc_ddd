using Poc.CleanArchitecture.Entities.Aggregates.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Contract
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> CustomerSearchByID(string customerID);
    }
}
