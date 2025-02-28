namespace Ambev.DeveloperEvaluation.Application.Customers.GetCustomer;

/// <summary>
/// Response model for GetCustomer operation
/// </summary>
public class GetCustomerResult
{    /// <summary>
     /// The name of the get Customer.
     /// Defaults to an empty string to prevent null values.
     /// </summary>
    public string Name { get; set; } = string.Empty;
}
