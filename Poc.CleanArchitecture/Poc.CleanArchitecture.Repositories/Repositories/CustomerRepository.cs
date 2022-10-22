using Dapper;
using Poc.CleanArchitecture.Domain.Contract;
using Poc.CleanArchitecture.Entities.Aggregates.Customer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.CleanArchitecture.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private IDbConnection _connection;
        public CustomerRepository(IDbConnection connection) => (_connection) = (connection);

        public async Task<Customer> GetCustomerByID(string customerID)
        {
            string query = $"SELECT * FROM Custome WHERE customerID = { customerID }";

            return await _connection.QuerySingleAsync<Customer>(query);
        }
    }
}
