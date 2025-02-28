using Ambev.DeveloperEvaluation.Domain.Entities;
namespace Ambev.DeveloperEvaluation.Domain.Services.Interfaces;

/// <summary>
/// Repository interface for Sale entity operations
/// </summary>
public interface ISaleService
{
    /// <summary>
    /// Creates a new sale in the repository
    /// </summary>
    /// <param name="sale">The sale to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created sale</returns>
    Task<Sale> CreateAsync(Sale sale, CancellationToken cancellationToken = default);
}