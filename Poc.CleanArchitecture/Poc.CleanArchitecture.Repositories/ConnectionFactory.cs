using Microsoft.Data.SqlClient;
using Poc.CleanArchitecture.Common.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.CleanArchitecture.Data
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly IConnectionFactory _dbconnectionFactory;

        public IDbConnection GetConnection
        { 
            get {
                var sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = Environment.GetEnvironmentVariable("");

                sqlConnection.Open();
                return sqlConnection;
            }
        }

        public void Dispose()
        {
            _dbconnectionFactory?.Dispose();
        }
    }
}
