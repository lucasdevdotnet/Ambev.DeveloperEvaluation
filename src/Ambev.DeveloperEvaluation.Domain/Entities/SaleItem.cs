using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    /// <summary>
    /// Represents a sale item in the system.
    /// </summary>
    public class SaleItem : BaseEntity
    {
        /// <summary>
        /// Gets or sets the unique identifier of the sale to which this item belongs.
        /// </summary>
        public Guid SaleId { get; set; }

        /// <summary>
        /// Gets or sets the sale associated with this item.
        /// </summary>
        public Sale Sale { get; set; } = null!;

        /// <summary>
        /// Gets or sets the unique identifier of the product associated with this item.
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// Gets or sets the product associated with this item.
        /// </summary>
        public Product Product { get; set; } = null!;

        /// <summary>
        /// Gets or sets the quantity of the product sold.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit price of the product at the time of sale.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets the discount applied to this sale item.
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// Gets or sets the total price of the sale item, calculated as (UnitPrice * Quantity) - Discount.
        /// </summary>
        public decimal TotalPrice { get; set; }
    }
}