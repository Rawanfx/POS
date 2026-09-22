using POS.Domain.Entities;

namespace POS.Application.Common.Interface
{
    public interface IUnitOfWork
    {
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollBackAsync();
        Task SaveChangeAsync();
        public IGenericRepository<Sale> SaleRepository { get; }
        public IGenericRepository<SaleItems> SaleItemsRepository { get; }
    }
}
