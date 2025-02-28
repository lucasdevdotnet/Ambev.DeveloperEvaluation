using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSales;

/// <summary>
/// Represents a request to create a new sale item in the system.
/// </summary>
public class CreateSaleItemRequest
{
    /// <summary>
    /// The product associated with the sale item.
    /// </summary>
    public CreateProductRequest Product { get; set; } = null!;

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
