using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Poc.CleanArchitecture.Domain.Contract
{
    public interface IRepository<T> where T : class
    {
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task Delete(T entity);
        Task<IEnumerable<T>> All();
        Task<IEnumerable<T>> FindById(string id);
        Task<IEnumerable<T>> Search(Expression<Func<T, bool>> predicate);
    }
}
