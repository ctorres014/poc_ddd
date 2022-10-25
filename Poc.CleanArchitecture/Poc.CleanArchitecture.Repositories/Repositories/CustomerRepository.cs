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
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        private IDbConnection _connection;
        private IDbTransaction _transaction;

        public CustomerRepository(IDbConnection connection, IDbTransaction transaction) 
            : base(connection)
        {
            _connection = connection;
            _transaction = transaction;
        }

        public async Task<Customer> GetCustomerByID(string customerID)
        {
            using(var connection = _connection)
            {
                _connection.Open();
                string query = $"SELECT * FROM Custome WHERE customerID = { customerID }";
                return await _connection.QuerySingleAsync<Customer>(query, null, _transaction);
            }
        }

        public override Task<Customer> Update(Customer entity)
        {

            return base.Update(entity);
        }
    }
}
