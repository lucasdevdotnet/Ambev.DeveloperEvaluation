using Ambev.DeveloperEvaluation.Application.Sales.GetSale;

namespace Ambev.DeveloperEvaluation.Application.SalesItems.GetSalesItem;

/// <summary>
/// Response model for GetSalesItem operation
/// </summary>
public class GetSalesItemResult
{

    /// <summary>
    /// Gets or sets the product associated with the sale item.
    /// This is represented by a GetProductResult.
    /// </summary>
    public GetProductResult Product { get; set; } = null!;

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
