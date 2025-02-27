namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale;

/// <summary>
/// Represents a request to create a new sale item in the system.
/// </summary>
public class GetSaleItemResponse
{
    /// <summary>
    /// The product associated with the sale item.
    /// </summary>
    public GetProductResponse Product { get; set; } = null!;

    /// <summary>
    /// The quantity of the product being sold.
    /// This value is nullable to allow optional input.
    /// </summary>
    public int? Quantity { get; set; }

    /// <summary>
    /// The unit price of the product at the time of sale.
    /// </summary>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// The discount applied to the sale item.
    /// </summary>
    public decimal Discount { get; set; }

    /// <summary>
    /// The total price of the sale item after applying the discount.
    /// </summary>
    public decimal TotalPrice { get; set; }
}
