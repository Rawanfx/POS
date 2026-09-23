using MediatR;
using Microsoft.EntityFrameworkCore;
using POS.Application.Common.Interface;
using POS.Application.Common.Models;
using POS.Domain.Entities;

namespace POS.Application.Features.Sales.Command
{
    public class SalesTransactionsCommandHandler : IRequestHandler<SalesTransactionsCommand, Response<SalesTransactionResponse>>
    {
        private readonly ICurrentUserService userService;
        private readonly IUnitOfWork unitOfWork;
        public SalesTransactionsCommandHandler(ICurrentUserService userService, IUnitOfWork unitOfWork)
        {
            this.userService = userService;
            this.unitOfWork = unitOfWork;
        }
        public async Task<Response<SalesTransactionResponse>> Handle(SalesTransactionsCommand request, CancellationToken cancellationToken)
        {
            var productIds = request.Items.Select(x => x.ProductId).ToList();
            var products = await unitOfWork.ProductRepository.Where(x => productIds.Contains(x.Id)).ToListAsync(cancellationToken);
            var inventory = await unitOfWork.InventoryRepository.Where(x => productIds.Contains(x.ProductId)
            && x.BranchId == request.BranshId).ToListAsync(cancellationToken);

            foreach (var i in request.Items)
            {
                if (i.Quantity )
            }
        }
    }
}
