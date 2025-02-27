namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale;

/// <summary>
/// Response model for GetProduct operation
/// </summary>
public class GetProductResult
{    /// <summary>
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
