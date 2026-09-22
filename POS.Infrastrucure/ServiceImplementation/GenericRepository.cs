using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace POS.Infrastrucure.ServiceImplementation
{
    public class GenericRepository<T> : POS.Application.Common.Interface.IGenericRepository<T> where T : class
    {
        private readonly POS.Infrastrucure.Data.AppDbContext context;
        private readonly DbSet<T> dbSet;
        public GenericRepository(POS.Infrastrucure.Data.AppDbContext context)
        {
            this.context = context;
            dbSet =context.Set<T>();
        }
        public async Task AddAsync(T entityt) => await context.AddAsync(entityt);
        public async Task AddRangeAsync(IEnumerable<T> entities) => await context.AddRangeAsync(entities);
        public async Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> expression)=>await dbSet.FirstOrDefaultAsync(expression);
        public  IQueryable<T> Where(Expression<Func<T, bool>> expression) =>  dbSet.Where(expression);
    }
}
