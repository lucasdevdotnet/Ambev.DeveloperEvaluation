using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Customers.CreateCustomer;

/// <summary>
/// Represents a command to create a new customer in the system.
/// Implements the IRequest interface from MediatR to handle request-response logic.
/// </summary>
public class CreateCustomerCommand : IRequest<CreateCustomerResult>
{
    /// <summary>
    /// The name of the customer.
    /// Defaults to an empty string to prevent null values.
    /// </summary>
    public string Name { get; set; } = string.Empty;
}
