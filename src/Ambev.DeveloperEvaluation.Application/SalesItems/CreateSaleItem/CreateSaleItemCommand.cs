using Ambev.DeveloperEvaluation.Application.Products.CreateProduct;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.SalesItems.CreateSaleItem;

/// <summary>
/// Represents a command to create a new sale item in the system.
/// This command is handled asynchronously using MediatR.
/// </summary>
public class CreateSaleItemCommand : IRequest<CreateSaleItemResult>
{
    /// <summary>
    /// Gets or sets the product associated with the sale item.
    /// This product is represented by a CreateProductCommand.
    /// </summary>
    public CreateProductCommand Product { get; set; } = null!;

    /// <summary>
    /// Gets or sets the quantity of the product being sold.
    /// This value should be greater than zero.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Gets or sets the unit price of the product.
    /// This represents the price per unit before applying any discount.
    /// </summary>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// Gets or sets the discount applied to this sale item.
    /// This value represents the amount of discount in currency, not percentage.
    /// </summary>
    public decimal Discount { get; set; }

    /// <summary>
    /// Gets or sets the total price for this sale item.
    /// This value is calculated based on (Quantity * UnitPrice) - Discount.
    /// </summary>
    public decimal TotalPrice { get; set; }
}
