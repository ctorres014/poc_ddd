using Poc.CleanArchitecture.Domain.Contract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Poc.CleanArchitecture.Data.Repositories
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        private IDbConnection _connection;

        public GenericRepository(IDbConnection connection) =>
            (_connection) = (connection);

        public Task<T> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> All()
        {
            throw new NotImplementedException();
        }

        public Task Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> FindById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> Search(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public virtual Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
