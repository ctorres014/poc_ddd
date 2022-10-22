using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Poc.CleanArchitecture.Dto
{
    public class CustomerDTO
    {
        public string CustomerID { get; set; }  
        public string CompnyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public Contact Contact { get; set; }
    }


    public class Contact
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
    }
}
