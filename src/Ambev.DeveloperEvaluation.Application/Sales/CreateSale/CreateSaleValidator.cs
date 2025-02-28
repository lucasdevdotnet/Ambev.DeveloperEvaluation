using Ambev.DeveloperEvaluation.Application.Sale.CreateSale;
using Ambev.DeveloperEvaluation.Application.SalesItems.CreateSaleItem;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Validator for the CreateSaleCommand class.
/// Ensures that all required fields are properly set and meet validation rules.
/// </summary>
public class CreateSaleCommandValidator : AbstractValidator<CreateSaleCommand>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateSaleCommandValidator"/> class.
    /// Defines validation rules for creating a sale.
    /// </summary>
    public CreateSaleCommandValidator()
    {
        // Ensures the total amount of the sale is not empty
        RuleFor(sale => sale.TotalAmount).NotEmpty();

        // Ensures the sale has at least one item
        RuleFor(sale => sale.Items)
            .NotNull().WithMessage("The sale must have at least one item.")
            .Must(items => items != null && items.Any()).WithMessage("The sale must contain at least one item.");

        // Validates each sale item using the CreateSaleItemCommandValidator
        RuleForEach(sale => sale.Items).SetValidator(new CreateSaleItemCommandValidator());

        // Ensures the sale date is not empty
        RuleFor(sale => sale.SaleDate).NotEmpty();

        // Ensures the branch information is provided
        RuleFor(sale => sale.Branch).NotEmpty();

        // Ensures the customer information is not empty
        RuleFor(sale => sale.Customer).NotEmpty();

        // Ensures the customer name is provided
        RuleFor(sale => sale.Customer.Name).NotEmpty();
    }

    /// <summary>
    /// Validator for the CreateSaleItemCommand class.
    /// Ensures that all sale item properties are correctly set.
    /// </summary>
    public class CreateSaleItemCommandValidator : AbstractValidator<CreateSaleItemCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSaleItemCommandValidator"/> class.
        /// Defines validation rules for individual sale items.
        /// </summary>
        public CreateSaleItemCommandValidator()
        {
            // Ensures the product field is not null or empty
            RuleFor(item => item.Product).NotEmpty().NotNull();

            // Ensures the product name is provided
            RuleFor(item => item.Product.Name).NotEmpty().NotNull();

            // Ensures the unit price of the product is specified
            RuleFor(item => item.Product.UnitPrice).NotEmpty().NotNull();

            // Ensures the product name is not empty (redundant rule, can be removed)
            RuleFor(item => item.Product.Name).NotEmpty().NotNull();

            // Ensures the quantity is greater than zero
            RuleFor(item => item.Quantity)
                .GreaterThan(0).WithMessage("The quantity must be greater than 0.");

            // Ensures the unit price is greater than zero
            RuleFor(item => item.UnitPrice)
                .GreaterThan(0).WithMessage("The unit price must be greater than 0.");
        }
    }
}
