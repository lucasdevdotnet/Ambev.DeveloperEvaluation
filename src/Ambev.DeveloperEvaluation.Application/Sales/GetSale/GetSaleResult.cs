using Ambev.DeveloperEvaluation.Application.Customers.GetCustomer;
using Ambev.DeveloperEvaluation.Application.SalesItems.GetSalesItem;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale;

/// <summary>
/// Response model for GetUser operation
/// </summary>
public class GetSaleResult
{
    /// <summary>
    /// The unique identifier of the user
    /// </summary>
    public Guid Id { get; set; }

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
    public GetCustomerResult Customer { get; set; } = null!;

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
    public List<GetSalesItemResult> Items { get; set; } = null!;
}
