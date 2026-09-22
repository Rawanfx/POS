using MediatR;
using POS.Application.Common.Models;

namespace POS.Application.Features.Sales.Command;

public record SalesTransactionsCommand(List<SalesTransactionItemsCommand> Items, Guid BranshId) : IRequest<Response<SalesTransactionResponse>>;

public class SalesTransactionItemsCommand
{
    public Guid ProductId { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal DiscountPercentage { get; set; }
    public int Quantity { get; set; }
}
public class SalesTransactionResponse
{
    public Guid SalesId { get; set; }
}
