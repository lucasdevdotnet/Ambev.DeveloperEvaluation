using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary> 
/// Represents a sales transaction in the system.
/// This entity follows domain-driven design (DDD) principles.
/// </summary>
public class Sale : BaseEntity
{
    /// <summary>
    /// Gets or sets the unique sale number that identifies the sale transaction.
    /// </summary>
    public string SaleNumber { get; set; }

    /// <summary>
    /// Gets or sets the date when the sale was created.
    /// Defaults to the current date and time.
    /// </summary>
    public DateTime SaleDate { get; set; } = DateTime.Now;

    /// <summary>
    /// Gets or sets the unique identifier of the customer associated with the sale.
    /// </summary>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// Gets or sets the customer entity associated with the sale.
    /// </summary>
    public Customer Customer { get; set; } = null!;

    /// <summary>
    /// Gets or sets the total amount of the sale transaction.
    /// This represents the sum of all sale items including discounts.
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Gets or sets the branch where the sale was made.
    /// This is a required field.
    /// </summary>
    public string Branch { get; set; } = null!;

    /// <summary>
    /// Gets or sets a flag indicating whether the sale is canceled.
    /// Defaults to false.
    /// </summary>
    public bool IsCanceled { get; set; } = false;

    /// <summary>
    /// Gets or sets the list of items associated with this sale.
    /// Each item represents a product sold in this transaction.
    /// </summary>
    public List<SaleItem> Items { get; set; } = null!;
}
