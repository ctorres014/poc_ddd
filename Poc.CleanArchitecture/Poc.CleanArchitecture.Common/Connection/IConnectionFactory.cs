using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.CleanArchitecture.Common.Connection
{
    public interface IConnectionFactory : IDisposable
    {
         IDbConnection GetConnection { get; }
         
    }
}
