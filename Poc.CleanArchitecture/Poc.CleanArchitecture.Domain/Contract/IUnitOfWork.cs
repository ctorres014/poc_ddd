using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.CleanArchitecture.Domain.Contract
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        void BeginTransaction();
    }
}
