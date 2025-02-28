using Ambev.DeveloperEvaluation.Application.Customers.CreateCustomer;
using Ambev.DeveloperEvaluation.Application.Products.CreateProduct;
using Ambev.DeveloperEvaluation.Application.Sale.CreateSale;
using Ambev.DeveloperEvaluation.Application.SalesItems.CreateSaleItem;
using Bogus;

namespace Ambev.DeveloperEvaluation.Unit.Domain;

/// <summary>
/// Provides methods for generating test data using the Bogus library.
/// This class centralizes all test data generation to ensure consistency
/// across test cases and provide both valid and invalid data scenarios.
/// </summary>
public static class CreateSaleHandlerTestData
{
    private static List<CreateSaleItemCommand> GenerateFakeItems(Faker f)
    {
        var itemCount = f.Random.Int(1, 5);
        return Enumerable.Range(1, itemCount)
            .Select(_ => new CreateSaleItemCommand
            {
                Product = new CreateProductCommand
                {
                    Name = f.Commerce.ProductName(),
                    UnitPrice = f.Random.Decimal(10, 200)
                },
                Quantity = f.Random.Int(1, 20),
                UnitPrice = f.Random.Decimal(10, 200)
            })
            .ToList();
    }

    private static CreateCustomerCommand GenerateFakeCustomer(Faker f)
    {
        return new CreateCustomerCommand
        {
            Name = f.Person.UserName
        };
    }

    private static readonly Faker<CreateSaleCommand> createSaleHandlerFaker = new Faker<CreateSaleCommand>()
         .RuleFor(sale => sale.TotalAmount, f => f.Random.Decimal(50, 5000))
         .RuleFor(sale => sale.SaleDate, f => f.Date.Past(1))
         .RuleFor(sale => sale.Items, f => GenerateFakeItems(f))
         .RuleFor(sale => sale.Customer, f => GenerateFakeCustomer(f))
         .RuleFor(sale => sale.Branch, f => f.Company.CompanyName());

    /// <summary>
    /// Generates a valid User entity with randomized data.
    /// The generated sale will have all properties populated with valid values
    /// that meet the system's validation requirements.
    /// </summary>
    /// <returns>A valid User entity with randomly generated data.</returns>
    public static CreateSaleCommand GenerateValidCommand()
    {
        return createSaleHandlerFaker.Generate();
    }
}
