using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poc.CleanArchitecture.Entities.DataType;

namespace Poc.CleanArchitecture.Entities.Aggregates.Customer
{
    public class Customer
    {
        public string CustomerID { get; private set; }
        public string NameFirst { get; private set; }
        public string NameLast { get; private set; }
        private Contact Address { get; set; }

        private Customer()
        {

        }
    }
}
