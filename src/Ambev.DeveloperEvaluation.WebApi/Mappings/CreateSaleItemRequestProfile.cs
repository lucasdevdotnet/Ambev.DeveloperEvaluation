using Ambev.DeveloperEvaluation.Application.SalesItems.CreateSaleItem;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSales;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Mappings;

public class CreateSaleItemRequestProfile : Profile
{
    public CreateSaleItemRequestProfile()
    {
        CreateMap<CreateSaleItemRequest, CreateSaleItemCommand>();
    }
}