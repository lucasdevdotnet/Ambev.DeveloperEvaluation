using Ambev.DeveloperEvaluation.Application.SalesItems.GetSalesItem;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.SaleItems.GetSaleItem;

/// <summary>
/// Profile for mapping between Sale entity and GetSaleItemResponse
/// </summary>
public class GetSalesItemProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for GetSaleItem operation
    /// </summary>
    public GetSalesItemProfile()
    {
        CreateMap<SaleItem, GetSalesItemResult>();
    }
}
