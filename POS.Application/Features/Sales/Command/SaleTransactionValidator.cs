using FluentValidation;

namespace POS.Application.Features.Sales.Command
{
    public class SaleTransactionValidator:AbstractValidator<SalesTransactionsCommand>
    {
        public SaleTransactionValidator()
        {
            RuleFor(x => x.BranshId)
                .NotEmpty()
                .WithMessage("Branch ID is required.");
           // RuleFor(x=>x.)
        }
        private bool BeValidDiscount
    }
}
