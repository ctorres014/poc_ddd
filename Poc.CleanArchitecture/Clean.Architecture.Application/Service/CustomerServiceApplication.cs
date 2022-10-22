using Clean.Architecture.Application.Contract;
using Poc.CleanArchitecture.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Service
{
    public class CustomerServiceApplication : ICustomerServiceApplication
    {
        private ICustomerService _customerService;
        public CustomerServiceApplication(ICustomerService customerService) => 
            (_customerService) = (customerService);
       

        public Task<CustomerDTO> CustomerSearchByID(string customerId)
        {
            //var customer = _customerService.CustomerSearchByID(customerId);
            throw new NotImplementedException();
        }
    }
}
