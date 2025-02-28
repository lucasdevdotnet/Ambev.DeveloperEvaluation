using Ambev.DeveloperEvaluation.Application.Products.CreateProduct;

namespace Ambev.DeveloperEvaluation.Application.SalesItems.CreateSaleItem;

/// <summary>
/// Represents the result of creating a sale item in the system.
/// This class holds the details of the created sale item.
/// </summary>
public class CreateSaleItemResult
{
    /// <summary>
    /// Gets or sets the product associated with the sale item.
    /// This is represented by a CreateProductResult.
    /// </summary>
    public CreateProductResult Product { get; set; } = null!;

    /// <summary>
    /// Gets or sets the quantity of the product sold.
    /// This value can be null if not provided.
    /// </summary>
    public int? Quantity { get; set; }

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
    /// This value is calculated as (Quantity * UnitPrice) - Discount.
    /// </summary>
    public decimal TotalPrice { get; set; }
}
