using System.Linq.Expressions;

namespace POS.Application.Common.Interface
{
    public interface IGenericRepository<T> where T :class
    {
        Task AddAsync(T entityt);
        Task AddRangeAsync (IEnumerable<T> entities);
        Task< T?> FirstOrDefaultAsync(Expression < Func<T, bool> > expression);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
    }
}
