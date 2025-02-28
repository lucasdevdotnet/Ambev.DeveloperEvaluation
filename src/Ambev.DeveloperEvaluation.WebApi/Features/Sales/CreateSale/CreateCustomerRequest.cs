/// <summary>
/// Namespace responsible for handling sales-related features in the Web API.
/// </summary>
namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    /// <summary>
    /// Represents a request to create a new customer associated with a sale.
    /// </summary>
    public class CreateCustomerRequest
    {
        /// <summary>
        /// The name of the customer.
        /// </summary>
        public string Name { get; set; } = null!;
    }
}
