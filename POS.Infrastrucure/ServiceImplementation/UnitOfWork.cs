using Microsoft.EntityFrameworkCore.Storage;
using POS.Application.Common.Interface;
using POS.Domain.Entities;
using POS.Infrastrucure.Data;
using System.Data;
using System.Data.Common;

namespace POS.Infrastrucure.ServiceImplementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;
        public UnitOfWork(AppDbContext context)
        {
            this.context = context;
        }
        private IDbContextTransaction DbTransaction;

        public IGenericRepository<Sale> SaleRepository => new GenericRepository<Sale>(context);

        public IGenericRepository<SaleItems> SaleItemsRepository => new GenericRepository<SaleItems>(context);

        public async Task BeginTransactionAsync() =>
          DbTransaction=  await context.Database.BeginTransactionAsync();
        public async Task CommitTransactionAsync()=>await DbTransaction.CommitAsync();
        public async Task RollBackAsync() => await DbTransaction.RollbackAsync();
        public async Task SaveChangeAsync() => await context.SaveChangesAsync();
    }
}
