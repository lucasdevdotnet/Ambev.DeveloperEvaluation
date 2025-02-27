namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale;

/// <summary>
/// API response model for  GetSale operation
/// </summary>
public class GetSaleResponse
{    /// <summary>
     /// Unique identifier Id
     /// </summary>
    public Guid? Id { get; set; }
    /// <summary>
    /// Unique identifier for the sale (e.g., invoice number).
    /// </summary>
    public string SaleNumber { get; set; }

    /// <summary>
    /// The date and time when the sale was made. Defaults to the current date/time.
    /// </summary>
    public DateTime SaleDate { get; set; } = DateTime.Now;

    /// <summary>
    /// The customer associated with the sale.
    /// </summary>
    public GetCustomerResponse Customer { get; set; } = null!;

    /// <summary>
    /// The total amount of the sale, including all items and discounts.
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// The branch/store where the sale was processed.
    /// </summary>
    public string Branch { get; set; } = null!;

    /// <summary>
    /// Indicates whether the sale was canceled. Defaults to false.
    /// </summary>
    public bool IsCanceled { get; set; } = false;

    /// <summary>
    /// List of items included in the sale.
    /// </summary>
    public List<GetSaleItemResponse> Items { get; set; } = null!;
}
