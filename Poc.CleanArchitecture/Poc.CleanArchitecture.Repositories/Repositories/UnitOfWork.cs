using Poc.CleanArchitecture.Domain.Contract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.CleanArchitecture.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbTransaction _dbTransaction;
        private IDbConnection _connection;

        public UnitOfWork(IDbConnection connection, IDbTransaction transaction)
        {
            _connection = connection;
            _dbTransaction = transaction;
        }

        public void BeginTransaction()
        {
           _dbTransaction = _connection.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                _dbTransaction.Commit();
            }
            catch (Exception ex)
            {
                _dbTransaction.Rollback();
                throw new Exception($"Exception transaction commit, reason: { ex.Message }");
            }
            finally
            {
                _dbTransaction.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbTransaction?.Dispose();
            }
        }
    }
}
