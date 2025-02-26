using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.Services.Interfaces;

namespace Ambev.DeveloperEvaluation.Domain.Services
{
    /// <summary>
    /// Provides services for managing sales in the system.
    /// </summary>
    public class SaleService : ISaleService
    {
        private readonly ISaleRepository _saleRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="SaleService"/> class.
        /// </summary>
        /// <param name="saleRepository">The repository used for accessing sale data.</param>
        public SaleService(ISaleRepository saleRepository)
        {
            _saleRepository = saleRepository;
        }

        /// <summary>
        /// Creates a new sale asynchronously.
        /// </summary>
        /// <param name="sale">The sale to be created.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains the created sale.</returns>
        /// <exception cref="DomainException">Thrown when the sale has no items or when the quantity of an item exceeds the allowed limit.</exception>
        public Task<Sale> CreateAsync(Sale sale, CancellationToken cancellationToken = default)
        {
            // Validate that the sale has at least one item
            if (sale.Items == null || !sale.Items.Any())
                throw new DomainException("A sale must have at least one item.");

            // Process each item in the sale
            foreach (var item in sale.Items)
            {
                // Validate item quantity
                if (item.Quantity > 20)
                    throw new DomainException($"It is not possible to sell more than 20 units. You entered {item.Quantity} quantities.");

                // Calculate discount based on quantity
                CalculateDiscount(item);

                // Calculate total price for the item
                item.TotalPrice = (item.Quantity * item.UnitPrice) * (1 - item.Discount);
            }

            // Save the sale to the repository
            return _saleRepository.CreateAsync(sale, cancellationToken);
        }

        /// <summary>
        /// Calculates the discount for a sale item based on the quantity.
        /// </summary>
        /// <param name="item">The sale item for which the discount is calculated.</param>
        private static void CalculateDiscount(SaleItem item)
        {
            // Apply discount rules based on quantity
            if (item.Quantity >= 10 && item.Quantity <= 20)
                item.Discount = 0.20m; // 20% discount
            else if (item.Quantity >= 4 && item.Quantity < 10)
                item.Discount = 0.10m; // 10% discount
            else
                item.Discount = 0m; // No discount for fewer than 4 items
        }
    }
}