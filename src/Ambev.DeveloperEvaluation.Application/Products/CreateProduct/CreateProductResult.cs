namespace Ambev.DeveloperEvaluation.Application.Products.CreateProduct;

/// <summary>
/// Represents the result of a product creation operation.
/// This class is used as a response object when a product is successfully created.
/// </summary>
public class CreateProductResult
{
    /// <summary>
    /// The name of the created product.
    /// Defaults to an empty string to prevent null values.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The unit price of the created product.
    /// Defaults to 0 to ensure a valid numeric value.
    /// </summary>
    public decimal UnitPrice { get; set; } = 0;
}
