using Poc.CleanArchitecture.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Service
{
    public interface ICustomerServiceApplication
    {
        Task<CustomerDTO> CustomerSearchByID(string customerId);
    }
}
