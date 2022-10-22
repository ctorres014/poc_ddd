using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using Poc.CleanArchitecture.Data.Repositories;
using Poc.CleanArchitecture.Domain.Contract;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.CleanArchitecture.DependencyInjection
{
    public static class DependencyInjectionData
    {
        public static void AddDapperSqlServer(this IServiceCollection service)
        {
            service.AddScoped<DbConnection>(provider => {
                return new SqlConnection(Environment.GetEnvironmentVariable(""));
            });

            service.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
