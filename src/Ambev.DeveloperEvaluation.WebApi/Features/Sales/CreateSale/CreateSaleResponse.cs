using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSales;

/// <summary>
/// API response model for CreateSales operation
/// </summary>
public class CreateSaleResponse
{
    /// <summary>
    /// Gets or sets the Number. Must be unique and contain only valid characters.
    /// </summary>
    public int Number { get; set; }
    /// <summary>
    /// Gets or sets the Date.
    /// </summary>
    public DateTime Date { get; set; }
    /// <summary>
    /// Gets or sets the Customer.
    /// </summary>
    public string Customer { get; set; }
    /// <summary>
    /// Gets or sets the Total.
    /// </summary>
    public decimal Total { get; set; }
    /// <summary>
    /// Gets or sets the Branch.
    /// </summary>
    public string Branch { get; set; }
    /// <summary>
    /// Gets or sets the AmountPrice.
    /// </summary>
    public int AmountPrice { get; set; }
    /// <summary>
    /// Gets or sets the UnitPrice.
    /// </summary>
    public decimal UnitPrice { get; set; }
    /// <summary>
    /// Gets or sets the DiscountsApplied.
    /// </summary>
    public int DiscountsApplied { get; set; }
    /// <summary>
    /// Gets or sets the TotalItemValue.
    /// </summary>
    public decimal TotalItemValue { get; set; }
    /// <summary>
    /// Gets or sets the Canceled.
    /// </summary>
    public bool Canceled { get; set; }
}
