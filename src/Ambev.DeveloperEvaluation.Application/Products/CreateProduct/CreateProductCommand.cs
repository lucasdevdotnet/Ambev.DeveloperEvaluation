using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.CreateProduct;

/// <summary>
/// Represents a command to create a new product.
/// This command is handled by a request handler to process the creation logic.
/// </summary>
public class CreateProductCommand : IRequest<CreateProductResult>
{
    /// <summary>
    /// The name of the product to be created.
    /// Defaults to an empty string to prevent null values.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The unit price of the product.
    /// Defaults to 0M (decimal) to ensure a valid numeric value.
    /// </summary>
    public decimal UnitPrice { get; set; } = 0M;
}
