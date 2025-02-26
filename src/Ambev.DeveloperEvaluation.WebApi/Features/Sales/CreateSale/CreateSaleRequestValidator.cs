using Ambev.DeveloperEvaluation.Application.SalesItems.CreateSaleItem;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;
using static Ambev.DeveloperEvaluation.Application.Sales.CreateSale.CreateSaleCommandValidator;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSales;


public class CreateSaleRequestValidator : AbstractValidator<CreateSaleRequest>
{
   
    public CreateSaleRequestValidator()
    {
        RuleFor(sale => sale.TotalAmount).NotEmpty();
        RuleFor(sale => sale.Items)
            .NotNull().WithMessage("The sale must have at least one item.")
            .Must(items => items != null && items.Any()).WithMessage("The sale must contain at least one item.");

        // Valida cada item na lista
        RuleForEach(sale => sale.Items).SetValidator(new CreateSaleItemRequestValidator());
        RuleFor(sale => sale.SaleDate).NotEmpty();
        RuleFor(sale => sale.Branch).NotEmpty();
        RuleFor(sale => sale.Customer).NotEmpty();
        RuleFor(sale => sale.Customer.Name).NotEmpty();
    }

    public class CreateSaleItemRequestValidator : AbstractValidator<CreateSaleItemRequest>
    {
        public CreateSaleItemRequestValidator()
        {
            RuleFor(item => item.Product).NotEmpty().NotNull();
            RuleFor(item => item.Product.Name).NotEmpty().NotNull();
            RuleFor(item => item.Product.UnitPrice).NotEmpty().NotNull();
            RuleFor(item => item.Product.Name).NotEmpty().NotNull();

            RuleFor(item => item.Quantity)
                .GreaterThan(0).WithMessage("The quantity must be greater than 0.");

            RuleFor(item => item.UnitPrice)
                .GreaterThan(0).WithMessage("The unit price must be greater than 0.");
        }
    }
}