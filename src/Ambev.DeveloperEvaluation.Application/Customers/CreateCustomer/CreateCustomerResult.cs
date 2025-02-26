namespace Ambev.DeveloperEvaluation.Application.Customers.CreateCustomer;

/// <summary>
/// Represents the result of a customer creation operation.
/// This class is used as a response object when a customer is successfully created.
/// </summary>
public class CreateCustomerResult
{
    /// <summary>
    /// The name of the created customer.
    /// Defaults to an empty string to prevent null values.
    /// </summary>
    public string Name { get; set; } = string.Empty;
}
