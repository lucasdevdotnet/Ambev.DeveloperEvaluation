using Ambev.DeveloperEvaluation.Application.Customers.CreateCustomer;
using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using Ambev.DeveloperEvaluation.Application.SalesItems.CreateSaleItem;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sale.CreateSale;

/// <summary>
/// Represents a command to create a new sale in the system.
/// This command is handled by a request handler that processes the creation logic.
/// </summary>
public class CreateSaleCommand : IRequest<CreateSaleResult>
{
    /// <summary>
    /// Unique identifier for the sale transaction.
    /// </summary>
    public string SaleNumber { get; set; }

    /// <summary>
    /// The date and time when the sale was made.
    /// Defaults to the current system date and time.
    /// </summary>
    public DateTime SaleDate { get; set; } = DateTime.Now;

    /// <summary>
    /// Customer information associated with the sale.
    /// This is a required field.
    /// </summary>
    public CreateCustomerCommand Customer { get; set; } = null!;

    /// <summary>
    /// The total amount of the sale, including all items, discounts, and applicable charges.
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// The branch where the sale was conducted.
    /// </summary>
    public string Branch { get; set; } = null!;

    /// <summary>
    /// Indicates whether the sale has been canceled.
    /// Defaults to false.
    /// </summary>
    public bool IsCanceled { get; set; } = false;

    /// <summary>
    /// A list of items included in the sale.
    /// Initialized as an empty list to prevent null reference issues.
    /// </summary>
    public List<CreateSaleItemCommand> Items { get; set; } = new List<CreateSaleItemCommand>();
}
