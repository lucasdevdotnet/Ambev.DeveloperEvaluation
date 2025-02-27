/// <summary>
/// Namespace responsible for handling sales-related features in the Web API.
/// </summary>
namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale
{
    /// <summary>
    /// Represents a request to create a new customer associated with a sale.
    /// </summary>
    public class GetCustomerResponse
    {
        /// <summary>
        /// The name of the customer.
        /// </summary>
        public string Name { get; set; } = null!;
    }


}